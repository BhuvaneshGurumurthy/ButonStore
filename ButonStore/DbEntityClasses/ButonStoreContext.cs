using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ButonStore.Models;

public partial class ButonStoreContext : DbContext
{
    public ButonStoreContext()
    {
    }

    public ButonStoreContext(DbContextOptions<ButonStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserLoginDetail> UserLoginDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ButonStoreContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserLoginDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("UserLoginDetails_pkey");
            entity.ToTable("UserLoginDetails", "StoreUsers");
            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
