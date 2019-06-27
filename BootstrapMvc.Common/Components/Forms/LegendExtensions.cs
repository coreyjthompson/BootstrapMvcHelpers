namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Forms;

    public static class LegendExtensions
    {
        #region Generation

        public static IItemWriter<Legend, AnyContent> FormLegend(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<Legend, AnyContent>();
        }

        #endregion
    }
}
