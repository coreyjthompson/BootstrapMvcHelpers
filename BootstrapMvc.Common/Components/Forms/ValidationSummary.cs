﻿namespace Mvc.Forms
{
    using System;
    using Mvc.Core;

    public abstract class ValidationSummary : WritableItem
    {
        public static string ErrorHeaderDefault { get; set; }

        public static string ErrorFooterDefault { get; set; }

        public static string WarningHeaderDefault { get; set; }

        public static string WarningFooterDefault { get; set; }
    }
}