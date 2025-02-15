﻿using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IDossierMedical : IAsyncRepository <DossierMedical>, IRepository<DossierMedical>
    {
        Task<DossierMedical> GetDossierMedicalByPatientIdAsync(int patientId);
    }
}
