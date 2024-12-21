using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.Infrastructure;
using CleanArchitectureSGCP.Infrastructure.Repositories;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Threading;

namespace CleanArchitectureSGCP.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<SGCPContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CleanArchitectureSGCPDB;Trusted_Connection=True;"));


                services.AddSingleton<Accueil>();

                services.AddTransient<LoginForm>();

                services.AddLogging(configure => configure.AddConsole());
                //Medecin
                services.AddScoped<IMedecin, MedecinRepository>();
                services.AddScoped<IGestionMedecinService, GestionMedecinService>();
                //Consultation
                services.AddScoped<IConsultation, ConsultationRepository>();
                services.AddScoped<IGestionConsultationsService, GestionConsultationService>();
                //DossierMedical
                services.AddScoped<IDossierMedical, DossierMedicalRepository>();
                services.AddScoped<IGestionDossierMedicalService, GestionDossierMedicalService>();
                //Patient
                services.AddScoped<IPatient, PatientRepository>();
                services.AddScoped<IGestionPatientService, GestionPatientService>();
                //Prescription
                services.AddScoped<IPrescription, PrescriptionRepository>();
                services.AddScoped<IGestionPrescriptionService, GestionPrescriptionService>();

            });
            var host = builder.Build();
            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var forms = services.GetRequiredService<LoginForm>();
                    Application.Run(forms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                }
            }
            // Définir la culture en français
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
        }
    }
}