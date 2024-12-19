using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Session : BaseEntity, IAggregateRoot
    {
        private static Session _instance;
        private static readonly object _lock = new object();

        public DateTime DateConnexion { get; private set; }
        private DateTime _dateDeconnexion;
        public DateTime DateDeconnexion
        {
            get => _dateDeconnexion;
            set
            {
                if (value < DateConnexion)
                {
                    throw new ArgumentException("La date de déconnexion ne peut pas être antérieure à la date de connexion.");
                }
                _dateDeconnexion = value;
            }
        }

        public Medecin Medecin { get; private set; }

        // Liste des consultations associées à la session (encapsulation avec propriété privée)
        private List<Consultation> _consultations = new List<Consultation>();
        public IReadOnlyList<Consultation> Consultations => _consultations.AsReadOnly();

        // Ajout d'une consultation
        public void AddConsultation(Consultation consultation)
        {
            if (consultation == null) throw new ArgumentNullException(nameof(consultation));
            _consultations.Add(consultation);
        }

        // Suppression d'une consultation
        public void RemoveConsultation(Consultation consultation)
        {
            if (consultation == null) throw new ArgumentNullException(nameof(consultation));
            _consultations.Remove(consultation);
        }

        // Constructeur privé pour empêcher l'instanciation directe
        private Session() { }

        // Méthode statique pour obtenir l'instance unique
        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Session();
                        }
                    }
                }
                return _instance;
            }
        }

        // Méthode pour initialiser ou mettre à jour les propriétés de la session
        public void Initialize(DateTime dateConnexion, DateTime dateDeconnexion, Medecin medecin)
        {
            if (dateDeconnexion < dateConnexion)
            {
                throw new ArgumentException("La date de déconnexion ne peut pas être antérieure à la date de connexion.");
            }

            DateConnexion = dateConnexion;
            DateDeconnexion = dateDeconnexion;
            Medecin = medecin;
        }

      
    }
}
