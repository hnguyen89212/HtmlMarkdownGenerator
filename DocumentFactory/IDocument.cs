using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory
{
    /// <summary>
    /// An interface dictating the behavior of Document classes.
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Adds a new element into the current list of elements.
        /// </summary>
        /// <param name="element">The element to add</param>
        void AddElement(IElement element);

        /// <summary>
        /// Generates a Html & Markdown document in file system
        /// and opens them in Chrome.
        /// </summary>
        void RunDocument();
    }
}
