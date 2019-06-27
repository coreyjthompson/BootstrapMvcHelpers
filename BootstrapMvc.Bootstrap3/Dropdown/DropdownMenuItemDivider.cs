namespace Mvc.Dropdown
{
    using System;
    using Mvc.Core;

    public class DropdownMenuItemDivider : Element, IDropdownMenuItem
    {
        protected override void WriteSelf(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("li");
            tb.AddCssClass("divider");
            tb.MergeAttribute("role", "presentation", true);

            tb.WriteFullTag(writer);
        }
    }
}
