namespace Mvc.Controls
{
    using System;
    using Mvc.Core;

    public class SelectContent : SelectOptGroupContent
    {
        public SelectContent(IBootstrapContext context, IWritableItem parent)
            : base(context, parent)
        {
            // Nothing
        }

        public IItemWriter<SelectOptGroup, SelectOptGroupContent> OptGroup(string label)
        {
            return Context.Helper.CreateWriter<SelectOptGroup, SelectOptGroupContent>(Parent).Label(label);
        }
    }
}
