using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.DocumentTraits
{
    /// <summary>
    /// The base class for Html and Markdown.
    /// </summary>
    public class DocumentTrait : IDocument
    {
        protected string fileName;
        protected List<IElement> elementsList;

        /// <summary>
        /// Constructs the document object.
        /// </summary>
        /// <param name="name"></param>
        public DocumentTrait(string name)
        {
            fileName = name;
            using (File.Create(this.fileName)) { }
            elementsList = new List<IElement>();
        }

        /// <summary>
        /// Appends element to document object.
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(IElement element)
        {
            elementsList.Add(element);
        }

        /// <summary>
        /// Writes the file to disk. Due to differences in the formats,
        /// the concrete classes implement this.
        /// </summary>
        public virtual void RunDocument()
        {
            throw new NotImplementedException();
        }
    }
}
