﻿namespace Mvc
{
    using System;
    using Mvc.Core;

    public static class MarkersExtensions
    {
        public static IItemWriter<T> Placeholder<T>(this IItemWriter<T> target, string placeholder) 
            where T : Element, IPlaceholderTarget
        {
            target.Attribute("placeholder", placeholder);
            return target;
        }

        public static IItemWriter<T, TContent> Placeholder<T, TContent>(this IItemWriter<T, TContent> target, string placeholder)
            where T : ContentElement<TContent>, IPlaceholderTarget
            where TContent: DisposableContent
        {
            target.Attribute("placeholder", placeholder);
            return target;
        }
    }
}
