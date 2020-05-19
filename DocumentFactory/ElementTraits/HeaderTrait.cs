using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    /// <summary>
    /// Base class for header element.
    /// </summary>
    public class HeaderTrait : IElement
    {
        protected string level;
        protected string headerText;

        /// <summary>
        /// Constructs the header element.
        /// </summary>
        /// <param name="props"></param>
        public HeaderTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Header"));
            level = propsList[0];
            headerText = propsList[1];
        }

        /// <summary>
        /// Writes the header to file.
        /// </summary>
        /// <returns></returns>
        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
