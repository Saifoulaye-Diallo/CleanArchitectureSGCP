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

        public async Task AddDossierMedical(DossierMedical dossierMedical)
        {
           await _dossierMedical.AddAsync(dossierMedical);
        }

        public async Task GetDossierMedicalById(int id)
        {
            await _dossierMedical.GetByIdAsync(id);
        }

        public async Task UpdateDossierMedical(DossierMedical dossierMedical)
        {
            await _dossierMedical.UpdateAsync(dossierMedical);
        }
    }
}
