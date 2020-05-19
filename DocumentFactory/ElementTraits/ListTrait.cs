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
    /// Base class for list.
    /// </summary>
    public class ListTrait : IElement
    {
        protected string type;
        protected List<ListItemTrait> list;

        /// <summary>
        /// Constructs the list.
        /// </summary>
        /// <param name="props"></param>
        /// <param name="isHtml"></param>
        public ListTrait(string props, bool isHtml = true)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("List"));
            type = propsList[0];
            list = new List<ListItemTrait>();
            IDocumentFactory documentFactory = (isHtml) ? Helper.GetDocumentFactory("Html") : Helper.GetDocumentFactory("Markdown");
            for (var i = 1; i < propsList.Length; i++)
            {
                ListItemTrait item = null;
                item = (ListItemTrait)documentFactory.CreateElement("ListItem", propsList[i]);
                list.Add(item);
            }
        }

        /// <summary>
        /// Writes the list to file.
        /// </summary>
        /// <returns></returns>
        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
