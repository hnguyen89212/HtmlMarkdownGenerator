using DocumentFactory.Html;
using DocumentFactory.Html.HtmlElements;
using DocumentFactory.Markdown;
using DocumentFactory.Markdown.MarkdownElements;
using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    /// <summary>
    /// Base class for table.
    /// </summary>
    public class TableTrait : IElement
    {
        protected TableHeadingTrait heading;
        protected List<TableRowTrait> rows;

        /// <summary>
        /// Constructs table object.
        /// </summary>
        /// <param name="props"></param>
        /// <param name="isHtml"></param>
        public TableTrait(string props, bool isHtml = true)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Table"));
            rows = new List<TableRowTrait>();
            IDocumentFactory documentFactory = Helper.GetDocumentFactory((isHtml) ? "Html" : "Markdown");
            heading = (TableHeadingTrait)documentFactory.CreateElement("TableHeading", propsList[0]);
            for (var i = 1; i < propsList.Length; i++)
            {
                rows.Add((TableRowTrait)documentFactory.CreateElement("TableRow", propsList[i]));
            }
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
