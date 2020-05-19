using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    public class TableRowTrait : IElement
    {
        protected List<string> rowTexts;

        public TableRowTrait(string props)
        {
            var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("TableRow"));
            rowTexts = new List<string>();
            for (var i = 1; i < propsList.Length; i++)
            {
                rowTexts.Add(propsList[i]);
            }
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
