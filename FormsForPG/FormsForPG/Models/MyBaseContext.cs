using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FormsForPG.Models;

public partial class MyBaseContext : DbContext
{
    public MyBaseContext()
    {
    }

    public MyBaseContext(DbContextOptions<MyBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=1;Persist Security Info=True;Database=myBase");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.IdCust).HasName("pk_cust");

            entity.ToTable("customers");

            entity.Property(e => e.IdCust).HasColumnName("id_cust");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasPrecision(10)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.IdOrder).HasName("pk_orders");

            entity.ToTable("orders");

            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.Amount)
                .HasPrecision(13, 2)
                .HasColumnName("amount");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.DateOrder).HasColumnName("date_order");
            entity.Property(e => e.IdCust).HasColumnName("id_cust");
            entity.Property(e => e.IdProd).HasColumnName("id_prod");

            entity.HasOne(d => d.IdCustNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdCust)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ord_cust");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdProd)
                .HasConstraintName("fk_ord_prod");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("products_pkey");

            entity.ToTable("products");

            entity.Property(e => e.IdProd).HasColumnName("id_prod");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.EdIzm)
                .HasMaxLength(5)
                .HasDefaultValueSql("'sht'::character varying")
                .HasColumnName("ed_izm");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasPrecision(13, 2)
                .HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
