using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.DAL
{
    public interface IGreetingsRepository
    {
        IEnumerable<Greeting> GetAllGreetings();
        Greeting GetGreetingByLanguage(string language);
    }
}
