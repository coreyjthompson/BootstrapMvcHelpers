namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class RadioExtensions
    {
        public static IItemWriter<Radio> Radio(this IAnyContentMarker contentHelper, object value, string text)
        {
            return contentHelper.CreateWriter<Radio>().Text(text).Value(value.ToString());
        }
    }
}
