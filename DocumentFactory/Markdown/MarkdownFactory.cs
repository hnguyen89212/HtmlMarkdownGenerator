using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown
{
    public class MarkdownFactory : IDocumentFactory
    {
        private static MarkdownFactory _instance;

        private MarkdownFactory()
        {

        }

        public static MarkdownFactory GetMarkdownFactoryInstance()
        {
            if (_instance == null)
            {
                _instance = new MarkdownFactory();
            }
            return _instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public IDocument CreateDocument(string fileName)
        {
            return new MarkdownDocument(fileName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elementType"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IElement CreateElement(string elementType, string props)
        {
            throw new NotImplementedException();
        }
    }
}
