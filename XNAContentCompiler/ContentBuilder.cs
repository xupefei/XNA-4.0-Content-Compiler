using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Build.Construction;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;

namespace XNAContentCompiler
{
    public class ContentBuilder
    {
		private static readonly string targetsFile = @"$(MSBuildExtensionsPath)\Microsoft\XNA Game Studio\v4.0\Microsoft.Xna.GameStudio.ContentPipeline.targets";
		
		// What importers or processors should we load?
        private static readonly string xnaVersion = ", Version=4.0.0.0, PublicKeyToken=842cf8be1de50553";
		private static readonly string[] pipelineAssemblies =
        {
            "Microsoft.Xna.Framework.Content.Pipeline.FBXImporter" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.XImporter" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.TextureImporter" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.EffectImporter" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.AudioImporters" + xnaVersion,
            "Microsoft.Xna.Framework.Content.Pipeline.VideoImporters" + xnaVersion,

            // If you want to use custom importers or processors from
            // a Content Pipeline Extension Library, add them here.
            //
            // If your extension DLL is installed in the GAC, you should refer to it by assembly
            // name, eg. "MyPipelineExtension, Version=1.0.0.0, PublicKeyToken=1234567812345678".
            //
            // If the extension DLL is not in the GAC, you should refer to it by
            // file path, eg. "c:/MyProject/bin/MyPipelineExtension.dll".
        };


	    /// <summary>
	    /// Builds all the content files which have been added to the project,
	    /// dynamically creating .xnb files in the OutputDirectory.
	    /// </summary>
	    public bool Build(XnaContentProject xnaContentProject)
	    {
		    string tempPath = Path.Combine(Path.GetTempPath(), "XNAContentCompiler", Path.GetRandomFileName());

		    Project project = CreateProject(xnaContentProject, tempPath);
		    bool buildSuccess = BuildProject(project);
		    buildSuccess = buildSuccess && CopyOutput(xnaContentProject, tempPath);

		    return buildSuccess;
	    }

	    private Project CreateProject(XnaContentProject xnaContentProject, string tempPath)
	    {
		    // Create the build project.
		    ProjectRootElement projectRootElement = ProjectRootElement.Create();
		    // Include the standard targets file that defines how to build XNA Framework content.
		    projectRootElement.AddImport(targetsFile);

			// create the specific project
			Project buildProject = new Project(projectRootElement);
		    buildProject.SetProperty("XnaPlatform", "Windows");
		    buildProject.SetProperty("XnaProfile", "Reach");
		    buildProject.SetProperty("XnaFrameworkVersion", "v4.0");
		    buildProject.SetProperty("Configuration", "Release");
		    buildProject.SetProperty("OutputPath", tempPath);
		    buildProject.SetProperty("XNACompressContent", xnaContentProject.Compressed ? "true" : "false");

		    // Register any custom importers or processors.
		    foreach (string pipelineAssembly in pipelineAssemblies)
		    {
			    buildProject.AddItem("Reference", pipelineAssembly);
		    }

		    // add the content items
		    foreach (var contentItem in xnaContentProject.ContentItems)
		    {
			    ProjectItem item = buildProject.AddItem("Compile", contentItem.FilePath, new Dictionary<string, string>
			    {
				    {"Link", Path.GetFileName(contentItem.FilePath)},
				    {"Name", contentItem.ContentItem},
				    {"Importer", contentItem.Importer.ToString()},
				    {"Processor", contentItem.Processor.ToString()},
			    })[0];

			    if (contentItem.GenerateMipmaps.HasValue)
				    item.SetMetadataValue("ProcessorParameters_GenerateMipmaps", contentItem.GenerateMipmaps.Value ? "true" : "false");
				if (contentItem.PremultiplyAlpha.HasValue)
					item.SetMetadataValue("ProcessorParameters_PremultiplyAlpha", contentItem.PremultiplyAlpha.Value ? "true" : "false");
				if (contentItem.ResizeToPowerOfTwo.HasValue)
					item.SetMetadataValue("ProcessorParameters_ResizeToPowerOfTwo", contentItem.ResizeToPowerOfTwo.Value ? "true" : "false");
				if (contentItem.TextureFormat.HasValue)
					item.SetMetadataValue("ProcessorParameters_TextureFormat", contentItem.TextureFormat.ToString());
			    if (contentItem.ColorKeyEnabled.HasValue)
			    {
				    item.SetMetadataValue("ProcessorParameters_ColorKeyEnabled", contentItem.ColorKeyEnabled.Value ? "true" : "false");
				    if (contentItem.ColorKeyEnabled == true)
				    {
					    item.SetMetadataValue("ProcessorParameters_ColorKeyColor", string.Format("{0}, {1}, {2}, {3}", 
							contentItem.ColorKeyColor.R, contentItem.ColorKeyColor.G, contentItem.ColorKeyColor.B, contentItem.ColorKeyColor.A));
				    }
				}
				if (contentItem.Quality.HasValue)
					item.SetMetadataValue("ProcessorParameters_Quality", contentItem.Quality.ToString());
		    }

			return buildProject;
	    }

		private bool BuildProject(Project buildProject)
		{
			// Create and submit a new asynchronous build request.
			BuildParameters buildParameters = new BuildParameters(ProjectCollection.GlobalProjectCollection)
			{
				Loggers = new ILogger[] { new ErrorLogger(OnError) }
			};
			BuildManager.DefaultBuildManager.BeginBuild(buildParameters);

			BuildRequestData request = new BuildRequestData(buildProject.CreateProjectInstance(), new string[0]);
			BuildSubmission submission = BuildManager.DefaultBuildManager.PendBuildRequest(request);
			BuildResult result = submission.Execute();
			BuildManager.DefaultBuildManager.EndBuild();

			return result.OverallResult == BuildResultCode.Success;
		}

		private bool CopyOutput(XnaContentProject xnaContentProject, string tempPath)
		{
			Directory.CreateDirectory(xnaContentProject.OutputDirectory);
			foreach (var file in Directory.GetFiles(tempPath, "*.xnb"))
			{
				File.Copy(file, Path.Combine(xnaContentProject.OutputDirectory, Path.GetFileName(file)), true);
			}

			return true;
		}

		// handle build messages

	    public event EventHandler<ContentBuilderEventArgs> Error;

		private void OnError(ContentBuilderEventArgs e)
	    {
			EventHandler<ContentBuilderEventArgs> handler = Error;
		    if (handler != null)
		    {
			    handler(this, e);
		    }
	    }

		private class ErrorLogger : ILogger
		{
			private readonly Action<ContentBuilderEventArgs> onError;

			public ErrorLogger(Action<ContentBuilderEventArgs> onError)
			{
				this.onError = onError;
			}

			public void Initialize(IEventSource eventSource)
			{
				if (eventSource != null)
				{
					eventSource.ErrorRaised += (sender, e) => onError(new ContentBuilderEventArgs { Message = e.Message });
				}
			}

			void ILogger.Shutdown() { }
			string ILogger.Parameters { get; set; }
			LoggerVerbosity ILogger.Verbosity { get; set; }
		}
    }

	public class ContentBuilderEventArgs : EventArgs
	{
		public string Message { get; set; }
	}
}