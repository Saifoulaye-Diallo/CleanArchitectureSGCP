﻿using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IPrescription : IAsyncRepository<Prescription>, IRepository<Prescription>
    {
        Task<List<Prescription>> GetPrescriptionsByConsultationIdAsync(int consultationId);
        Task<List<Prescription>> GetPrescriptionsPasseesByPatientIdAsync(int patientId);
    }
}
