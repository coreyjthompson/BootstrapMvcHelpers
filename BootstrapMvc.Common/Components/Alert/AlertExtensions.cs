﻿namespace Mvc
{
    using System;
    using Mvc.Core;

    public static class AlertExtensions
    {
        #region Fluent

        public static IItemWriter<T, AnyContent> Type<T>(this IItemWriter<T, AnyContent> target, AlertType value) 
            where T : Alert
        {
            target.Item.Type = value;
            return target;
        }

        public static IItemWriter<T, AnyContent> Closable<T>(this IItemWriter<T, AnyContent> target, bool value = true) 
            where T : Alert
        {
            target.Item.Closable = value;
            return target;
        }

        #endregion

        #region Generation

        public static IItemWriter<Alert, AnyContent> Alert(this IAnyContentMarker contentHelper, AlertType type)
        {
            return contentHelper.CreateWriter<Alert, AnyContent>().Type(type);
        }

        public static IItemWriter<Alert, AnyContent> Alert(this IAnyContentMarker contentHelper, AlertType type, object content)
        {
            return contentHelper.CreateWriter<Alert, AnyContent>().Type(type).Content(content);
        }

        public static IItemWriter<Alert, AnyContent> Alert(this IAnyContentMarker contentHelper, object content, AlertType type)
        {
            return contentHelper.CreateWriter<Alert, AnyContent>().Type(type).Content(content);
        }

        public static IItemWriter<Alert, AnyContent> Alert(this IAnyContentMarker contentHelper, AlertType type, params object[] contents)
        {
            return contentHelper.CreateWriter<Alert, AnyContent>().Type(type).Content(contents);
        }

        public static AnyContent BeginAlert(this IAnyContentMarker contentHelper, AlertType type)
        {
            return Alert(contentHelper, type).BeginContent();
        }

        #endregion
    }
}
