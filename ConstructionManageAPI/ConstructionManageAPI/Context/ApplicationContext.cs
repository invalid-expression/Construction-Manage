using ConstructionManageAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ConstructionManageAPI.Context
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {}

        public DbSet<ObservationEntity> ObservationEntity { get; set; }
        public DbSet<DatasEntity> DatasEntity { get; set; }
        public DbSet<PropertyEntity> PropertiesEntity { get; set; }
    }
}
