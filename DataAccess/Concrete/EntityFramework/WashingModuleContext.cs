using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class WashingModuleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI;Database=WashingModule;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Defect> Defects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Fabric> Fabrics { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<OrderProcess> OrderProcesses { get; set; }
        public DbSet<Pant> Pants { get; set; }
        public DbSet<WashingType> WashingTypes { get; set; }


        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
