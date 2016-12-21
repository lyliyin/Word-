using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleDemo.DataAccess
{
    public class IoCInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<castledemoContext>().LifeStyle.PerWebRequest);
            container.Register(Classes.FromThisAssembly()
             .InNamespace("CastleDemo.DataAccess.RepositoryImpl", true)
             .LifestylePerWebRequest()
             .WithService.AllInterfaces());
        }
    }
}
