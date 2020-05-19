using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentFactory
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDocumentFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        IDocument CreateDocument(string fileName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        IElement CreateElement(string elementType, string props);
    }
}
