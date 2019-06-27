using System;

namespace Mvc
{
    public enum Visibility
    {
        /// <summary>
        /// Normal visibility ('display: block')
        /// </summary>
        Visible,

        /// <summary>
        /// Hidden, but use space ('visibility:hidden', 'display' not modified)
        /// </summary>
        Invisible,

        /// <summary>
        /// Hidden ('display: none')
        /// </summary>
        Hidden
    }
}
