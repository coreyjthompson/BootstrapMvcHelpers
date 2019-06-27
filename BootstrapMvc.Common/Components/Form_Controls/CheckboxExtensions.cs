namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Controls;

    public static class CheckboxExtensions
    {
        public static IItemWriter<Checkbox> Checkbox(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<Checkbox>();
        }

        public static IItemWriter<Checkbox> Checkbox(this IAnyContentMarker contentHelper, string text)
        {
            return contentHelper.CreateWriter<Checkbox>().Text(text);
        }
    }
}
