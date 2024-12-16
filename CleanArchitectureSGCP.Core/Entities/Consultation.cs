using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Consultation : BaseEntity, IAggregateRoot
    {
        public DateTime Date {  get; set; }
        public string Motif {  get; set; }
        public string Observation { get; set; }
        public string Diagnostic { get; set; }

        public Session Session { get; set; }
        public DossierMedical DossierMedical { get; set; }
        public virtual List<Prescription> Prescriptions { get; private set; } = new List<Prescription>();
        public void AddPrescription(Prescription prescription)
        {
            Prescriptions.Add(prescription);
        }
        public void RemovePresctiption(Prescription prescription)
        {
            Prescriptions.Remove(prescription);
        }

        public Consultation() { }

        public Consultation(DateTime date, string motif, string observation, string diagnostic, Session session, DossierMedical dossierMedical, List<Prescription> prescriptions)
        {
            Date = date;
            Motif = motif;
            Observation = observation;
            Diagnostic = diagnostic;
            Session = session;
            DossierMedical = dossierMedical;
            Prescriptions = prescriptions;
        }
    }
}
