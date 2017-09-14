using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.BLL.Contracts
{
    public interface IGreetingsLogicService
    {
        Greeting GetGreeting(string language);

        IEnumerable<Greeting> GetGreetings();
        IEnumerable<Greeting> GetGreetingsJSONExample();
    }
}
