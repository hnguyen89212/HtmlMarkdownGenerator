using DocumentFactory.ElementTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    class MarkdownHeader : HeaderTrait
    {
        public MarkdownHeader(string props) : base(props)
        {

        }

        public override string toString()
        {
            string ret = "";
            for (var i = 0; i < Int16.Parse(level); i++)
            {
                ret += "#";
            }
            // We need a space between # and the text for it to take effect.
            ret += " " + headerText;
            return ret;
        }
    }
}
