﻿namespace Mvc.Core
{
    using System;

    public interface IBootstrapContext<TModel> : IBootstrapContext
    {
        new IWritingHelper<TModel> Helper { get; }
    }
}
