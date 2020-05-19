using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    public class ImageTrait : IElement
    {
        protected string pathToImage;
        protected string altText;
        protected string titleText;

        public ImageTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Image"));
            foreach (string each in propsList)
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

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
