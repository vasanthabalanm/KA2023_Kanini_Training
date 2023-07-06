using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebEf.Services
{
    public class StudentDbcontxt : DbContext
    {
        public DbSet<Studentsas> Students { get; set; }

        public StudentDbcontxt(DbContextOptions<StudentDbcontxt> options) : base(options)
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
