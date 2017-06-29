using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.ComplexConfiguration
{
    public class ComplexSection : ConfigurationSection
    {
        private const string ROOT_ELEMENT_NAME = "customElements";

        [ConfigurationProperty(ROOT_ELEMENT_NAME, IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ComplexElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
        public ComplexElementCollection Instances
        {
            get
            {
                return (ComplexElementCollection)base[ROOT_ELEMENT_NAME];
            }
        }
    }
}
