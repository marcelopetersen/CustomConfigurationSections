using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.NestedClassesConfiguration
{
    public class PaginationElement : ConfigurationElement
    {
        [ConfigurationProperty("itemsperpage", DefaultValue = "10", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 50, MinValue = 1)]
        public int Itemsperpage
        {
            get { return (int)this["itemsperpage"]; }
            set { this["itemsperpage"] = value; }
        }

        [ConfigurationProperty("visiblePages", DefaultValue = "10", IsRequired = true)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 50, MinValue = 1)]
        public int VisiblePages
        {
            get { return (int)this["visiblePages"]; }
            set { this["visiblePages"] = value; }
        }
    }
}
