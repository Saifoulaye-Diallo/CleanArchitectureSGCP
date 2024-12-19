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

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
            return await _patientRepository.AddAsync(patient);
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
           return await _patientRepository.GetByIdAsync(id);
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
             await _patientRepository.UpdateAsync(patient);
        }

        public async Task<List<Patient>> GetPatientsByMedecinIdAsync(int medecinId)
        {
            return await _patientRepository.GetPatientsByMedecinIdAsync(medecinId);
        }

    }
}
