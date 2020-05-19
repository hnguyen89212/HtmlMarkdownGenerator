using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Html.HtmlElements
{
    /// <summary>
    /// props is like Item someplaceholder
    /// </summary>
    public class HtmlListItem : IElement
    {
        private string text;

        public HtmlListItem(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("ListItem"));
            text = propsList[1];
        }

        public string toString()
        {
            return $"<li>Item {text}</li>";
        }
    }
}
