using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Infrastructure
{
    public class SGCPContextFactory : IDesignTimeDbContextFactory<SGCPContext>
    {
        public SGCPContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new
            DbContextOptionsBuilder<SGCPContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CleanArchitectureSGCPDB;Trusted_Connection=True;");
            return new SGCPContext(optionsBuilder.Options);
        }

    }
}
