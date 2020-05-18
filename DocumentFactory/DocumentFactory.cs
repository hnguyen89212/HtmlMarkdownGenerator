using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    /// <summary>
    /// A factory to create Html and Markdown.
    /// Needs to be implemented as singleton.
    /// </summary>
    public class DocumentFactory
    {
        private static DocumentFactory _documentFactoryInstance;

        private DocumentFactory()
        {
            // @TODO
        }

        /// <summary>
        /// Returns the singleton DocumentFactory object in the whole application.
        /// </summary>
        /// <returns></returns>
        public static DocumentFactory GetDocumentFactoryInstance()
        {
            return _documentFactoryInstance;
        }

        /// <summary>
        /// Needs to be able to create a concrete Document implementation.
        /// </summary>
        /// <returns></returns>
        public virtual IDocument MakeDocument(string documentType)
        {
            switch (documentType) {
                default:
                    return null;
                case "html":
                    // @TODO
                    return null;
                case "markdown":
                case "md":
                    // @TODO
                    return null;
            }
        }
    }
}
