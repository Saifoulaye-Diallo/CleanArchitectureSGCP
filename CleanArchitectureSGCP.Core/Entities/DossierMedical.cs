using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class DossierMedical : BaseEntity, IAggregateRoot
    {
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual List<Prescription> TraitementPasses { get; private set; } = new List<Prescription>();

        public virtual List<Consultation> Consultations { get; private set; } = new List<Consultation>();
        public void AddTraiteementPasse(Prescription passe)
        {
            TraitementPasses.Add(passe);
        }

        public void RemoveTraiteementPasse(Prescription passe)
        {
            TraitementPasses.Remove(passe);
        }

        public void AddConsultation(Consultation consultation)
        {
            Consultations.Add(consultation);
        }

        public void RemoveConsultation(Consultation consultation)
        {
            Consultations.Remove(consultation);
        }

        public DossierMedical() { }

        public DossierMedical(Patient patient, List<Prescription> traitementPasses, List<Consultation> consultations)
        {
            Patient = patient;
            TraitementPasses = traitementPasses;
            Consultations = consultations;
        }
    }
}
