﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NewDataTO.Model;

public partial class OtherOtherDatabaseContext : DbContext
{
    public OtherOtherDatabaseContext()
    {
    }

    public OtherOtherDatabaseContext(DbContextOptions<OtherOtherDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ScoreDataModel> ScoreDataModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost; Database=OtherOtherDatabase; Username=postgres; Password=0406");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ScoreDataModel>(entity =>
        {
            entity.HasKey(e => e.SBD);

            entity.ToTable("ScoreDataModel");

            entity.Property(e => e.SBD).HasColumnName("SBD");
            entity.Property(e => e.GDCD).HasColumnName("GDCD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
