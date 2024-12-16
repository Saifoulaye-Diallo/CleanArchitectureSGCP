using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.Infrastructure;
using CleanArchitectureSGCP.Infrastructure.Repositories;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans l'application !");
       
    }
    
    public static async void ajout()
    {
        using (SGCPContext context = new SGCPContext())
        {
            IMedecin _medecin = new MedecinRepository(context);

            IGestionMedecinService medecinService = new GestionMedecinService(_medecin);

            Medecin m = new Medecin();
            m.MotDePasse = "1234";
            m.NomUtilisateur = "Saifon";
            m.Nom = "Saifon";
            m.Addresse = "12345 DD";
            m.AddresseCourriel = "ss@gmail.com";
            m.NumeroTelephone = "44455";
            m.NumeroLicence = "114ddd";
            m.Prenom = "Saifon";
            Console.WriteLine("Enregistreer !");
            await medecinService.AddAsync(m);
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
}
