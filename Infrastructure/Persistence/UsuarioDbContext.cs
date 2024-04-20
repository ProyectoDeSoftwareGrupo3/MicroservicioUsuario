using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class UsuarioDbContext:DbContext
    {
        public DbSet<Calificacion>Calificaciones { get; set; }
        public DbSet<Rol> Roles {  get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();
                entity.Property(u => u.Nombre).HasMaxLength(20).IsRequired();
                entity.Property(u => u.Apellido).HasMaxLength(20).IsRequired();
                entity.Property(u => u.DNI).HasMaxLength(8).IsRequired();
                entity.Property(u => u.Email).HasMaxLength(30).IsRequired();
                entity.Property(u =>u.Celular).HasMaxLength(10).IsRequired();
                entity.Property(u =>u.Direccion).HasMaxLength(50).IsRequired();

                entity.HasOne(u => u.Calificacion)
                .WithMany(u => u.Usuarios)
                .HasForeignKey(u => u.CalificacionId);

                entity.HasOne(u => u.Rol)
                .WithMany(u => u.Usuarios)
                .HasForeignKey(u => u.RolId);
            });
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("Rol");
                entity.HasKey(r => r.Id);
                entity.Property(r => r.Id).ValueGeneratedOnAdd();
                entity.Property(r => r.Descripcion).IsRequired();

                entity.HasMany(r => r.Usuarios)
                .WithOne(r => r.Rol);
            });
            modelBuilder.Entity<Calificacion>(entity =>
            {
                entity.ToTable("Calificacion");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id).ValueGeneratedOnAdd();
                entity.Property(c => c.Descripcion).IsRequired();

                entity.HasMany(c => c.Usuarios)
                .WithOne(c => c.Calificacion);   

            });
            modelBuilder.Entity<Calificacion>().HasData(
                new Calificacion
                {
                    Id= 1,
                    Descripcion="Muy Bueno"
                },
                new Calificacion
                {
                    Id = 2,
                    Descripcion = "Bueno"
                },
                new Calificacion
                {
                    Id = 3,
                    Descripcion = "Regular"
                },
                new Calificacion
                {
                    Id = 4,
                    Descripcion = "No Recomendado"
                }
                );

            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    Id = 1,
                    Descripcion = "Administrador"
                },
                new Rol
                {
                    Id = 2,
                    Descripcion = "Miembro"
                },
                new Rol
                {
                    Id = 3,
                    Descripcion = "Refugio"
                }
                );
        }
    }
}
