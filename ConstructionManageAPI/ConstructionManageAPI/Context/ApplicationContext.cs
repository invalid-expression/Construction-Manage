using ConstructionManageAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConstructionManageAPI.Context
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<Observation> Observations { get; set; }
        public DbSet<ConstructionRecord> ConstructionRecords { get; set; }
        public DbSet<Property> Properties { get; set; }
    }
}
