namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class ITextDisplayExtensions
    {
        public static IItemWriter<T> Text<T>(this IItemWriter<T> target, string text)
            where T : ITextDisplay, IWritableItem
        {
            target.Item.Text = text;
            return target;
        }
    }
}
