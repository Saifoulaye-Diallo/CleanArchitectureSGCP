using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Infrastructure.Repositories
{
    public class DossierMedicalRepository : EfRepository<DossierMedical>, IDossierMedical
    {
        public DossierMedicalRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }
    }
}
