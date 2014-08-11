using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace XNAContentCompiler
{
	public class XnaContentItem
	{
		// fields 

		private readonly Tuple<string, XnaContentImporters, XnaContentProcessors>[] defaults =
		{
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".mp3", XnaContentImporters.Mp3Importer, XnaContentProcessors.SongProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".wav", XnaContentImporters.WavImporter, XnaContentProcessors.SoundEffectProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".wma", XnaContentImporters.WmaImporter, XnaContentProcessors.SongProcessor),

			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".bmp", XnaContentImporters.TextureImporter, XnaContentProcessors.TextureProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".jpg", XnaContentImporters.TextureImporter, XnaContentProcessors.TextureProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".png", XnaContentImporters.TextureImporter, XnaContentProcessors.TextureProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".tga", XnaContentImporters.TextureImporter, XnaContentProcessors.TextureProcessor),
			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".dds", XnaContentImporters.TextureImporter, XnaContentProcessors.TextureProcessor),

			new Tuple<string, XnaContentImporters, XnaContentProcessors>(".spritefont", XnaContentImporters.FontDescriptionImporter, XnaContentProcessors.FontDescriptionProcessor)
		};

		// constructors

		public XnaContentItem(string filePath)
		{
			FilePath = filePath;

			var def = defaults.FirstOrDefault(x => x.Item1 == Path.GetExtension(filePath)) ??
				defaults.First(x => x.Item2 == XnaContentImporters.TextureImporter);

			Importer = def.Item2;
			Processor = def.Item3;
		}

		// properties

		[Category("Files")]
		public string FilePath { get; private set; }

		[Category("Files")]
		public string ContentItem { get { return Path.GetFileNameWithoutExtension(FilePath); } }

		[Category("Processing")]
		public XnaContentImporters Importer { get; set; }

		[Category("Processing")]
		public XnaContentProcessors Processor { get; set; }

		[Category("Textures")]
		public bool GenerateMipmaps { get; set; }
	}

	public enum XnaContentImporters
	{
		Mp3Importer,
		WavImporter,
		WmaImporter,
		TextureImporter,
		FontDescriptionImporter
	}

	public enum XnaContentProcessors
	{
		SongProcessor,
		SoundEffectProcessor,
		TextureProcessor,
		FontDescriptionProcessor
	}

	public class XnaContentProject
	{
		/// <summary>
		/// Gets or sets a value that indicates whether the compiled content is compressed.
		/// </summary>
		public bool Compressed { get; set; }

		/// <summary>
		/// Gets or sets a value indicating where the output files should go.
		/// </summary>
		public string OutputDirectory { get; set; }

		public IList<XnaContentItem> ContentItems { get; set; } 

	}
}