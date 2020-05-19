using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    /// <summary>
    /// Base class for table heading.
    /// </summary>
    public class TableHeadingTrait : IElement
    {
        protected List<string> headingTexts;

        /// <summary>
        /// Constructs table heading.
        /// </summary>
        /// <param name="props"></param>
        public TableHeadingTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("TableHeading"));
            headingTexts = new List<string>();
            for (var i = 1; i < propsList.Length; i++)
            {
                headingTexts.Add(propsList[i]);
            }
        }

        /// <summary>
        /// Writes table heading to file.
        /// </summary>
        /// <returns></returns>
        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
