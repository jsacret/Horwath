using Horwath.BLL;
using Horwath.BLL.Contracts;
using Horwath.Common;
using Horwath.Entities;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorwathGreetings
{
    class Program
    {
        static DependencyResolver _resolver;
        static Program()
        {
            _resolver = new DependencyResolver();
        }
        static void Main(string[] args)
        {
            IGreetingsLogicService _greetingsLogicService = _resolver.Container.GetInstance<IGreetingsLogicService>();

            Greeting greeting = _greetingsLogicService.GetGreeting("English");

            Console.WriteLine(greeting.GreetingText);
        }
    }
}
