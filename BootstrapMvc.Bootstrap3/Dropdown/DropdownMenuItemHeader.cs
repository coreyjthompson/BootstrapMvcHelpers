using System;
using Mvc.Core;

namespace Mvc.Dropdown
{
    public class DropdownMenuItemHeader : AnyContentElement, IDropdownMenuItem
    {
        protected override string WriteSelfStartTag(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("li");
            tb.AddCssClass("dropdown-header");
            tb.MergeAttribute("role", "presentation", true);

            tb.WriteStartTag(writer);

            return tb.GetEndTag();
        }
    }
}
