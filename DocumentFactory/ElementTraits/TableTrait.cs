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
    public class TableTrait : IElement
    {
        protected TableHeadingTrait heading;
        protected List<TableRowTrait> rows;

        public TableTrait(string props, bool isHtml = true)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Table"));
            rows = new List<TableRowTrait>();
            if (isHtml)
            {
                heading = (HtmlTableHeading)HtmlFactory.GetHtmlFactoryInstance().CreateElement("TableHeading", propsList[0]);
                for (var i = 1; i < propsList.Length; i++)
                {
                    rows.Add((HtmlTableRow)HtmlFactory.GetHtmlFactoryInstance().CreateElement("TableRow", propsList[i]));
                }
            }
            else
            {
                heading = (MarkdownTableHeading)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableHeading", propsList[0]);
                for (var i = 1; i < propsList.Length; i++)
                {
                    rows.Add((MarkdownTableRow)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableRow", propsList[i]));
                }
            }
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
