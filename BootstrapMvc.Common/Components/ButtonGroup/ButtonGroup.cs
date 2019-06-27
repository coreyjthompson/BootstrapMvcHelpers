﻿namespace Mvc.Buttons
{
    using System;
    using Mvc.Core;
    using System.Collections.Generic;

    public class ButtonGroup : ContentElement<ButtonGroupContent>, IButtonSizable
    {
        private List<Button> buttons;

        public ButtonSize Size { get; set; }

        public bool Vertical { get; set; }

        public bool DropUp { get; set; }

#if BOOTSTRAP3
        public bool Justified { get; set; }
#endif
                
        public void AddButton(Button value)
        {
            if (value == null)
            {
                return;
            }
            value.Parent = this;
            if (buttons == null)
            {
                buttons = new List<Button>();
            }
            buttons.Add(value);
        }

        protected override ButtonGroupContent CreateContentContext(IBootstrapContext context)
        {
            return new ButtonGroupContent(context, this);
        }

        protected override void WriteSelfStart(System.IO.TextWriter writer)
        {
            var tb = Helper.CreateTagBuilder("div");
            tb.AddCssClass("btn-group");
            tb.AddCssClass(Size.ToButtonGroupCssClass());
            if (Vertical)
            {
                tb.AddCssClass("btn-group-vertical");
            }
#if BOOTSTRAP3
            if (Justified)
            {
                tb.AddCssClass("btn-group-justified");
            }
#endif
            if (DropUp)
            {
                tb.AddCssClass("dropup");
            }
            tb.MergeAttribute("role", "group", true);

            ApplyCss(tb);
            ApplyAttributes(tb);

            tb.WriteStartTag(writer);

            if (buttons != null)
            {
                foreach (var button in buttons)
                {
                    button.WriteTo(writer);
                }
            }
        }

        protected override void WriteSelfEnd(System.IO.TextWriter writer)
        {
            writer.Write("</div>");
        }
    }
}
