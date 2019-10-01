using EisModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisDatabase
{
    public class EisDbContext : DbContext
    {
        public EisDbContext() : base("EisDbContext") { }

        public virtual DbSet<ChartOfAccounts> ChartOfAccounts{ get; set; }

        public virtual DbSet<DirectoryGM> DirectoryGMs { get; set; }

        public virtual DbSet<DirectoryGMProductSeries> DirectoryGMProductSeries { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<EmployeesPosition> EmployeesPositions { get; set; }

        public virtual DbSet<JournalEntries> JournalEntries { get; set; }

        public virtual DbSet<JournalOperations> JournalOperations { get; set; }

        public virtual DbSet<ProductSeries> ProductSeries { get; set; }

        public virtual DbSet<Provider> Providers { get; set; }

        public virtual DbSet<Subdivision> Subdivisions { get; set; }
    }
}
