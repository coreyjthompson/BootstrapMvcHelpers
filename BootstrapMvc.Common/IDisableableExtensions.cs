﻿namespace Mvc
{
    using System;
    using Mvc.Core;

    public static class IDisableableExtensions
    {
        public static IItemWriter<T> Disabled<T>(this IItemWriter<T> target, bool disabled = true) 
            where T : IDisableable, IWritableItem
        {
            target.Item.SetDisabled(disabled);
            return target;
        }

        public static IItemWriter<T, TContent> Disabled<T, TContent>(this IItemWriter<T, TContent> target, bool disabled = true)
            where T : ContentElement<TContent>, IDisableable
            where TContent : DisposableContent
        {
            target.Item.SetDisabled(disabled);
            return target;
        }
    }
}
