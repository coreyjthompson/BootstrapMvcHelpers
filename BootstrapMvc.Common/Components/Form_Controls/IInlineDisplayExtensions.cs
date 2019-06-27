namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class IInlineDisplayExtensions
    {
        #region Fluent

        public static IItemWriter<T> Inline<T>(this IItemWriter<T> target, bool inline = true)
            where T : IInlineDisplay, IWritableItem
        {
            target.Item.SetInline(inline);
            return target;
        }

        #endregion
    }
}
