using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Services
{
    public class GestionPrescriptionService : IGestionPrescriptionService
    {
        public readonly IPrescription _prescriptionRepository;

        public GestionPrescriptionService(IPrescription prescriptionRepository)
        {
            _prescriptionRepository = prescriptionRepository;
        }

        public Task AddPrescriptionAsync(Prescription prescription)
        {
             return _prescriptionRepository.AddAsync(prescription);
        }

        public async Task<Prescription> GetPrescriptionByIdAsync(int id)
        {
             return await _prescriptionRepository.GetByIdAsync(id);
        }

        public Task<List<Prescription>> GetPrescriptionsByConsultationIdAsync(int consultationId)
        {
            return _prescriptionRepository.GetPrescriptionsByConsultationIdAsync(consultationId);
        }

        public async Task UpdatePrescriptionAsync(Prescription prescription)
        {
           await _prescriptionRepository.UpdateAsync(prescription);
        }
    }
}
