using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MVC_1_.Models;

public partial class DbProyectoContext : DbContext
{
    public DbProyectoContext()
    {
    }

    public DbProyectoContext(DbContextOptions<DbProyectoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=GCNB-470\\LAUTAROSERVER;+" +
            "Initial Catalog=db_proyecto;+" +
            "Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__645723A622BF75E6");

            entity.ToTable("usuario");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
