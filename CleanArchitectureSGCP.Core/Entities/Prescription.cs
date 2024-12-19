using CleanArchitectureSGCP.SharedKernel;
using CleanArchitectureSGCP.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Core.Entities
{
    public class Prescription : BaseEntity, IAggregateRoot
    {
        public string Medicament { get; set; }
        public string Dosage { get; set; }
        public string Instruction { get; set; }
        public string Duree { get; set; }
        public int etat { get; set; }

        public Prescription() { }

        public Prescription(string medicament, string dosage, string instruction, string duree, int etat)
        {
            Medicament = medicament;
            Dosage = dosage;
            Instruction = instruction;
            Duree = duree;
            this.etat = etat;
        }
    }
}
