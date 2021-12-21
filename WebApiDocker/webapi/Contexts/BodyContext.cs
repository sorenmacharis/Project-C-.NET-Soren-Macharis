using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Contexts
{
    public class BodyContext: DbContext
    {

        public BodyContext(DbContextOptions<BodyContext> opt): base(opt)
        {
            
        }
        public DbSet<Planet> Planets{get;set;}

        public DbSet<Moon> Moons{get;set;}
        public DbSet<Star> Stars{get;set;}
    }
}