using System;
using System.Collections.Generic;
using System.Text;

namespace FluentUI.Extensions
{
    public static class DecimalExtension
    {
        public static string ToCssValue(this decimal value)
        {
            return value.ToString().Replace(',', '.');
        }
    }
}
