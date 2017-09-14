using Horwath.BLL;
using Horwath.BLL.Contracts;
using Horwath.DAL;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.Common
{

    public class DependencyResolver
    {
        private Container _container;
        public Container Container { get
            {
                return _container;
            }
        }
        public DependencyResolver()
        {
            _container = new Container();
            _container.Register<IGreetingsRepository, GreetingsRepository>();
            _container.Register<IGreetingsLogicService, GreetingsLogicService>();
        }
        
    }
}
