using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class EisDbContext : DbContext
    {
        public EisDbContext() : base("EisDbContext") { }

        public DbSet<ChartOfAccounts> ChartOfAccounts{ get; set; }

        public DbSet<DirectoryGM> DirectoryGMs { get; set; }

        public DbSet<DirectoryGMProductSeries> DirectoryGMProductSeries { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeesPosition> EmployeesPositions { get; set; }

        public DbSet<JournalEntries> JournalEntries { get; set; }

        public DbSet<JournalOperations> JournalOperations { get; set; }

        public DbSet<ProductSeries> ProductSeries { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<Subdivision> Subdivisions { get; set; }
    }
}
