using DataModels.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLibrary
{
    public class SampleDatabaseContext : DbContext
    {
        public DbSet<MltpUser> MltpUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.; database=MLTP; trusted_connection=true;");
            }
        }
    }
}