using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    public class HeaderTrait : IElement
    {
        protected string level;
        protected string headerText;

        public HeaderTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Header"));
            level = propsList[0];
            headerText = propsList[1];
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
