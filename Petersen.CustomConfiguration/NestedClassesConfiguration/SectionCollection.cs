using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.NestedClassesConfiguration
{
    public class SectionCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new SectionElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SectionElement)element).Id;
        }

        protected override string ElementName
        {
            get
            {
                return "section";
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return !String.IsNullOrEmpty(elementName) && elementName == "section";
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        public SectionElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as SectionElement;
            }
        }

        public new SectionElement this[string key]
        {
            get
            {
                return base.BaseGet(key) as SectionElement;
            }
        }
    }
}