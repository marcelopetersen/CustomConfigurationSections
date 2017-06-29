using System;
using System.Configuration;

namespace Petersen.CustomConfiguration.NestedClassesConfiguration
{
    public class PlannerSection : ConfigurationSection
    {
        /*///////////////////////////////////////////////////////////////////
            // With no root elements, set ROOT_ELEMENT_NAME="sections"
            <plannerSection>
                <sections>
                    <section id="teams">
                        <pagination itemsperpage="10" visiblePages="15" />
                    </section>
                </sections>
            <plannerSection>

            // With no root element, set ROOT_ELEMENT_NAME=""
            <plannerSection>
                <section id="teams">
                    <pagination itemsperpage="10" visiblePages="15" />
                </section>
            <plannerSection>
        ///////////////////////////////////////////////////////////////////*/
        private const string ROOT_ELEMENT_NAME = "sections";

        [ConfigurationProperty(ROOT_ELEMENT_NAME, IsDefaultCollection = true, IsKey = false, IsRequired = true)]
        public SectionCollection Sections
        {
            get
            {
                return base[ROOT_ELEMENT_NAME] as SectionCollection;
            }

            set
            {
                base[ROOT_ELEMENT_NAME] = value;
            }
        }
    }
}
