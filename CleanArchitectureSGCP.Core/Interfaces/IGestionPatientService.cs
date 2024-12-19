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
        Task<Patient> AddPatientAsync(Patient patient);

        Task UpdatePatientAsync(Patient patient);

        Task<Patient> GetPatientByIdAsync(int id);
        Task<List<Patient>> GetPatientsByMedecinIdAsync(int medecinId);
    }
}
