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
        ajoutMedecinAsync();
        Console.WriteLine("Appuyez sur une touche pour terminer...");
        Console.ReadKey();
        //AddPatientAsync();
    }
 
    public static async void ajoutMedecinAsync()
    {
        // Initialisation du contexte de base de données
        using (var context = new SGCPContext())
        {
            // Création d'un dépôt et d'un service pour gérer les médecins
            IMedecin medecinRepo = new MedecinRepository(context); // Dépôt
            IGestionMedecinService medecinService = new GestionMedecinService(medecinRepo); // Service

            // Création d'un objet Medecin avec des informations saisies par l'utilisateur
            Medecin m = new Medecin();

            Console.WriteLine("Veuillez saisir les informations du médecin :");

            // Demander à l'utilisateur de saisir les informations
            Console.Write("Nom : ");
            m.Nom = Console.ReadLine();

            Console.Write("Prénom : ");
            m.Prenom = Console.ReadLine();

            Console.Write("Nom d'utilisateur : ");
            m.NomUtilisateur = Console.ReadLine();

            Console.Write("Mot de passe : ");
            m.MotDePasse = Console.ReadLine();

            Console.Write("Adresse : ");
            m.Addresse = Console.ReadLine();

            Console.Write("Adresse courriel : ");
            m.AddresseCourriel = Console.ReadLine();

            Console.Write("Numéro de téléphone : ");
            m.NumeroTelephone = Console.ReadLine();

            Console.Write("Numéro de licence : ");
            m.NumeroLicence = Console.ReadLine();

            try
            {
                // Enregistrer le médecin dans la base de données via le service
                Medecin med = await medecinService.AddAsync(m); // Appel asynchrone pour ajouter le médecin
                Console.WriteLine("Médecin enregistré avec succès !");
            }
            catch (Exception ex) // Gestion des erreurs
            {
                // Afficher les informations sur l'exception
                Console.WriteLine("Erreur : " + ex.Message);
                Console.WriteLine("StackTrace : " + ex.StackTrace);

                // Vérifier et afficher l'exception interne s'il y en a une
                if (ex.InnerException != null)
                {
                    Console.WriteLine("InnerException : " + ex.InnerException.Message);
                }
            }
            finally
            {
                // Bloc exécuté quoi qu'il arrive
                Console.WriteLine("Bloc finally exécuté.");
            }
        }
    }

}
