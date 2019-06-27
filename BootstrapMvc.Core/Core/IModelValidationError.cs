﻿namespace Mvc.Core
{
    using System;

    public interface IModelValidationError
    {
        string Message { get; }

        bool IsWarning { get; }
    }
}
