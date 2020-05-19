using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    public class ListItemTrait : IElement
    {
        protected string text;

        public ListItemTrait(string props)
        {
            text = props;
        }

        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
