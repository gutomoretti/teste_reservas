using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estapar.Reservas.Models
{
    public class AppReservasDbContext : DbContext
    {
        public AppReservasDbContext(DbContextOptions<AppReservasDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Reserva>().HasKey(b => b.Id);
            builder.Entity<Marca>().HasKey(b => b.Id);
            builder.Entity<Modelo>().HasKey(b => b.Id);
            builder.Entity<Usuario>().HasKey(b => b.Id);
            builder.Entity<Veiculo>().HasKey(b => b.Id);
            base.OnModelCreating(builder);
        }
    }
}
