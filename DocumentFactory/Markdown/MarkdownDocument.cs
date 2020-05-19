using DocumentFactory.DocumentTraits;
using System.Collections.Generic;
using System.IO;

namespace DocumentFactory.Markdown
{
    /// <summary>
    /// A concrete IDocument implementation to handle Markdown.
    /// </summary>
    public class MarkdownDocument : DocumentTrait
    {
        /// <summary>
        /// Creates Markdown file object.
        /// </summary>
        /// <param name="fileName"></param>
        public MarkdownDocument(string fileName) : base(fileName)
        {
            // Leaves empty.
        }

        public override void RunDocument()
        {
            using (var writer = new StreamWriter(this.fileName, true))
            {
                foreach (IElement element in elementsList)
                {
                    writer.WriteLine(element.toString());
                }
            }
        }
    }
}
