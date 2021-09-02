using CRSSEntities;
using Microsoft.EntityFrameworkCore;

namespace CRSSDataAccess
{
    public class CRSSContext : DbContext
    {
        private readonly string ConnString;
        public DbSet<Location> Locations { get; set; }

        public DbSet<User> Users { get; set; }


        public CRSSContext(DbContextOptions<CRSSContext> options)
            : base(options)
        {}

        public CRSSContext(string connString)
        {
            ConnString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            if (!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(ConnString);
            }
        }
    }
}
