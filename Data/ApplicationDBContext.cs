using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions) : base(dbContextOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product { Id = 1, Name = "Test1", Description = "Description1", Link = " Link1" },
                 new Product { Id = 2, Name = "Test2", Description = "Description2", Link = " Link2" },
                 new Product { Id = 3, Name = "Test3", Description = "Description3", Link = " Link3" },
                 new Product { Id = 4, Name = "Test4", Description = "Description4", Link = " Link4" },
                 new Product { Id = 5, Name = "Test5", Description = "Description5", Link = " Link5" }
                );
        }
    }
}
