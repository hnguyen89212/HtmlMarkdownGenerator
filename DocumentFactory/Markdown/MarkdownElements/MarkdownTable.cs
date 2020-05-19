using DocumentFactory.ElementTraits;
using DocumentFactory.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentFactory.Markdown.MarkdownElements
{
    //public class MarkdownTable : IElement
    //{
    //    private MarkdownTableHeading heading;
    //    private List<MarkdownTableRow> rows;

    //    public MarkdownTable(string props)
    //    {
    //        var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Table"));
    //        heading = (MarkdownTableHeading)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableHeading", propsList[0]);
    //        rows = new List<MarkdownTableRow>();
    //        for (var i = 1; i < propsList.Length; i++)
    //        {
    //            rows.Add((MarkdownTableRow)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableRow", propsList[i]));
    //        }
    //    }

    //    public string toString()
    //    {
    //        string ret = "";
    //        ret += heading.toString();
    //        foreach (MarkdownTableRow row in rows)
    //        {
    //            ret += row.toString();
    //        }
    //        return ret;
    //    }
    //}

    public class MarkdownTable : TableTrait
    {
        public MarkdownTable(string props) : base(props, false)
        {
            //var propsList = props.Split(Helper.GetDelimeterOfPropsOfElement("Table"));
            //heading = (MarkdownTableHeading)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableHeading", propsList[0]);
            //rows = new List<MarkdownTableRow>();
            //for (var i = 1; i < propsList.Length; i++)
            //{
            //    rows.Add((MarkdownTableRow)MarkdownFactory.GetMarkdownFactoryInstance().CreateElement("TableRow", propsList[i]));
            //}
        }

        public override string toString()
        {
            string ret = "";
            ret += heading.toString();
            foreach (MarkdownTableRow row in rows)
            {
                ret += row.toString();
            }
            return ret;
        }
    }
}
