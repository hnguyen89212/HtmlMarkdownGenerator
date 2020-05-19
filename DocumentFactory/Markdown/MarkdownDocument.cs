using System.Collections.Generic;
using System.IO;

namespace DocumentFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MarkdownDocument : IDocument
    {
        private string fileName;
        private List<IElement> elementsList;

        public MarkdownDocument(string fileName)
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
                foreach (IElement element in elementsList)
                {
                    writer.WriteLine(element.toString());
                }
            }
        }
    }
}
