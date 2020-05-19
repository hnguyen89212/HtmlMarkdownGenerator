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
    /// Html table heading.
    /// props is like Head$Table Heading 1$Table Heading 2$Table Heading 3
    /// </summary>
    public class HtmlTableHeading : TableHeadingTrait
    {
        public HtmlTableHeading(string props) : base(props)
        {
            // Leaves empty
        }

        /// <summary>
        /// <thead><tr><th>Table Heading 1</th><th>Table Heading 2</th><th>Table Heading 3</th></tr></thead>
        /// </summary>
        /// <returns></returns>
        public override string toString()
        {
            string ret = "<thead><tr>";
            foreach (string text in headingTexts)
            {
                ret += "<th>";
                ret += text;
                ret += "</th>";
            }
            ret += "</tr></thead>";
            return ret;
        }
    }
}
