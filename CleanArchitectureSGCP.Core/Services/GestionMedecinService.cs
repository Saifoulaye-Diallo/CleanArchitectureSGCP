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

        public async Task AddAsync(Medecin medecin)
        {
            await _medecin.AddAsync(medecin);
        }

        public Medecin Connexion(string nomUtilisateur, string motDepasse)
        {
            return _medecin.Connexion(nomUtilisateur, motDepasse);
        }
    }
}
