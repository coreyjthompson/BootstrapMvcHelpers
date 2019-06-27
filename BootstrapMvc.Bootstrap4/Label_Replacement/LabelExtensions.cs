namespace Mvc
{
    using System;
    using Mvc.Core;

    public static class LabelExtensions
    {
        [Obsolete("Use Badge instead")]
        public static IItemWriter<Badge, AnyContent> Label(this IAnyContentMarker contentHelper, object content)
        {
            return contentHelper.CreateWriter<Badge, AnyContent>().Type(BadgeType.DefaultGray).Content(content);
        }
    }
}
