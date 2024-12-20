using CleanArchitectureSGCP.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Interfaces
{
    public interface IGestionMedecinService
    {
        Task<Medecin> ConnexionAdync(string nomUtilisateur, string motDepasse);
        Task<Medecin> AddAsync(Medecin medecin);
        Task UpdateAsync(Medecin medecin);

        Task<Medecin> GetMedecinWithPatientsAsync(int medecinId);
    }
}
