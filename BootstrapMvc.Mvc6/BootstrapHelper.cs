﻿namespace Mvc.Mvc6
{
    using System;
    using System.Collections.Generic;
    using System.Text.Encodings.Web;

    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.Routing;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Routing;

    using Mvc.Core;

    public class BootstrapHelper: IAnyContentMarker, IViewContextAware, IWritingHelper, IBootstrapContext
    {
        private const string ParentStackContextKey = "Mvc.Mvc6.BootstrapHelper.Parents";

        protected IBootstrapContext bootstrapContext;

        private Stack<IWritableItem> parents;

        public BootstrapHelper(IUrlHelperFactory urlHelperFactory, HtmlEncoder htmlEncoder)
        {
            this.UrlHelperFactory = urlHelperFactory;
            this.HtmlEncoder = htmlEncoder;
        }

        protected Func<int, string> MessageSource { get; set; }

        protected ViewContext ViewContext { get; set; }

        protected IUrlHelperFactory UrlHelperFactory { get; set; }

        protected IUrlHelper UrlHelper { get; set; }

        protected HtmlEncoder HtmlEncoder { get; set; }

        public System.IO.TextWriter GetCurrentWriter()
        {
            return ViewContext.Writer;
        }

        public virtual void Contextualize(ViewContext viewContext)
        {
            ViewContext = viewContext;
            UrlHelper = UrlHelperFactory.GetUrlHelper(viewContext);
            parents = (Stack<IWritableItem>)viewContext.HttpContext.Items[ParentStackContextKey];
            if (parents == null)
            {
                parents = new Stack<IWritableItem>(5);
                parents.Push(null);
                viewContext.HttpContext.Items[ParentStackContextKey] = parents;
            }
        }

        #region IAnyContentMarker

        IBootstrapContext IAnyContentMarker.Context
        {
            get
            {
                return this;
            }
        }

        #endregion

        #region IBootstrapContext

        IWritableItem IBootstrapContext.GetCurrentParent()
        {
            return parents.Peek();
        }

        void IBootstrapContext.PushParent(IWritableItem parent)
        {
            parents.Push(parent);
        }

        void IBootstrapContext.PopParent(IWritableItem parentToMatch)
        {
            var current = parents.Pop();
            if (!Object.ReferenceEquals(current, parentToMatch))
            {
                throw new Exception("Parents do not match");
            }
        }

        IWritingHelper IBootstrapContext.Helper
        {
            get
            {
                return this;
            }
        }

        #endregion

        public string CreateUrl(UrlActionContext actionContext)
        {
            return UrlHelper.Action(actionContext);
        }

        #region IWritingHelper

        IItemWriter<T> IWritingHelper.CreateWriter<T>(IWritableItem parent)
        {
            var item = new T();
            item.Parent = parent;
            item.Helper = this;
            var writer = new ItemWriter<T>(item);
            return writer;
        }

        IItemWriter<T, TContent> IWritingHelper.CreateWriter<T, TContent>(IWritableItem parent)
        {
            var item = new T();
            item.Parent = parent;
            item.Helper = this;
            var writer = new ItemWriter<T, TContent>(item, this);
            return writer;
        }

        ITagBuilder IWritingHelper.CreateTagBuilder(string tagName)
        {
            return new TagBuilder(tagName, HtmlEncoder);
        }

        string IWritingHelper.CreateUrl(IDictionary<string, object> routeValues)
        {
            return ((IWritingHelper)this).CreateUrl(routeValues, null, null);
        }

        string IWritingHelper.CreateUrl(IDictionary<string, object> routeValues, string protocol, string hostName)
        {
            var routeVals = routeValues as RouteValueDictionary;
            if (routeVals == null)
            {
                routeVals = new RouteValueDictionary(routeValues);
            }
            return UrlHelper.Action(null, null, routeVals, protocol, hostName, null);
        }

        string IWritingHelper.HtmlEncode(string value)
        {
            return HtmlEncoder.Encode(value);
        }

        void IWritingHelper.WriteValue(System.IO.TextWriter writer, object value)
        {
            if (value == null)
            {
                return;
            }
            var writable = value as IWritable;
            if (writable != null)
            {
                writable.WriteTo(writer);
                return;
            }
            var htmlContent = value as IHtmlContent;
            if (htmlContent != null)
            {
                htmlContent.WriteTo(writer, HtmlEncoder);
                return;
            }
            var str = value as string;
            if (str != null)
            {
                writer.Write(HtmlEncoder.Encode(str));
                return;
            }

            writer.Write(value);
        }

        #endregion
    }
}
