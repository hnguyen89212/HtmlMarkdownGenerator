using DocumentFactory.Html;
using DocumentFactory.Markdown;

namespace DocumentFactory.Utilities
{
    /// <summary>
    /// A class to store utilities.
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Factory method to get either HtmlFactory or MarkdownFactory singleton.
        /// </summary>
        /// <param name="documentType"></param>
        /// <returns></returns>
        public static IDocumentFactory GetDocumentFactory(string documentType)
        {
            switch (documentType)
            {
                case "Markdown":
                case "markdown":
                    return MarkdownFactory.GetMarkdownFactoryInstance();
                default:
                    return HtmlFactory.GetHtmlFactoryInstance();
            }
        }

        /// <summary>
        /// Both Html and Markdown documents will have the same format in script.
        /// That means, the delimeters defined are exact for both, hence given a
        /// element type, we could get the delimeter for it through this single function.
        /// </summary>
        /// <param name="elementType"></param>
        /// <returns>The delimeter for an element in document.</returns>
        public static char GetDelimeterOfPropsOfElement(string elementType)
        {
            switch (elementType)
            {
                default:
                    return '@';
                case "Image":
                case "Header":
                case "List":
                case "Table":
                    return ';';
                case "TableRow":
                case "TableHeading":
                    return '$';
                case "ListItem":
                    return ' ';
            }
        }

        /// <summary>
        /// Gets the absolute path the the Chrome executable file to launch files.
        /// </summary>
        /// <returns></returns>
        public static string GetChromeExecutable()
        {
            return "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
        }
    }
}
