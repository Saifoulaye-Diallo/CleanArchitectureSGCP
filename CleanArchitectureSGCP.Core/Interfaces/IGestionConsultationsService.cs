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
        Task AddConsultation(Consultation consultation);
        Task GetPatientConsultationHistory(int id);
    }
}
