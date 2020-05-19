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
    public class HtmlImage : IElement
    {
        private string pathToImage;
        private string altText;
        private string titleText;

        /// <summary>
        /// props is like img/csharp.png;Alt Text;Title Text
        /// Since the order of the properties is not always the same, we need to check each prop in list.
        /// </summary>
        /// <param name="props"></param>
        public HtmlImage(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Image"));
            foreach(string each in propsList)
            {
                if (each.StartsWith("Title"))
                {
                    titleText = each;
                }
                else if (each.StartsWith("Alt"))
                {
                    altText = each;
                }
                else
                {
                    pathToImage = each;
                }
            }
        }

        public string toString()
        {
            return $"<img src='{pathToImage}' alt='{altText}' title='{titleText}' />";
        }
    }
}
