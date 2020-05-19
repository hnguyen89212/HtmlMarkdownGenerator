using DocumentFactory.Html.HtmlElements;

namespace DocumentFactory.Html
{
    /// <summary>
    /// A singleton factory to create Html documents and elements.
    /// </summary>
    public class HtmlFactory : IDocumentFactory
    {
        /// <summary>
        /// The sole instance of HtmlFactory throughout the application.
        /// </summary>
        private static HtmlFactory _instance;

        /// <summary>
        /// Makes it private to hide the constructor from outer access.
        /// </summary>
        private HtmlFactory()
        {
            // Leaves empty
        }

        /// <summary>
        /// The only gateway to access HtmlFactory.
        /// </summary>
        /// <returns></returns>
        public static HtmlFactory GetHtmlFactoryInstance()
        {
            if (_instance == null)
            {
                _instance = new HtmlFactory();
            }
            return _instance;
        }

        /// <summary>
        /// Creates a new HtmlDocument object with the given name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IDocument CreateDocument(string fileName)
        {
            return new HtmlDocument(fileName);
        }

        /// <summary>
        /// Factory method to create various elements given the appropriate properties.
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IElement CreateElement(string elementType, string props)
        {
            switch(elementType)
            {
                default:
                    return null;
                case "Image":
                    return new HtmlImage(props);
                case "Header":
                    return new HtmlHeader(props);
                case "List":
                    return new HtmlList(props);
                case "ListItem":
                    return new HtmlListItem(props);
                case "Table":
                    return new HtmlTable(props);
                case "TableHeading":
                    return new HtmlTableHeading(props);
                case "TableRow":
                    return new HtmlTableRow(props);
            }
        }
    }
}
