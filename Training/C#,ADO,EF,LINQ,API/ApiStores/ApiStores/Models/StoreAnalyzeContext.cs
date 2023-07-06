using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApiStores.Models;

public partial class StoreAnalyzeContext : DbContext
{
    public StoreAnalyzeContext()
    {
    }

    public StoreAnalyzeContext(DbContextOptions<StoreAnalyzeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerProd> CustomerProds { get; set; }

    public virtual DbSet<ProductDatum> ProductData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB85ED96475F");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<CustomerProd>(entity =>
        {
            entity.HasKey(e => e.ItemNo).HasName("PK__Customer__727D9FE4E69DF88C");

            entity.ToTable("CustomerProd");

            entity.Property(e => e.ItemNo).ValueGeneratedNever();
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .HasColumnName("product_id");
            entity.Property(e => e.ProductQuatity).HasColumnName("product_quatity");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerProds)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerP__custo__76969D2E");

            entity.HasOne(d => d.Product).WithMany(p => p.CustomerProds)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CustomerP__produ__778AC167");
        });

        modelBuilder.Entity<ProductDatum>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ProductD__47027DF5BFB245CF");

            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .HasColumnName("product_id");
            entity.Property(e => e.Cost)
                .HasColumnType("money")
                .HasColumnName("cost");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .HasColumnName("product_name");
            entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
