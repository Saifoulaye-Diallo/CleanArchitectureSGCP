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
    public class PatientRepository : EfRepository<Patient>, IPatient
    {
        public PatientRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }

        public async Task<List<Patient>> GetPatientsByMedecinIdAsync(int medecinId)
        {
           return await _Sgcpcontext.Medecins
              .Where(m => m.Id == medecinId) // Filtrer par ID du médecin
              .SelectMany(m => m.Patients)  // Sélectionner tous les patients associés
              .ToListAsync();
        }
    }
}
