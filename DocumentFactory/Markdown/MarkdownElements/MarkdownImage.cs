using DocumentFactory.ElementTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    public class MarkdownImage : ImageTrait
    {
        public MarkdownImage(string props) : base(props)
        {

        }

        /// <summary>
        /// ![Alt Text](img/csharp.png "Title Text")
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            return $"![{altText}]({pathToImage} \"{titleText}\")";
        }
    }
}
