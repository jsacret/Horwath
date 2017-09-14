using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.Entities
{
    public class Greeting
    {
        [Key]
        public int GreetingsId { get; set; }
        public string Language { get; set; }
        public string GreetingText { get; set; }
    }
}
