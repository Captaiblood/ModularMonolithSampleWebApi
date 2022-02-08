using Microsoft.EntityFrameworkCore;
using Module.Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module.Company.Core.Abstractions
{
    public interface ICompanyDbContext
    {
        public DbSet<CompanyDetail>  CompanyDetails { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }

}
