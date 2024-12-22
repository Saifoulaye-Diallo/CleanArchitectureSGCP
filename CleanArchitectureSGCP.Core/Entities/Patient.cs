using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Patient : BaseEntity, IAggregateRoot
    {
        // Propriétés de base
        public string Nom { get; set; }
        public string Prenom { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateDeNaissance
        {
            get => _dateDeNaissance;
            set => _dateDeNaissance = value.Date; // Supprime l'heure, fixe à 00:00:00
        }
        private DateTime _dateDeNaissance;

        // Propriété calculée uniquement pour l'affichage (readonly)
        public string DateDeNaissanceFormatee => DateDeNaissance.ToString("yyyy/MM/dd");

        public string Addresse { get; set; }
        public string NumeroTelephones { get; set; }
        public string AddresseCourriel { get; set; }
        public virtual DossierMedical DossierMedical { get; set; }

        // Constructeur par défaut
        public Patient() { }

        // Constructeur simplifié
        public Patient(string nom, string prenom, DateTime dateDeNaissance, string addresse, string numeroTelephones, string addresseCourriel, DossierMedical dossierMedical)
        {
            Nom = nom;
            Prenom = prenom;
            DateDeNaissance = dateDeNaissance; // Stockage direct avec suppression de l'heure
            Addresse = addresse;
            NumeroTelephones = numeroTelephones;
            AddresseCourriel = addresseCourriel;
            DossierMedical = dossierMedical;
        }
    }
}
