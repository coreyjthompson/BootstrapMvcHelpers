namespace Mvc.Core
{
    using System;

    public interface IAnyContentMarker<T> : IAnyContentMarker
    {
        new IBootstrapContext<T> Context { get; }
    }
}
