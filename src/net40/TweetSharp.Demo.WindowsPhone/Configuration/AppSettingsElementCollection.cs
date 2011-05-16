using Microsoft.Practices.Mobile.Configuration;

namespace TweetSharp.Demo.WindowsPhone.Configuration
{
    public class AppSettingsElementCollection : ConfigurationElementCollection  
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new AppSettingElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            var e = (AppSettingElement)element;

            return e.Key;
        }

        public new AppSettingElement this[string name]
        {
            get
            {
                return (AppSettingElement)BaseGet(name);
            }
        }
    }
}
