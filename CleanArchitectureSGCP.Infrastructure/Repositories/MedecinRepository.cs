using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Infrastructure.Repositories
{
    public class MedecinRepository : EfRepository<Medecin>, IMedecin
    {
        public MedecinRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }

        public Medecin Connexion(string nomUtilisateur, string motDePasse)
        {
            var medecin = _Sgcpcontext.Medecins.FirstOrDefault(u => u.NomUtilisateur == nomUtilisateur && u.MotDePasse == motDePasse);

            if (medecin != null)
            {
                Session.Instance.Initialize(DateTime.Now, DateTime.Now, medecin);
                return medecin;
            }
            else
            {
                return null;
            }
        }
    }
}
