using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Services
{
    public class GestionDossierMedicalService : IGestionDossierMedicalService
    {
        public readonly IDossierMedical _dossierMedical;

        public GestionDossierMedicalService(IDossierMedical dossierMedical)
        {
            _dossierMedical = dossierMedical;
        }

        public async Task<DossierMedical> AddDossierMedicalAsync(DossierMedical dossierMedical)
        {
           return await _dossierMedical.AddAsync(dossierMedical);
        }

        public async Task<DossierMedical> GetDossierMedicalByIdAsync(int id)
        {
             return await _dossierMedical.GetByIdAsync(id);
        }

        public Task<DossierMedical> GetDossierMedicalByPatientIdAsync(int patientId)
        {
           return _dossierMedical.GetDossierMedicalByPatientIdAsync(patientId);
        }

        public async Task UpdateDossierMedicalAsync(DossierMedical dossierMedical)
        {
            await _dossierMedical.UpdateAsync(dossierMedical);
        }
    }
}
