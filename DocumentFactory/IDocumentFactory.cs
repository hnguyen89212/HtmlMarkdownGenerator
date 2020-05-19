using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    /// <summary>
    /// Abstract factory for Html and Markdown.
    /// </summary>
    public interface IDocumentFactory
    {
        /// <summary>
        /// Generates a file on disk given name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        IDocument CreateDocument(string fileName);

        /// <summary>
        /// Creates an element given type and properties.
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        IElement CreateElement(string elementType, string props);
    }
}
