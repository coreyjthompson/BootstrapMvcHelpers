namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.ListGroups;

    public static class IListGroupElementExtensions
    {
        public static IItemWriter<T> Type<T>(this IItemWriter<T> target, ListGroupItemType value)
            where T : IListGroupElement, IWritableItem
        {
            target.Item.Type = value;
            return target;
        }

        public static IItemWriter<T, TContent> Type<T, TContent>(this IItemWriter<T, TContent> target, ListGroupItemType value)
            where T : ContentElement<TContent>, IListGroupElement
            where TContent : DisposableContent
        {
            target.Item.Type = value;
            return target;
        }
    }
}
