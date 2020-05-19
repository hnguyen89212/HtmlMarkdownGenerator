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
    /// props is like Item 1
    /// </summary>
    public class HtmlListItem : ListItemTrait
    {
        public HtmlListItem(string props) : base(props)
        {

        }

        public override string toString()
        {
            return $"<li>{text}</li>";
        }
    }
}
