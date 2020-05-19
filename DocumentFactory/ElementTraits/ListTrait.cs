using DocumentFactory.Html;
using DocumentFactory.Html.HtmlElements;
using DocumentFactory.Markdown;
using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    /// <summary>
    /// Ordered;Item 1;Item 2;Item 3
    /// Unordered;Item 1;Item 2;Item 3
    /// </summary>
    public class ListTrait : IElement
    {
        protected string type;
        protected List<ListItemTrait> list;

        public ListTrait(string props, bool isHtml = true)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("List"));
            type = propsList[0];
            list = new List<ListItemTrait>();
            for (var i = 1; i < propsList.Length; i++)
            {
                ListItemTrait item = null;
                if (isHtml)
                {
                    item = (ListItemTrait)HtmlFactory.GetHtmlFactoryInstance().CreateElement("ListItem", propsList[i]);
                }
                else
                {
                    // We need to pass down the ordered/unordered information to Markdown list item.
                    //var localProps = type + " " + propsList[i];
                    var localProps = propsList[i];
                    item = (ListItemTrait)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("ListItem", localProps);
                }
                list.Add(item);
            }
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
