﻿using CleanArchitectureSGCP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionPrescriptionService
    {
        Task AddPrescriptionAsync(Prescription prescription);

        Task UpdatePrescriptionAsync(Prescription prescription);

        Task<Prescription> GetPrescriptionByIdAsync(int id);

        Task<List<Prescription>> GetPrescriptionsByConsultationIdAsync(int consultationId);

        Task<List<Prescription>> GetPrescriptionsPasseesByPatientIdAsync(int patientId);
    }
}
