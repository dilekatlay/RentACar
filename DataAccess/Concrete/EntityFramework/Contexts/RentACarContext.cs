using Core.Entities;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class RentACarContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<IndividualCustomer> IndividualCustomers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<OperationClaim>   OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        public RentACarContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions) { }

        public RentACarContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Brand>().HasKey(i=> i.Id); // EF Core Naming Convention BrandId
            modelBuilder.Entity<Brand>(e =>
            {
                e.HasKey(i => i.Id);
                e.Property(i => i.Premium).HasDefaultValue(true);
            });
            base.OnModelCreating(modelBuilder); // Normalde yaptığı işlemleri sürdürür.
        }

    }



    // Database güncellemek için add-migration sonra update migration
    // Son değişikliği geri almak için update-database migration adı sonra remove migration
    // Update-Database migrationIsmi
    // Remove-Migration
}

