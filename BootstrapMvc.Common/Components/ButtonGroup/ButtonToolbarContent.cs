namespace Mvc.Buttons
{
    using System;
    using Mvc.Core;

    public class ButtonToolbarContent : DisposableContent
    {
        public ButtonToolbarContent(IBootstrapContext context, ButtonToolbar parent)
        {
            this.Context = context;
        }

        private IBootstrapContext Context { get; set; }

        private ButtonToolbar Parent { get; set; }

        #region ButtonGroup

        public IItemWriter<ButtonGroup, ButtonGroupContent> ButtonGroup()
        {
            return Context.Helper.CreateWriter<ButtonGroup, ButtonGroupContent>(Parent);
        }

        public IItemWriter<ButtonGroup, ButtonGroupContent> ButtonGroup(ButtonSize size)
        {
            return ButtonGroup().Size(size);
        }

        public ButtonGroupContent BeginButtonGroup()
        {
            return ButtonGroup().BeginContent();
        }

        public ButtonGroupContent BeginButtonGroup(ButtonSize size)
        {
            return ButtonGroup(size).BeginContent();
        }

        #endregion
    }
}
