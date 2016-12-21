using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleDemo.Domain
{
    public class Factories
    {
        public static T Repository<T>() where T : class
        {
            return IoCContainer.Instance.Resolve<T>();
        }
    }
}
