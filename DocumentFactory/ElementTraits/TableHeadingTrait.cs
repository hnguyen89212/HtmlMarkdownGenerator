using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    public class TableHeadingTrait : IElement
    {
        protected List<string> headingTexts;

        public TableHeadingTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("TableHeading"));
            headingTexts = new List<string>();
            for (var i = 1; i < propsList.Length; i++)
            {
                headingTexts.Add(propsList[i]);
            }
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
