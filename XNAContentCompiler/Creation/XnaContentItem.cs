using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;

namespace XNAContentCompiler.Creation
{
	public class XnaContentItem
	{
		// fields 

		private readonly Tuple<string, ContentImporters, ContentProcessors>[] defaults =
		{
			new Tuple<string, ContentImporters, ContentProcessors>(".mp3", ContentImporters.Mp3Importer, ContentProcessors.SongProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".wav", ContentImporters.WavImporter, ContentProcessors.SoundEffectProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".wma", ContentImporters.WmaImporter, ContentProcessors.SongProcessor),

			new Tuple<string, ContentImporters, ContentProcessors>(".bmp", ContentImporters.TextureImporter, ContentProcessors.TextureProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".jpg", ContentImporters.TextureImporter, ContentProcessors.TextureProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".png", ContentImporters.TextureImporter, ContentProcessors.TextureProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".tga", ContentImporters.TextureImporter, ContentProcessors.TextureProcessor),
			new Tuple<string, ContentImporters, ContentProcessors>(".dds", ContentImporters.TextureImporter, ContentProcessors.TextureProcessor),

			new Tuple<string, ContentImporters, ContentProcessors>(".spritefont", ContentImporters.FontDescriptionImporter, ContentProcessors.FontDescriptionProcessor)
		};

		// constructors

		public XnaContentItem(string filePath)
		{
			FilePath = filePath;

			var def = defaults.FirstOrDefault(x => x.Item1 == Path.GetExtension(filePath));
			if (def != null)
			{
				Importer = def.Item2;
				Processor = def.Item3;
			}
		}

		// properties

		[Category("Files")]
		[DisplayName("Path")]
		public string FilePath { get; private set; }

		[Category("Files")]
		[DisplayName("Name")]
		public string ContentItem { get { return Path.GetFileNameWithoutExtension(FilePath); } }

		[Category("Files")]
		[DisplayName("File Name")]
		public string FileName { get { return Path.GetFileName(FilePath); } }

		[Category("Processing")]
		public ContentImporters? Importer { get; set; }

		[Category("Processing")]
		public ContentProcessors? Processor { get; set; }

		// texture processors

		[Category("Processor - Texture")]
		[DisplayName("Generate Mipmaps")]
		public bool? GenerateMipmaps { get; set; }

		[Category("Processor - Texture")]
		[DisplayName("Use Color Key")]
		public bool? ColorKeyEnabled { get; set; }

		[Category("Processor - Texture")]
		[DisplayName("Pre-multiply Alpha")]
		public bool? PremultiplyAlpha { get; set; }

		[Category("Processor - Texture")]
		[DisplayName("Resize to Power of 2")]
		public bool? ResizeToPowerOfTwo { get; set; }

		[Category("Processor - Texture")]
		[DisplayName("Texture Format")]
		public TextureProcessorOutputFormat? TextureFormat { get; set; }

		[Category("Processor - Texture")]
		[DisplayName("Color Key")]
		public Color ColorKeyColor { get; set; }

		// audio processors

		[Category("Processor - Audio")]
		public ConversionQuality? Quality { get; set; }
	}
}