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
    /// Ordered;Item 1;Item 2;Item 3
    /// Unordered;Item 1;Item 2;Item 3
    /// </summary>
    class HtmlList : ListTrait
    {
        public HtmlList(string props) : base(props, true)
        {

        }

        public override string toString()
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
