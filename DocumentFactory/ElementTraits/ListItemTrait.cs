using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.ElementTraits
{
    /// <summary>
    /// Base class for list item.
    /// </summary>
    public class ListItemTrait : IElement
    {
        protected string text;

        /// <summary>
        /// Constructs a list item.
        /// </summary>
        /// <param name="props"></param>
        public ListItemTrait(string props)
        {
            text = props;
        }

        /// <summary>
        /// Write list item to file.
        /// </summary>
        /// <returns></returns>
        public virtual string toString()
        {
            throw new NotImplementedException();
        }
    }
}
