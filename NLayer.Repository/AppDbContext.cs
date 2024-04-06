using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // tüm configuration sınıflarını bul ve uygula
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // best practice için burda olması uygun değil.
            modelBuilder.Entity<ProductFeature>().HasData(
                               new ProductFeature { Id = 1, Color = "Mavi", Height = 10, Width = 20, ProductId = 1 },
                                              new ProductFeature { Id = 2, Color = "Kırmızı", Height = 10, Width = 20, ProductId = 2 },
                                                             new ProductFeature { Id = 3, Color = "Siyah", Height = 10, Width = 20, ProductId = 3 }
                                                                            );

            base.OnModelCreating(modelBuilder);
        }
    }
    
}
