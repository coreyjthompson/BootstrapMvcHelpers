namespace Mvc
{
    using System;
    using Mvc.Core;

    public static class BadgeExtensions
    {
        #region Generation

        public static IItemWriter<Badge, AnyContent> Badge(this IAnyContentMarker contentHelper, object content)
        {
            return contentHelper.CreateWriter<Badge, AnyContent>().Content(content);
        }

        #endregion
    }
}
