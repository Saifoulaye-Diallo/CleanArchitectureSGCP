using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Patient : BaseEntity, IAggregateRoot
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string Addresse { get; set; }
        public string NumeroTelephones { get; set; }
        public string AddresseCourriel { get; set; }
        public Medecin medecin { get; set; }    
        public Patient() { }

        public Patient(string nom, string prenom, DateTime dateDeNaissance, string addresse, string numeroTelephones, string addresseCourriel, Medecin medecin)
        {
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance;
            Addresse = addresse;
            NumeroTelephones = numeroTelephones;
            AddresseCourriel = addresseCourriel;
            this.medecin = medecin;
        }
    }
}
