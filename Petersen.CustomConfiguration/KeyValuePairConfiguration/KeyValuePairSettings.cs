using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Petersen.CustomConfiguration.KeyValuePairConfiguration
{
    public class KeyValuePairSettings
    {
        private const string SECTION_NAME = "keyValuePairCustomSection";

        private static bool? _property1;
        private static string _property2;
        private static NameValueCollection _settings = ConfigurationManager.GetSection(SECTION_NAME) as NameValueCollection;

        public static bool Property1
        {
            get
            {
                if (!_property1.HasValue)
                {
                    _property1 = GetProperty<bool>("property1");
                }

                return (bool)_property1;
            }
        }

        public static string Property2
        {
            get
            {
                if (string.IsNullOrEmpty(_property2))
                {
                    _property2 = GetProperty<string>("property2");
                }

                return _property2;
            }
        }

        /// <summary>
        /// Helper method to get value from collection
        /// </summary>
        private static T GetProperty<T>(string name)
        {
            return (T)Convert.ChangeType(_settings[name], typeof(T));
        }
    }
}
