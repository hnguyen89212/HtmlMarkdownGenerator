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
    /// A class to represent `img` element in HTML5.
    /// </summary>
    public class HtmlImage : ImageTrait
    {
        public HtmlImage(string props) : base(props)
        {
            // Leaves empty
        }

        public override string toString()
        {
            return $"<img src='{pathToImage}' alt='{altText}' title='{titleText}' />";
        }
    }
}
