using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Testing.Evolved.SpecFlow
{
    public class Context
    {
        public static T Get<T>()
        {
            return ScenarioContext.Current.Get<T>();
        }
         
        public static T Get<T>(string key)
        {
            return ScenarioContext.Current.Get<T>(key);
        }
    }
}
