using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using MetroFramework.Forms;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Fom_Consultation
{
    public partial class History_Consultation : MetroForm
    {
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService;
        private readonly IGestionConsultationsService _gestionConsultationsService;
        Core.Entities.Patient _patient;
        public History_Consultation(Core.Entities.Patient patient, IGestionConsultationsService gestionConsultationsService)
        {
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture

            _patient = patient;

            _gestionConsultationsService = gestionConsultationsService;
            InitializeComponent();
            InitFichePatient();
            LoadConsultation();
            StyleDataGridView(dtgConsultationHistorytList);
        }
        // Initialisation des donnees du patient choisi
        private void InitFichePatient()
        {
            if (_patient != null)
            {
                TxtNom.Text = _patient.Nom;
                TxtPrenom.Text = _patient.Prenom;
                TxtAddresse.Text = _patient.Addresse;
                TxtCourriel.Text = _patient.AddresseCourriel;
                TxtDate.Text = _patient.DateDeNaissance.ToString("AAAA/MM/JJ");
                TxtTelephone.Text = _patient.NumeroTelephones;
            }
        }

        // Charger la liste des patients dans un DataGridView
        private async void LoadConsultation()
        {

            // Charger la liste des consultation
            // Charger la liste des consultations
            var consultations = await _gestionConsultationsService.GetConsultationsByPatientIdAsync(_patient.Id);

            if (consultations != null && consultations.Any())
            {
                dtgConsultationHistorytList.DataSource = null; // Réinitialisez
                dtgConsultationHistorytList.DataSource = consultations; // Rechargez les données
                dtgConsultationHistorytList.Refresh(); // Rafraîchissez l'affichage
                dtgConsultationHistorytList.AutoGenerateColumns = false;
                dtgConsultationHistorytList.ClearSelection();
            }
            else
            {
                MessageBox.Show("La liste de consultations de ce patient est vide.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
