namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class StaticValueExtensions
    {
        public static IItemWriter<StaticValue> StaticValue(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<StaticValue>();
        }
    }
}
