using DocumentFactory.ElementTraits;
using DocumentFactory.Html.HtmlElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    public class MarkdownTableRow : TableRowTrait
    {
        public MarkdownTableRow(string props) : base(props)
        {

        }

        public override string toString()
        {
            string ret = "";
            foreach (string text in rowTexts)
            {
                ret += "|" + text;
            }
            ret += "|\n";
            return ret;
        }
    }
}
