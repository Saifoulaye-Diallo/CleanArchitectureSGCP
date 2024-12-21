using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IConsultation : IAsyncRepository<Consultation>, IRepository<Consultation>
    {
        Task<Consultation> GetByIdWithPrescriptionsAsync(int id);

        Task<List<Consultation>> GetConsultationsByPatientIdAsync(int patientId);

        Task<Consultation> GetByIdAsync(int id);
    }
}
