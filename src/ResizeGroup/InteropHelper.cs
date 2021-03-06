﻿using Microsoft.JSInterop;
using System;

namespace FluentUI.Internal
{
    public class InteropHelper
    {
        private readonly Action<bool> _resizeHappenedTrigger;

        public InteropHelper(Action<bool> resizeHappenedTrigger)
        {
            _resizeHappenedTrigger = resizeHappenedTrigger;
        }

        [JSInvokable]
        public void ResizeHappenedAsync()
        {
            _resizeHappenedTrigger(true);
        }

    }
}
