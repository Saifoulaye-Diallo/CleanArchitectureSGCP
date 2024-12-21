using CleanArchitectureSGCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionConsultationsService
    {
        Task AddConsultationAsync(Consultation consultation);
        Task<List<Consultation>> GetConsultationsByPatientIdAsync(int patientId);

        Task UpdateConsultationAsync(Consultation consultation);
        Task<Consultation> GetByIdAsync(int id);
    }
}
