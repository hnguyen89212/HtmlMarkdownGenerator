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
    public class HtmlHeader : IElement
    {
        private string level;
        private string headerText;

        public HtmlHeader(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Header"));
            level = propsList[0];
            headerText = propsList[1];
        }

        public string toString()
        {
            return $"<h{level}>{headerText}</h{level}>";
        }
    }
}
