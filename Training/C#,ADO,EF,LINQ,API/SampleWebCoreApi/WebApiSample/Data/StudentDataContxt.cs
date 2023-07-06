using Microsoft.EntityFrameworkCore;

namespace WebApiSample.Data
{
    public class StudentDataContxt : DbContext
    {
        public DbSet<Student> Students { get; set; }
        
        public StudentDataContxt(DbContextOptions<StudentDataContxt> options) : base(options) 
        { 

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // connect via appsetting.json via connstr
            //optionsBuilder.UseSqlServer("");
        }

    }
}
