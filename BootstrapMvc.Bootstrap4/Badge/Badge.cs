﻿namespace Mvc
{
    using Mvc.Core;

    public class Badge : AnyContentElement
    {
        public BadgeType Type { get; set; }

#if BOOTSTRAP4
        public bool Pill { get; set; }
#endif

        protected override string WriteSelfStartTag(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("span");
            tb.AddCssClass(Type.ToCssClass());

#if BOOTSTRAP4
            if (Pill)
            {
                tb.AddCssClass("tag-pill");
            }
#endif

            ApplyCss(tb);
            ApplyAttributes(tb);

            tb.WriteStartTag(writer);

            return tb.GetEndTag();
        }
    }
}
