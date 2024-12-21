using CleanArchitectureSGCP.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSGCP.Infrastructure
{
    public class SGCPContext : DbContext
    {
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }    
        public DbSet<Medecin> Medecins { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<DossierMedical> DossiersMedicals { get; set; }
        
        public SGCPContext(DbContextOptions options) :
                             base(options)
        { }
        public SGCPContext() : base(new
               DbContextOptionsBuilder<SGCPContext>()

               .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CleanArchitectureSGCPDB;Trusted_Connection=True;")
               .Options)
        { }

    }
}
