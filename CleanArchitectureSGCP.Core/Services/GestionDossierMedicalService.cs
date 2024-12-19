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

        public Task AddDossierMedicalAsync(DossierMedical dossierMedical)
        {
           return _dossierMedical.AddAsync(dossierMedical);
        }

        public Task GetDossierMedicalByIdAsync(int id)
        {
             return _dossierMedical.GetByIdAsync(id);
        }

        public Task UpdateDossierMedicalAsync(DossierMedical dossierMedical)
        {
            return _dossierMedical.UpdateAsync(dossierMedical);
        }
    }
}
