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
    /// props is like 1;The Header#
    /// </summary>
    public class HtmlHeader : HeaderTrait
    {

        public HtmlHeader(string props) : base(props)
        {
            // Leaves empty.
        }

        public override string toString()
        {
            return $"<h{level}>{headerText}</h{level}>";
        }
    }
}
