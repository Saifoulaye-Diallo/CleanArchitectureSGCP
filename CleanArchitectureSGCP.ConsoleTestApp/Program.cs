using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.Infrastructure;
using CleanArchitectureSGCP.Infrastructure.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bienvenue ");
        UpdatePatient();
        Console.WriteLine("Appuyez sur une touche pour terminer...");
        Console.ReadKey();
        //AddPatientAsync();
    }

    public static async void ajout()
    {
        using (var context = new SGCPContext())
        {
            IMedecin medecinRepo = new MedecinRepository(context);
            IGestionMedecinService medecinService = new GestionMedecinService(medecinRepo);

            Medecin m = new Medecin
            {
                MotDePasse = "15555",
                NomUtilisateur = "Saifon3155",
                Nom = "Saifon112",
                Addresse = "12345 DD",
                AddresseCourriel = "ss@gmail.com",
                NumeroTelephone = "44455",
                NumeroLicence = "114ddd",
                Prenom = "Saifon"
            };


            try
            {
                //Medecin m2 = new Medecin { };
                //m2 = medecinRepo.GetById<Medecin>(1);
                
                //Console.WriteLine($"Début de l'exécution {m2.Nom}"); // Test si le code atteint ce point
                Medecin med = await medecinService.AddAsync(m);
                Console.WriteLine("Médecin enregistré avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : " + ex.Message);
                Console.WriteLine("StackTrace : " + ex.StackTrace);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("InnerException : " + ex.InnerException.Message);
                }
            }
            finally
            {
                Console.WriteLine("Bloc finally exécuté."); // Pour voir si on arrive jusque là
            }


        }


    }

    public static Medecin conexion(string a,string b)
    {
        using (SGCPContext context = new SGCPContext())
        {
            IMedecin _medecin = new MedecinRepository(context);

            IGestionMedecinService medecinService = new GestionMedecinService(_medecin);

            return medecinService.Connexion(a, b);
        }
    }

    public static async void AddPatientAsync()
    {
        try
        {
            // Création du contexte
            using (var context = new SGCPContext())
            {
                // Initialisation des services
                
                IMedecin _medecin = new MedecinRepository(context);
                IGestionMedecinService gestionMedecinService = new GestionMedecinService(_medecin);

                // Récupérer le médecin dans un contexte séparé
                Medecin medecin =await  _medecin.GetByIdAsync(1);

                if (medecin == null)
                {
                    Console.WriteLine("Médecin introuvable.");
                    return;
                }

                Console.WriteLine($"Bonjour {medecin.Nom}");

                // Création d'un patient
                Patient p = new Patient
                {
                    Nom = "Diallo",
                    Prenom = "TEST 0",
                    Addresse = "dfdf",
                    DateDeNaissance = DateTime.Now,
                    AddresseCourriel = "dfdf",
                    NumeroTelephones = "44454555"
                };

                medecin.AddPatient(p);

                // Mise à jour du médecin
                
                 await _medecin.UpdateAsync(medecin);

                Console.WriteLine("Patient ajouté avec succès !");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"InnerException : {ex.InnerException.Message}");
            }
        }
    }
    private static async void testGetAllPatient()
    {
        Console.WriteLine("Bienvenue dans l'application !");

        using (var context = new SGCPContext())
        {
            // Initialiser le repository
            IPatient patientRepository = new PatientRepository(context);
            IGestionPatientService patientService = new GestionPatientService(patientRepository);
            try
            {
                // Récupérer la liste des patients
                var patients = await patientService.GetPatientsByMedecinIdAsync(1);

                // Vérifier si des patients ont été retournés
                if (patients != null && patients.Any())
                {
                    foreach (var patient in patients)
                    {
                        // Afficher les informations du patient
                        Console.WriteLine($"ID: {patient.Id}, Nom: {patient.Nom}, Prénom: {patient.Prenom}");
                    }
                }
                else
                {
                    Console.WriteLine("Aucun patient trouvé pour ce médecin.");
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                Console.WriteLine($"Erreur : {ex.Message}");
                Console.WriteLine($"Détails : {ex.StackTrace}");
            }
        }
    }

    private async static void UpdatePatient()
    {
        using (var context = new SGCPContext())
        {
            IPatient _patientRep = new PatientRepository(context);
            IGestionPatientService _gestionPatientService = new GestionPatientService(_patientRep);

            Patient p = new Patient
            {
                Id = 46,
                Nom = "Diallo",
                Prenom = "TEST 4",
                Addresse = "dfdf",
                DateDeNaissance = DateTime.Now,
                AddresseCourriel = "dfdf",
                NumeroTelephones = "44454555"
            };

            await _gestionPatientService.UpdatePatientAsync(p);

            Console.WriteLine("Modifier");
        }
    }
}
