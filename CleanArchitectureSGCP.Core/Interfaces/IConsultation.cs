﻿using CleanArchitectureSGCP.Core.Entities;
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

        Task AddAsync(Consultation consultation);
        Task<List<Consultation>> GetConsultationsByPatientIdAsync(int patientId);
    }
}
