using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.DAL
{
    public class HorwarthDataInitializer : DropCreateDatabaseAlways<HorwathDBContext>
    {
        protected override void Seed(HorwathDBContext context)
        {
            IList<Greeting> greetings = new List<Greeting>();
            greetings.Add(new Greeting() { GreetingText = "Hello", Language = "English" });
            greetings.Add(new Greeting() { GreetingText = "Hola", Language = "Spanish" });
            greetings.Add(new Greeting() { GreetingText = "Kedụ", Language = "Igbo" });
            greetings.Add(new Greeting() { GreetingText = "Hallo", Language = "German" });
            greetings.Add(new Greeting() { GreetingText = "Allô", Language = "French" });
            foreach (var greeting in greetings)
            {
                context.Greetings.Add(greeting);
            }

            base.Seed(context);
        }
    }
}
