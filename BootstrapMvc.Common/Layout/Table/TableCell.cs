namespace Mvc.Tables
{
    using System;
    using Mvc.Core;

    public class TableCell : AnyContentElement
    {
        public TableRowCellColor Color { get; set; } = TableRowCellColor.DefaultNone;

        protected override string WriteSelfStartTag(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("td");
            if (Color != TableRowCellColor.DefaultNone)
            {
                tb.AddCssClass(Color.ToCssClass());
            }

            ApplyCss(tb);
            ApplyAttributes(tb);

            tb.WriteStartTag(writer);

            return tb.GetEndTag();
        }
    }
}
