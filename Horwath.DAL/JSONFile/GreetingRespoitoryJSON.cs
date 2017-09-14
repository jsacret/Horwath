using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Horwath.Entities;
using System.IO;

namespace Horwath.DAL.JSONFile
{
    public class GreetingRespoitoryJSON : IGreetingsRepository
    {
        public IEnumerable<Greeting> GetAllGreetings()
        {
            string greetingJson = null;
            try
            {

                greetingJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}bin/JSONDATA/greetings.json");
                
            }
            catch (IOException ioException)
            {
                //Exception logging code here NLog?

                //Exceptions will bubble up to front end so that it can be handled to end user.
                throw ioException;
            }

            return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Greeting>>(greetingJson);
        }

        public Greeting GetGreetingByLanguage(string language)
        {
            var greetings = GetAllGreetings();
            return greetings.Where(greeting => greeting.Language == language).FirstOrDefault();
        }
    }
}
