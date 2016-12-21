using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleDemo.Domain
{
    internal class IoCContainer
    {
        private static readonly object syncRoot = new object();

        private IoCContainer() { }

        private static IWindsorContainer _Instance;

        public static IWindsorContainer Instance
        {
            get
            {
                lock (syncRoot)
                {
                    if (_Instance == null)
                    {
                        var configdata = Configuration.FromAppConfig();
                        _Instance = new WindsorContainer().Install(configdata);
                    }
                    return _Instance;
                }
            }
        }
    }
}
