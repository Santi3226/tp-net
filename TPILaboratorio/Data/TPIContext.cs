using Microsoft.EntityFrameworkCore;
using Domain.Model;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class TPIContext : DbContext
    {
        public DbSet<Paciente> Pacientes{ get; set; }
        public DbSet<CentroAtencion> Centros { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<TipoAnalisis> TiposAnalisis { get; set; }
        public DbSet<PlantillaAnalisis> PlantillasAnalisis { get; set; }

        internal TPIContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
                // Restricción única para Email
                entity.HasIndex(e => e.Email)
                    .IsUnique();
                entity.Property(e => e.Dni)
                    .IsRequired();
                entity.Property(e => e.Telefono)
                    .IsRequired();
                entity.Property(e => e.Domicilio)
                    .IsRequired();
                entity.Property(e => e.Contraseña)
                    .IsRequired();
                entity.Property(e => e.FechaNacimiento)
                    .IsRequired();
                entity.Property(e => e.Tipo)
                    ;
            });
            modelBuilder.Entity<CentroAtencion>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.HasIndex(e => e.Nombre)
                    .IsUnique();
                entity.Property(e => e.Domicilio)
                    .IsRequired();
            });
            modelBuilder.Entity<Turno>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RecibeMail).IsRequired();
                entity.Property(e => e.Estado).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Receta).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Observaciones).HasMaxLength(255);
                entity.Property(e => e.FechaHoraReserva).IsRequired();
                entity.Property(e => e.FechaHoraExtraccion);
                entity.HasOne(t => t.Paciente)
                      .WithMany()
                      .HasForeignKey(t => t.PacienteId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(t => t.TipoAnalisis)
                      .WithMany()
                      .HasForeignKey(t => t.TipoAnalisisId)
                      .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(t => t.CentroAtencion)
                      .WithMany()
                      .HasForeignKey(t => t.CentroAtencionId)
                      .OnDelete(DeleteBehavior.Cascade);

            });
            modelBuilder.Entity<TipoAnalisis>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Importe).IsRequired();
                entity.HasOne(t => t.PlantillaAnalisis)
                      .WithMany()
                      .HasForeignKey(t => t.PlantillaAnalisisId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<PlantillaAnalisis>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.HsAyuno).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Preparacion).IsRequired().HasMaxLength(255);
                entity.Property(e => e.DiasPrevistos).IsRequired();
            });
        }
    }
}