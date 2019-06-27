namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Dropdown;

    public class Anchor : AnyContentElement, ILink, IDropdownMenuParentMarker
    {
        public string Href { get; set; }

        protected override string WriteSelfStartTag(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("a");
            tb.MergeAttribute("href", Href, true);

            ApplyCss(tb);
            ApplyAttributes(tb);

            tb.WriteStartTag(writer);

            return tb.GetEndTag();
        }

        void ILink.SetHref(string value)
        {
            Href = value;
        }
    }
}
