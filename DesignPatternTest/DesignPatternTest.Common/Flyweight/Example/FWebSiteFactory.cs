using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class FWebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        public FWebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebsite(key));
            }
            return (FWebSite)flyweights[key];
        }

        public int GetWebsiteCount()
        {
            return this.flyweights.Count;
        }
    }
}
