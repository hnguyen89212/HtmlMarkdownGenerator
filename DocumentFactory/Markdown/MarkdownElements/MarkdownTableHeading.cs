using DocumentFactory.ElementTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// Markdown table heading.
    /// </summary>
    public class MarkdownTableHeading : TableHeadingTrait
    {
        public MarkdownTableHeading(string props) : base(props)
        {
            // Leaves empty
        }

        public override string toString()
        {
            string ret = "";
            foreach (string text in headingTexts)
            {
                ret += "|" + text;
            }
            ret += "|\n";
            // Horizontal line separating header row
            for (var i = 0; i < headingTexts.Count; i++)
            {
                ret += "|---";
            }
            ret += "|\n";
            return ret;
        }
    }
}
