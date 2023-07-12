using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Emit;
using Models;
namespace Appointment_management.Data
{
    public class Appointmentdatacontext : DbContext
    {
        public Appointmentdatacontext(DbContextOptions<Appointmentdatacontext> options) : base(options) { }

        public DbSet<AdminDoctor_Model> Admins { get; set; }
        public DbSet<Appoinment_model> Doctors { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}