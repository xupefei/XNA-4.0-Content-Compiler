using System.Collections.Generic;
using System.ComponentModel;

namespace XNAContentCompiler.Creation
{
	public class XnaContentProject
	{
		/// <summary>
		/// Gets or sets a value that indicates whether the compiled content is compressed.
		/// </summary>
		public bool Compressed { get; set; }

		/// <summary>
		/// Gets or sets a value indicating where the output files should go.
		/// </summary>
		[DisplayName("Output Directory")]
		public string OutputDirectory { get; set; }

		[Browsable(false)]
		public IList<XnaContentItem> ContentItems { get; set; } 
	}
}