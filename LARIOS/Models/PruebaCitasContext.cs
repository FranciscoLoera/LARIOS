using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LARIOS.Models;

public partial class PruebaCitasContext : DbContext
{
    public PruebaCitasContext()
    {
    }

    public PruebaCitasContext(DbContextOptions<PruebaCitasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Doctore> Doctores { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Tratamiento> Tratamientos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=FANCISCOLOERA\\LOERA; Database=PruebaCitas; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cita>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("citas");

            entity.Property(e => e.Doctor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doctor");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hora");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Paciente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paciente");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tratamiento");
        });

        modelBuilder.Entity<Doctore>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("doctores");

            entity.Property(e => e.Doctor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("doctor");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pacientes");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Tratamiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tratamientos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tratamientos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tratamientos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
