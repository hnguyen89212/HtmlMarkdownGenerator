using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html.HtmlElements
{
    /// <summary>
    /// props is like
    /// Head$Table Heading 1$Table Heading 2$Table Heading 3;Row$Some$Table$Text;Row$More$Table$Text;Row$Final$Table$Text
    /// 
    /// </summary>
    public class HtmlTable : IElement
    {
        private HtmlTableHeading heading;
        private List<HtmlTableRow> rows;

        public HtmlTable(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Table"));
            heading = (HtmlTableHeading)HtmlFactory.GetHtmlFactoryInstance().CreateElement("TableHeading", propsList[0]);
            rows = new List<HtmlTableRow>();
            for (var i = 1; i < propsList.Length; i++)
            {
                rows.Add((HtmlTableRow)HtmlFactory.GetHtmlFactoryInstance().CreateElement("TableRow", propsList[i]));
            }
        }

        public string toString()
        {
            string ret = "<table>";
            ret += heading.toString();
            foreach (HtmlTableRow row in rows)
            {
                ret += row.toString();
            }
            ret += "</table>";
            return ret;
        }
    }
}
