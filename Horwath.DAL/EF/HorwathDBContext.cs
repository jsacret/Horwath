using Horwath.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horwath.DAL
{
    public class HorwathDBContext : DbContext
    {
        public HorwathDBContext() : base("HorwathDB")
        {
            Database.SetInitializer(new HorwarthDataInitializer());
        }

        public DbSet<Greeting> Greetings{ get; set; }
    }
}
