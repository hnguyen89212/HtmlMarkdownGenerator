using DocumentFactory.ElementTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// Image element in Markdown document.
    /// </summary>
    public class MarkdownImage : ImageTrait
    {
        public MarkdownImage(string props) : base(props)
        {
            // Leaves empty
        }

        /// <summary>
        /// Generates markdown image format ![Alt Text](img/csharp.png "Title Text")
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            return $"![{altText}]({pathToImage} \"{titleText}\")";
        }
    }
}
