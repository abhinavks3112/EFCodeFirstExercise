using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstExercise
{
    public class CodeFirstDemoDbContext : DbContext
    {
        public CodeFirstDemoDbContext()
        {

        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
