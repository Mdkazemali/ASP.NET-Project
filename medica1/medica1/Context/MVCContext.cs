using medica1.Models;
using Microsoft.EntityFrameworkCore;

namespace medica1.Context
{
    public class MVCContext:DbContext

    {
        public MVCContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Combination> combinations { get; set; }
        public DbSet<Generic_Name> Generic_Names { get; set; }
        public DbSet<Medicine_Name> Medicine_Names { get; set; }
        public DbSet<Medicine_Type> Medicine_Types { get; set; }

        internal void SaveChanges(Generic_Name generic_Name)
        {
            throw new NotImplementedException();
        }
    }
}
