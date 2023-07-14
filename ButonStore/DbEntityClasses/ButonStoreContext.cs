using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ButonStore.SharedLibrary;

namespace ButonStore.DbEntityClasses;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql(AppSettingConstants.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserLoginDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserLoginDetails_pkey");

            entity.ToTable("UserLoginDetails", "StoreUsers");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
