namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class IValueHolderExtensions
    {
        public static IItemWriter<T> Value<T>(this IItemWriter<T> target, object value)
            where T : IValueHolder, IWritableItem
        {
            target.Item.Value = value;
            return target;
        }

        public static IItemWriter<T, TContent> Value<T, TContent>(this IItemWriter<T, TContent> target, object value)
            where T : ContentElement<TContent>, IValueHolder
            where TContent : DisposableContent
        {
            target.Item.Value = value;
            return target;
        }
    }
}
