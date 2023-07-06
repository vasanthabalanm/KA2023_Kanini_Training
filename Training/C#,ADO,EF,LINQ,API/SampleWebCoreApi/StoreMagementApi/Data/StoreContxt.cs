using Microsoft.EntityFrameworkCore;

namespace StoreMagementApi.Data
{
    public class StoreContxt : DbContext
    {
        public DbSet<StoreManagement> storeManagements { get; set; }
        public StoreContxt(DbContextOptions<StoreContxt> options) : base(options) 
        { 
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; database=Store; integrated security=SSPI;TrustServerCertificate=True");
        }
    }
}
