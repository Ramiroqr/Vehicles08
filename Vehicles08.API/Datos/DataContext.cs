using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles08.API.Datos.Entities;

namespace Vehicles08.API.Datos
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<DocumentType>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<Procedure>()
                .HasIndex(x => x.Description).IsUnique();

            modelBuilder.Entity<VehicleType>()
                .HasIndex(x => x.Description).IsUnique();
        }
    }
}
