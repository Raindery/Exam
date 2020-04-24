using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exam_Mezh.Entities
{
    class FlatsContext : DbContext
    {
        public FlatsContext() : base("FlatsDb")
        {
            
        }

        public DbSet<Type> Types { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
