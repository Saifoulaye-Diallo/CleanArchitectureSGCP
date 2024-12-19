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
        Task GetPatientConsultationHistoryAsync(int id);
    }
}
