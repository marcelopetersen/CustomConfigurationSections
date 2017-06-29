using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.NestedClassesConfiguration
{
    public class SectionElement : ConfigurationElement
    {
        [ConfigurationProperty("id", IsKey = true, IsRequired = true)]
        public string Id
        {
            get { return (string)this["id"]; }
        }

        [ConfigurationProperty("pagination")]
        public PaginationElement Pagination
        {
            get
            {
                return (PaginationElement)this["pagination"];
            }
            set
            { this["pagination"] = value; }
        }
    }
}