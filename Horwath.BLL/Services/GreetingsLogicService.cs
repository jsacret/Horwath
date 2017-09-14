using Horwath.BLL.Contracts;
using Horwath.DAL;
using Horwath.DAL.JSONFile;
using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.BLL
{
    public class GreetingsLogicService : IGreetingsLogicService
    {
        private IGreetingsRepository _greetingsRepository;
        public GreetingsLogicService(IGreetingsRepository greetingsRepository)
        {
            _greetingsRepository = greetingsRepository;
        }

        public Greeting GetGreeting(string language)
        {
            //Additional Logic?
            var greeting = _greetingsRepository.GetGreetingByLanguage(language);
            greeting.GreetingText += " World!";
            return greeting;
        }

        public IEnumerable<Greeting> GetGreetings()
        {
            return _greetingsRepository.GetAllGreetings();
        }

        public IEnumerable<Greeting> GetGreetingsJSONExample()
        {
            //skipping injection for speed
            var gjson = new GreetingRespoitoryJSON();
            return gjson.GetAllGreetings();
        }
    }
}
