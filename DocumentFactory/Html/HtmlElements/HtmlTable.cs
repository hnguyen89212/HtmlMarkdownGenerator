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
    /// Html table object.
    /// </summary>
    public class HtmlTable : TableTrait
    {
        public HtmlTable(string props) : base(props)
        {
            // Leaves empty
        }

        public override string toString()
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
