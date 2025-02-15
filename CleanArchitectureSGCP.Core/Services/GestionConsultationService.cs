﻿using CleanArchitectureSGCP.Core.Entities;
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

        public async Task<Consultation> GetByIdAsync(int id)
        {
           return await _consultationRepository.GetByIdAsync(id);
        }

        public async Task<List<Consultation>> GetConsultationsByPatientIdAsync(int patientId)
        {
           return await _consultationRepository.GetConsultationsByPatientIdAsync(patientId);
        }

        public async Task UpdateConsultationAsync(Consultation consultation)
        {
            await _consultationRepository.UpdateAsync(consultation);
        }
    }
}
