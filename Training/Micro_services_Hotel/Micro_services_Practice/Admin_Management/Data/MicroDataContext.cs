using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;

namespace Admin_Management.Data
{
    public class MicroDataContext : DbContext
    {
        public MicroDataContext(DbContextOptions<MicroDataContext> options) : base(options) { }

        public DbSet<AdminDoctor_Model> Admins { get; set; }
        public DbSet<Appoinment_model> Doctors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}