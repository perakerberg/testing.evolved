using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Testing.Evolved.SpecFlow
{
    public static class ObjectExtensions
    {
        public static T SetInContext<T>(this T instance)
        {
            ScenarioContext.Current.Set(instance);
            return instance;
        }

        public static T SetInContext<T>(this T instance, string key)
        {
            ScenarioContext.Current.Set(instance, key);
            return instance;
        }
    }
}
