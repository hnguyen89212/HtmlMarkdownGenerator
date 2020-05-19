using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Utilities
{
    public class Helper
    {
        public static char GetDelimeterOfPropsOfElement(string elementType)
        {
            switch(elementType)
            {
                default:
                    return '@';
                case "Image":
                case "Header":
                case "List":
                case "Table":
                    return ';';
                case "TableRow":
                case "TableHeading":
                    return '$';
                case "ListItem":
                    return ' ';
            }
        }
    }
}
