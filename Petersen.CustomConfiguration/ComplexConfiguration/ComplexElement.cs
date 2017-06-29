using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.ComplexConfiguration
{
    public class ComplexElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("attribute1", DefaultValue = "content_attr", IsKey = false, IsRequired = true)]
        //[RegexStringValidator(@"\w+:\/\/[\w.]+\S*")]                              // <<-- can apply validators
        public string Attribute1
        {
            get { return (string)base["attribute1"]; }
            set { base["attribute1"] = value; }
        }

        [ConfigurationProperty("attribute2", DefaultValue = "50", IsKey = false, IsRequired = true)]
        [IntegerValidator(MinValue = 0, MaxValue = 100, ExcludeRange = false)]      // <<-- can apply validators
        public int Attribute2
        {
            get { return (int)base["attribute2"]; }
            set { base["attribute2"] = value; }
        }
    }
}
