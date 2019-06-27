﻿namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Buttons;

    public static partial class ButtonGroupExtensions
    {
        #region Fluent

        public static IItemWriter<T, ButtonGroupContent> Vertical<T>(this IItemWriter<T, ButtonGroupContent> target, bool value = true) where T : ButtonGroup
        {
            target.Item.Vertical = value;
            return target;
        }

        public static IItemWriter<T, ButtonGroupContent> DropUp<T>(this IItemWriter<T, ButtonGroupContent> target, bool value = true) where T : ButtonGroup
        {
            target.Item.DropUp = value;
            return target;
        }

#if BOOTSTRAP3
        public static IItemWriter<T, ButtonGroupContent> Justified<T>(this IItemWriter<T, ButtonGroupContent> target, bool value = true) where T : ButtonGroup
        {
            target.Item.Justified = value;
            return target;
        }
#endif

        public static IItemWriter<T, ButtonGroupContent> AddButton<T, TButton>(this IItemWriter<T, ButtonGroupContent> target, IItemWriter<TButton, AnyContent> button) 
            where T : ButtonGroup
            where TButton : Button
        {
            target.Item.AddButton(button.Item);
            return target;
        }

        public static IItemWriter<T, ButtonGroupContent> AddButton<T, TButton>(this IItemWriter<T, ButtonGroupContent> target, params IItemWriter<TButton, AnyContent>[] buttons)
            where T : ButtonGroup
            where TButton : Button
        {
            foreach (var button in buttons)
            {
                AddButton(target, button);
            }
            return target;
        }

#endregion

#region Generation

        public static IItemWriter<ButtonGroup, ButtonGroupContent> ButtonGroup(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<ButtonGroup, ButtonGroupContent>();
        }

        public static IItemWriter<ButtonGroup, ButtonGroupContent> ButtonGroup(this IAnyContentMarker contentHelper, ButtonSize size)
        {
            return contentHelper.CreateWriter<ButtonGroup, ButtonGroupContent>().Size(size);
        }

        public static ButtonGroupContent BeginButtonGroup(this IAnyContentMarker contentHelper)
        {
            return ButtonGroup(contentHelper).BeginContent();
        }

        public static ButtonGroupContent BeginButtonGroup(this IAnyContentMarker contentHelper, ButtonSize size)
        {
            return ButtonGroup(contentHelper).Size(size).BeginContent();
        }

#endregion
    }
}
