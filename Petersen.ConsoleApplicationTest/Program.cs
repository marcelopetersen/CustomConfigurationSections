using System;
using System.Configuration;
using Petersen.CustomConfiguration.ComplexConfiguration;
using Petersen.CustomConfiguration.KeyValuePairConfiguration;
using Petersen.CustomConfiguration.NestedClassesConfiguration;

namespace Petersen.ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////
            // Testing key/value pair custom configuration
            Console.WriteLine("======================================================");
            Console.WriteLine("Custom key/value pair configuration");
            Console.WriteLine("======================================================");
            Console.WriteLine("Property1: {0}", KeyValuePairSettings.Property1);
            Console.WriteLine("Property2: {0}", KeyValuePairSettings.Property2);
            Console.WriteLine("======================================================");
            Console.ReadLine();


            //////////////////////////////////////////////////////////////////////////
            // Testing complex custom configuration
            Console.WriteLine("======================================================");
            Console.WriteLine("Complex custom configuration");
            Console.WriteLine("======================================================");

            ComplexSection config = (ComplexSection)ConfigurationManager.GetSection("complexCustomSection");

            foreach (ComplexElement item in config.Instances)
            {
                Console.WriteLine("Property1: {0}", item.Name);
                Console.WriteLine("Attribute1: {0}", item.Attribute1);
                Console.WriteLine("Attribute2: {0}", item.Attribute2);
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("======================================================");
            Console.ReadLine();


            //////////////////////////////////////////////////////////////////////////
            // Testing nested class custom configuration
            Console.WriteLine("======================================================");
            Console.WriteLine("Nested class custom configuration");
            Console.WriteLine("======================================================");

            PlannerSection config2 = (PlannerSection)ConfigurationManager.GetSection("plannerSection");

            foreach (SectionElement section in config2.Sections)
            {
                Console.WriteLine("Id: {0}", section.Id);
                Console.WriteLine("Itemsperpage: {0}", section.Pagination.Itemsperpage);
                Console.WriteLine("VisiblePages: {0}", section.Pagination.VisiblePages);
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine("======================================================");

            
            //////////////////////////////////////////////////////////////////////////
            // Wait
            Console.ReadKey();
        }
    }
}
