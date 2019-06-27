namespace Mvc.Tables
{
    using System;

    public partial class TableHeader : TableSection
    {
        protected override string GetTagName()
        {
            return "thead";
        }
    }
}
