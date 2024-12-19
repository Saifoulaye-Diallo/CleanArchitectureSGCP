using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using MetroFramework.Forms;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{
    public partial class LoginForm : MetroForm
    {
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;
      
      

        public LoginForm(IGestionMedecinService gestionMedecinService,IGestionPatientService gestionPatientService)
        {
            
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService;
            InitializeComponent();
        }
        private async void Btn_Connexion_Click(object sender, EventArgs e)
        {
            // Affichage de la barre de progression et du message
            Btn_Connexion.Enabled = false;
            try
            {
                var nomUtilisateur = TxtUserName.Text;
                var motDePasse = TxtPassword.Text;

                var resultat = await Task.Run(() => _gestionMedecinService.Connexion(nomUtilisateur, motDePasse));
               

                if (resultat != null)
                {
                    if (Session.Instance != null)
                    {
                        // Fermer LoginForm et ouvrir MainForm
                        var accueil = new Accueil(_gestionPatientService,_gestionMedecinService);
                        accueil.Show();

                        this.Hide(); // Cache LoginForm
                    }
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                Btn_Connexion.Enabled = true;
            }
        
        }
    }
}
