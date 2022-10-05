using Microsoft.EntityFrameworkCore;
using MisApplication.Models;

namespace MisApplication.Context
{
    public class MVCContex : DbContext
    {
        public MVCContex(DbContextOptions options) : base(options)
        {

        }
        public DbSet<mis> mis { get; set; }
    }
}
