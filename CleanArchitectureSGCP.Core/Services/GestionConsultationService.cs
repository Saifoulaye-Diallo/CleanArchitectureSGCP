using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Services
{
    public class GestionConsultationService : IGestionConsultationsService
    {
        private readonly IConsultation _consultationRepository;

        public GestionConsultationService(IConsultation consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }
        
        public Task AddConsultationAsync(Consultation consultation)
        {
            return _consultationRepository.AddAsync(consultation);
        }

        //A Definir
        public async Task GetPatientConsultationHistory(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetPatientConsultationHistoryAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
