using DocumentFactory.ElementTraits;
using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// Markdown table object.
    /// </summary>
    public class MarkdownTable : TableTrait
    {
        public MarkdownTable(string props) : base(props, false)
        {
            // Leaves empty
        }

        public override string toString()
        {
            string ret = "";
            ret += heading.toString();
            foreach (MarkdownTableRow row in rows)
            {
                ret += row.toString();
            }
            return ret;
        }
    }
}
