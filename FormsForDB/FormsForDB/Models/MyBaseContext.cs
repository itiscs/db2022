using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FormsForDB.Models;

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
        => optionsBuilder.UseSqlServer(Properties.Settings.Default.myBaseConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Cyrillic_General_CS_AI");

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_cust");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_order");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("AD_Orders");
                    tb.HasTrigger("AI_Orders");
                    tb.HasTrigger("AU_Orders");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdCust).HasColumnName("id_cust");
            entity.Property(e => e.IdProd).HasColumnName("id_prod");
            entity.Property(e => e.Orderdate)
                .HasColumnType("date")
                .HasColumnName("orderdate");

            entity.HasOne(d => d.IdCustNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdCust)
                .HasConstraintName("fk_ord_cust");

            entity.HasOne(d => d.IdProdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.IdProd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ord_prod");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Products");

            entity.ToTable(tb => tb.HasTrigger("ID_Products"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.EdIzm)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('шт')")
                .HasColumnName("ed_izm");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
