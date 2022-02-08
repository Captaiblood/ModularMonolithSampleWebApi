using Microsoft.EntityFrameworkCore;
using Module.Company.Core.Abstractions;
using Module.Company.Core.Entities;
using Shared.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Company.Infrastructure.Persistence
{
    public class CompanyDbContext : ModuleDbContext, ICompanyDbContext
    {
        protected override string Schema => "Company";
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }
        
        public DbSet<CompanyDetail> CompanyDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}
