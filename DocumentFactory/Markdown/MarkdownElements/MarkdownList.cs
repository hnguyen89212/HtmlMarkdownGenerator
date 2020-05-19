using DocumentFactory.ElementTraits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// Markdown list object.
    /// </summary>
    public class MarkdownList : ListTrait
    {
        public MarkdownList(string props) : base(props, false)
        {
            // Leaves empty
        }

        public override string toString()
        {
            string ret = "";
            if (type == "Ordered")
            {
                var count = 1;
                foreach(ListItemTrait each in list)
                {
                    ret += (count++) + ". " + each.toString() + "\n";
                }
            }
            else
            {
                foreach (ListItemTrait each in list)
                {
                    ret += "* " + each.toString() + "\n";
                }
            }
            return ret;
        }
    }
}
