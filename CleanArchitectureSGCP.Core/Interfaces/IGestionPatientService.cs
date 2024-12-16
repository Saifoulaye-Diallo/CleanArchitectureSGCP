using CleanArchitectureSGCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionPatientService
    {
        Task AddPatient(Patient patient);

        Task UpdatePatient(Patient patient);

        Task GetPatientById(int id);
    }
}
