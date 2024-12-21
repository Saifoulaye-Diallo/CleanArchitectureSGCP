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
    public class PrescriptionRepository : EfRepository<Prescription>, IPrescription
    {
        public PrescriptionRepository(SGCPContext sgcpcontext) : base(sgcpcontext)
        {
        }

        public async Task<List<Prescription>> GetPrescriptionsByConsultationIdAsync(int consultationId)
        {
            var consultation = await _Sgcpcontext.Consultations
                .Include(c => c.Prescriptions) // Inclure les prescriptions associées
                .FirstOrDefaultAsync(c => c.Id == consultationId);

            // Si la consultation est trouvée, retourner les prescriptions associées
            return consultation?.Prescriptions ?? new List<Prescription>();
        }

        public async Task<List<Prescription>> GetPrescriptionsPasseesByPatientIdAsync(int patientId)
        {
            
           // Effectuer la requête avec jointures
            var prescriptions = await _Sgcpcontext.DossiersMedicals
                .Where(dm => dm.PatientId == patientId) // Filtre par ID du patient
                .SelectMany(dm => dm.Consultations)    // Accède aux consultations
                .SelectMany(c => c.Prescriptions)      // Accède aux prescriptions
                .Where(p => p.etat == 0)               // Filtre sur l'état = 0 (passée)
                .ToListAsync();                        // Exécute la requête et retourne la liste

            // Retourner la liste des prescriptions
            return prescriptions;
        }


    }
}
