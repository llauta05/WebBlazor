using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InputOutputs { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-LNDRHCP;Database=InventaryDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "COM", CategoryName = "Comida" },
                new CategoryEntity { CategoryId = "SSS", CategoryName = "Otros" },
                new CategoryEntity { CategoryId = "BBB", CategoryName = "Basura" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAddress = "Una calle 334"
                },
                new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Merlo",
                    WarehouseAddress = "Una calle 334"
                }, new WarehouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Moron",
                    WarehouseAddress = "Una calle 334"
                }
                );

        }
    }
}
