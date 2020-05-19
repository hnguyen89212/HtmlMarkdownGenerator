using DocumentFactory.DocumentTraits;
using System.Collections.Generic;
using System.IO;

namespace DocumentFactory.Html
{
    /// <summary>
    /// A concrete IDocument implementation to handle Html.
    /// </summary>
    public class HtmlDocument : DocumentTrait
    {
        /// <summary>
        /// Creates Html file object.
        /// </summary>
        /// <param name="fileName"></param>
        public HtmlDocument(string fileName) : base(fileName)
        {
            // Leaves empty.
        }

        public override void RunDocument()
        {
            using (var writer = new StreamWriter(this.fileName, true))
            {
                writer.WriteLine("<!DOCTYPE html><html><head></head><body>");
                foreach (IElement element in elementsList)
                {
                    writer.WriteLine(element.toString());
                }
                writer.WriteLine("</body></html>");
            }
        }
    }
}
