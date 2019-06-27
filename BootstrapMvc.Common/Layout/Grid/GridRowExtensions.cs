namespace Mvc
{
    using System;
    using Mvc.Core;
    using Mvc.Grid;

    public static class GridRowExtensions
    {
        public static IItemWriter<GridRow, GridRowContent> GridRow(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<GridRow, GridRowContent>();
        }

        public static GridRowContent BeginGridRow(this IAnyContentMarker contentHelper)
        {
            return GridRow(contentHelper).BeginContent();
        }
    }
}
