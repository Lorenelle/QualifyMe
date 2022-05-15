using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualifyMe.DomainModels
{
    public class QualifyMeDatabaseDbContext
    {
        public DbSet<StudentUser> StudentUsers { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}
