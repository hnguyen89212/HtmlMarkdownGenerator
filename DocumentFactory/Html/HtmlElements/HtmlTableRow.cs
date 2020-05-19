using DocumentFactory.ElementTraits;
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
    /// Row$Some$Table$Text
    /// Row$Final$Table$Text
    /// </summary>
    public class HtmlTableRow : TableRowTrait
    {
        //private List<string> rowTexts;

        public HtmlTableRow(string props) : base(props)
        {
            //var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("TableRow"));
            //rowTexts = new List<string>();
            //for (var i = 1; i < propsList.Length; i++)
            //{
            //    rowTexts.Add(propsList[i]);
            //}
        }

        /// <summary>
        /// <tr><td>Some</td><td>Table</td><td>Text</td></tr>
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            string ret = "<tr>";
            foreach (string text in rowTexts)
            {
                ret += "<td>";
                ret += text;
                ret += "</td>";
            }
            ret += "</tr>";
            return ret;
        }
    }
}
