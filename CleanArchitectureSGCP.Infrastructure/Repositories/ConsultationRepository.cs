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
    public class ConsultationRepository : EfRepository<Consultation>, IConsultation
    {

        public ConsultationRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }

        public Task AddAsync(Consultation consultation)
        {
            throw new NotImplementedException();
        }

        public Consultation GetByIdWithPrescriptions(int id)
        {
            return _Sgcpcontext.Consultations.Include(t => t.Prescriptions).FirstOrDefault(t => t.Id == id);

        }

        public Task<Consultation> GetByIdWithPrescriptionsAsync(int id)
        {
           return _Sgcpcontext.Consultations.Include(t => t.Prescriptions).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<Consultation>> GetConsultationsByPatientIdAsync(int patientId)
        {
            var dossierMedical = await _Sgcpcontext.DossiersMedicals
                .Include(dm => dm.Consultations) // Inclure les consultations
                .FirstOrDefaultAsync(dm => dm.PatientId == patientId);

            return dossierMedical?.Consultations.ToList() ?? new List<Consultation>();
        }

    }
}
