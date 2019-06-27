﻿using System;
using Mvc.Core;
using Mvc.Buttons;

namespace Mvc
{
    public static class ButtonToolbarExtensions
    {
        #region Generation

        public static IItemWriter<ButtonToolbar, ButtonToolbarContent> ButtonToolbar(this IAnyContentMarker contentHelper)
        {
            return contentHelper.CreateWriter<ButtonToolbar, ButtonToolbarContent>();
        }

        public static ButtonToolbarContent BeginButtonToolbar(this IAnyContentMarker contentHelper)
        {
            return ButtonToolbar(contentHelper).BeginContent();
        }

        #endregion 
    }
}
