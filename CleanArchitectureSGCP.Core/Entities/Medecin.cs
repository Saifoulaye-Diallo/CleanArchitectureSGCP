using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Medecin : Utilisateur , IAggregateRoot
    {
        public string NumeroLicence { get; set; }
        public string Nom {  get; set; }
        public string Prenom { get; set;}
        public string Addresse { get; set; }
        public string NumeroTelephone { get; set; }
        public string AddresseCourriel { get; set; }

        public virtual List<Patient> Patients { get;private set; } = new List<Patient>();
        public virtual List<Session> Sessions { get; private set; } = new List<Session>();
        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }
        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }
        public void AddSession(Session session)
        {
            Sessions.Add(session);
        }
        public void RemoveSession(Session session)
        {
            Sessions.Remove(session);
        }

        public Medecin() { }

        public Medecin(string numeroLicence, string nom, string prenom, string addresse, string numeroTelephone, string addresseCourriel, List<Patient> patients, List<Session> sessions)
        {
            NumeroLicence = numeroLicence;
            Nom = nom;
            Prenom = prenom;
            Addresse = addresse;
            NumeroTelephone = numeroTelephone;
            AddresseCourriel = addresseCourriel;
            this.Patients = patients;
            Sessions = sessions;
        }
    }
}
