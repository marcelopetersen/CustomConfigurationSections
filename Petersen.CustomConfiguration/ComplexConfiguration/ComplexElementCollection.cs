using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.ComplexConfiguration
{
    public class ComplexElementCollection : ConfigurationElementCollection
    {
        public void Add(ComplexElement customElement)
        {
            BaseAdd(customElement);
        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            base.BaseAdd(element, false);
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ComplexElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            // Change this line to reflect property key name
            return ((ComplexElement)element).Name;
        }

        public ComplexElement this[int Index]
        {
            get
            {
                return (ComplexElement)BaseGet(Index);
            }
            set
            {
                if (BaseGet(Index) != null)
                {
                    BaseRemoveAt(Index);
                }
                BaseAdd(Index, value);
            }
        }

        new public ComplexElement this[string Name]
        {
            get
            {
                return (ComplexElement)BaseGet(Name);
            }
        }

        public int Indexof(ComplexElement element)
        {
            return BaseIndexOf(element);
        }

        public void Remove(ComplexElement element)
        {
            if (BaseIndexOf(element) >= 0)
                BaseRemove(element.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();
        }
    }
}