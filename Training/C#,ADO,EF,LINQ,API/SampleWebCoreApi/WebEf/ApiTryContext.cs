using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebEf;

public partial class ApiTryContext : DbContext
{
    public ApiTryContext()
    {
    }

    public ApiTryContext(DbContextOptions<ApiTryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS; Initial catalog=ApiTry; integrated security=SSPI; TrustServerCertificate= True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StuId);

            entity.Property(e => e.StuId)
                .ValueGeneratedNever()
                .HasColumnName("StuID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
