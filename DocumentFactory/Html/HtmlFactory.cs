using DocumentFactory.Html.HtmlElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html
{
    /// <summary>
    /// 
    /// </summary>
    public class HtmlFactory : IDocumentFactory
    {
        private static HtmlFactory _instance;

        private HtmlFactory()
        {

        }

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
        /// 
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
