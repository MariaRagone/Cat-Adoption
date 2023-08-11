using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cat_Adoption.Models;

public partial class AdoptionDbContext : DbContext
{
    public AdoptionDbContext()
    {
    }

    public AdoptionDbContext(DbContextOptions<AdoptionDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cat> Cats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //WINDOWS
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=AdoptionDB; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");
        //MAC


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cats__3213E83F4EAA740E");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AgeCategory).HasMaxLength(255);
            entity.Property(e => e.Breed).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.Img).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
