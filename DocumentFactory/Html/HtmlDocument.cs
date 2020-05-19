using System.Collections.Generic;
using System.IO;

namespace DocumentFactory.Html
{
    /// <summary>
    /// A concrete IDocument implementation to handle Html.
    /// </summary>
    public class HtmlDocument : IDocument
    {
        private string fileName;
        private List<IElement> elementsList;

        public HtmlDocument(string fileName)
        {
            this.fileName = fileName;
            using (File.Create(this.fileName)) { }
            this.elementsList = new List<IElement>();
        }

        public void AddElement(IElement element)
        {
            this.elementsList.Add(element);
        }

        public void RunDocument()
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
