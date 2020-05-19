

using DocumentFactory.ElementTraits;

namespace DocumentFactory.Markdown.MarkdownElements
{
    /// <summary>
    /// Markdown list item.
    /// props is like Item 1
    /// </summary>
    public class MarkdownListItem : ListItemTrait
    {
        public MarkdownListItem(string props) : base(props)
        {
            // Leaves empty
        }

        public override string toString()
        {
            return text;
        }
    }
}
