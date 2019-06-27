﻿namespace Mvc.Mvc5
{
    using System;
    using Mvc.Core;

    public class ItemWriter<TItem, TContent> : ItemWriter<TItem>, IItemWriter<TItem, TContent>
        where TItem : ContentElement<TContent>, IWritableItem
        where TContent : DisposableContent
    {
        public BootstrapHelper BootstrapHelper { get; private set; }

        public ItemWriter(TItem item, BootstrapHelper helper)
            : base(item)
        {
            BootstrapHelper = helper;
        }

        public TContent BeginContent()
        {
            return Item.BeginContent(BootstrapHelper.GetCurrentWriter(), BootstrapHelper);
        }

        public TContent BeginContent(System.IO.TextWriter writer)
        {
            return Item.BeginContent(writer, BootstrapHelper);
        }
    }
}
