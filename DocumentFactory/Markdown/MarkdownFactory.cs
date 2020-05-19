using DocumentFactory.Markdown.MarkdownElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    /// <summary>
    /// A singleton factory to create Markdown documents and elements.
    /// </summary>
    public class MarkdownFactory : IDocumentFactory
    {
        /// <summary>
        /// The sole instance of MarkdownFactory throughout the application.
        /// </summary>
        private static MarkdownFactory _instance;

        private MarkdownFactory()
        {
            // Leaves empty.
        }

        /// <summary>
        /// The only gateway to access MarkdownFactory.
        /// </summary>
        /// <returns></returns>
        public static MarkdownFactory GetMarkdownFactoryInstance()
        {
            if (_instance == null)
            {
                _instance = new MarkdownFactory();
            }
            return _instance;
        }

        /// <summary>
        /// Creates a new Markdown document object with the given name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IDocument CreateDocument(string fileName)
        {
            return new MarkdownDocument(fileName);
        }

        /// <summary>
        /// Factory method to create various elements given the appropriate properties.
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IElement CreateElement(string elementType, string props)
        {
            switch (elementType)
            {
                default:
                    return null;
                case "Image":
                    return new MarkdownImage(props);
                case "Header":
                    return new MarkdownHeader(props);
                case "List":
                    return new MarkdownList(props);
                case "ListItem":
                    return new MarkdownListItem(props);
                case "Table":
                    return new MarkdownTable(props);
                case "TableHeading":
                    return new MarkdownTableHeading(props);
                case "TableRow":
                    return new MarkdownTableRow(props);
            }
        }
    }
}
