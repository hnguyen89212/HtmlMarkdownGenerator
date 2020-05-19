

using DocumentFactory.ElementTraits;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// props is like Item 1
    /// </summary>
    public class MarkdownListItem : ListItemTrait
    {
        public MarkdownListItem(string props) : base(props)
        {

        }

        public override string toString()
        {
            return text;
        }
    }
}
