using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html.HtmlElements
{
    /// <summary>
    /// Ordered;Item 1;Item 2;Item 3
    /// Unordered;Item 1;Item 2;Item 3
    /// </summary>
    class HtmlList : IElement
    {
        private string type;
        private List<HtmlListItem> list;

        public HtmlList(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("List"));
            type = propsList[0];
            list = new List<HtmlListItem>();
            for (var i = 1; i < propsList.Length; i++)
            {
                HtmlListItem item = new HtmlListItem(propsList[i]);
                list.Add(item);
            }
        }

        public string toString()
        {
            string ret = "";
            string prefix = (type == "Ordered") ? "<ol>" : "<ul>";
            ret += prefix + "\n";
            foreach (HtmlListItem item in list)
            {
                ret += "\t" + item.toString() + "\n";
            }
            string postfix = (type == "Ordered") ? "</ol>" : "</ul>";
            ret += postfix;
            return ret;
        }
    }
}
