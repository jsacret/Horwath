using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.DAL
{
    public class GreetingsRepository : IGreetingsRepository
    {
        public IEnumerable<Greeting> GetAllGreetings()
        {
            try
            {
                using (var db = new HorwathDBContext())
                {
                    return db.Greetings.ToList();
                }
            } //Used generic exception to catch all
            catch (Exception ex)
            {
                //log exception here using something like NLog, depending on the system 
                // I would also create triggers that emailed certain people to respond.

                //if cannot handle here we will rethrow so that at least the end user gets knowledge
                throw ex;
            }

        }

        public Greeting GetGreetingByLanguage(string language)
        {
            try
            {
                using (var db = new HorwathDBContext())
                {
                    //assumes the user cannot select the wrong language, could be better.
                    Greeting resultGreeting = db.Greetings.Where(greeting => greeting.Language == language).FirstOrDefault();
                    return resultGreeting;
                }
            }             //Used generic exception to catch all
            catch(Exception ex)
            {
                //log exception here using something like NLog, depending on the system 
                // I would also create triggers that emailed certain people to respond.

                //if cannot handle here we will rethrow so that at least the end user gets knowledge
                throw ex;
            }
}
    }
}
