using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Services
{
    public class GestionMedecinService : IGestionMedecinService
    {
        public readonly IMedecin _medecin;

        public GestionMedecinService(IMedecin medecin)
        {
            _medecin = medecin;
        }

        public async Task<Medecin> AddAsync(Medecin medecin)
        {
             return await _medecin.AddAsync(medecin);
        }

        public async Task<Medecin> ConnexionAdync(string nomUtilisateur, string motDepasse)
        {
            return await _medecin.ConnexionAdync(nomUtilisateur, motDepasse);
        }

        public Task<Medecin> GetMedecinWithPatientsAsync(int medecinId)
        {
            return _medecin.GetMedecinWithPatientsAsync(medecinId);
        }

        public async Task UpdateAsync(Medecin medecin)
        {
             await _medecin.UpdateAsync(medecin);
        }
    }
}
