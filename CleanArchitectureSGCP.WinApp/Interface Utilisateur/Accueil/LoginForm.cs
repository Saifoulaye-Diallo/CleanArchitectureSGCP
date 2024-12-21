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
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService;
        private readonly IGestionConsultationsService _gestionConsultationsService;
        private readonly IGestionPrescriptionService _gestionPrescriptionService;
        public LoginForm(IGestionMedecinService gestionMedecinService, IGestionPatientService gestionPatientService, IGestionDossierMedicalService gestionDossierMedicalService, IGestionConsultationsService gestionConsultationsService, IGestionPrescriptionService gestionPrescriptionService)
        {

            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService;
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationsService = gestionConsultationsService;
            _gestionPrescriptionService = gestionPrescriptionService;

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

                var resultat = await _gestionMedecinService.ConnexionAdync(nomUtilisateur, motDePasse);


                if (resultat != null)
                {
                    if (Session.Instance != null)
                    {
                        // Fermer LoginForm et ouvrir MainForm
                        var accueil = new Accueil(_gestionPatientService, _gestionMedecinService, _gestionDossierMedicalService, _gestionConsultationsService, _gestionPrescriptionService);
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

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
