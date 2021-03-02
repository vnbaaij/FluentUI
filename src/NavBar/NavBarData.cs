using System.Collections.Generic;

namespace FluentUI.Internal
{
    public class NavBarData
    {
        public System.Collections.Generic.List<INavBarItem> PrimaryItems { get; set; }
        public System.Collections.Generic.List<INavBarItem> OverflowItems { get; set; }
        public System.Collections.Generic.List<INavBarItem> FarItems { get; set; }
        public int MinimumOverflowItems { get; set; }
        public string CacheKey { get; set; }

    }
}
