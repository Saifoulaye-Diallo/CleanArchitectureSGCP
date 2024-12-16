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
        Task AddDossierMedical(DossierMedical dossierMedical);

        Task UpdateDossierMedical(DossierMedical dossierMedical);

        Task GetDossierMedicalById(int id);
    }
}
