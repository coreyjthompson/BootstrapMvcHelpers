namespace Mvc.Forms
{
    using System;
    using Mvc.Core;

    public interface IForm : IWritableItem
    {
        SubmitMethod Method { get; }

        FormEnctype Enctype { get; }

        FormType Type { get; }

        string Href { get; }

        GridSize LabelWidth { get; }

        GridSize ControlsWidth { get; }
    }
}
