using System;

namespace Mvc
{
    public interface IDisableable
    {
        void SetDisabled(bool disabled = true);

        bool Disabled();
    }
}
