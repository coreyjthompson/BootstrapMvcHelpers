﻿namespace Mvc.Forms
{
    using System;
    using System.IO;
    using Mvc.Core;

    public class ControlContext : AnyContentElement, IControlContext
    {
        #region IControlContext

        public string FieldName { get; set; }

        public string DisplayName { get; set; }

        public object FieldValue { get; set; }

        public Type DataType { get; set; }

        public bool IsRequired { get; set; }

        public string[] Errors { get; set; }

        public bool HasErrors { get; set; }

        public bool HasWarning { get; set; }

        #endregion

        protected override string WriteSelfStartTag(TextWriter writer)
        {
            // nothing to write
            return string.Empty;
        }
    }
}
