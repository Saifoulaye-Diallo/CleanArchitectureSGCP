using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Entities
{
    public abstract class Utilisateur : BaseEntity, IAggregateRoot
    {
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }

        public Utilisateur() { }

        public Utilisateur(string nomUtilisateur, string motDePasse)
        {
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
        }
    }
}
