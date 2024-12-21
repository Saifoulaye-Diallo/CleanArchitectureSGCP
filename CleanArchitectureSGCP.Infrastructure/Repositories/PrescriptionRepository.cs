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
    public class PrescriptionRepository : EfRepository<Prescription>, IPrescription
    {
        public PrescriptionRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }

        public async Task<List<Prescription>> GetPrescriptionsByConsultationIdAsync(int consultationId)
        {
            var consultation = await _Sgcpcontext.Consultations
                .Include(c => c.Prescriptions) // Inclure les prescriptions associées
                .FirstOrDefaultAsync(c => c.Id == consultationId);

            // Si la consultation est trouvée, retourner les prescriptions associées
            return consultation?.Prescriptions ?? new List<Prescription>();
        }

    }
}
