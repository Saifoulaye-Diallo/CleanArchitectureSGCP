using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Services
{
    public class GestionPatientService : IGestionPatientService
    {
        public readonly IPatient _patientRepository;

        public GestionPatientService(IPatient patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task AddPatient(Patient patient)
        {
            await _patientRepository.AddAsync(patient);
        }

        public async Task GetPatientById(int id)
        {
           await _patientRepository.GetByIdAsync(id);
        }

        public async Task UpdatePatient(Patient patient)
        {
            await _patientRepository.UpdateAsync(patient);
        }
    }
}
