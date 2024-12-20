using CleanArchitectureSGCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionDossierMedicalService
    {
        Task<DossierMedical> AddDossierMedicalAsync(DossierMedical dossierMedical);

        Task UpdateDossierMedicalAsync(DossierMedical dossierMedical);

        Task<DossierMedical> GetDossierMedicalByIdAsync(int id);
        Task<DossierMedical> GetDossierMedicalByPatientIdAsync(int patientId);
    }
}
