using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<DossierMedical> GetDossierMedicalByPatientIdAsync(int patientId)
        {
            var dossierMedical = await _Sgcpcontext.DossiersMedicals
                .FirstOrDefaultAsync(dm => dm.PatientId == patientId);

            return dossierMedical; 
        }

    }
}
