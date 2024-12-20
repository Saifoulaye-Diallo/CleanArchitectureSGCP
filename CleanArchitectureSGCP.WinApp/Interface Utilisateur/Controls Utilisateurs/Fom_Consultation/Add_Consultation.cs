using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using MetroFramework.Forms;
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
    public partial class Add_Consultation : MetroForm
    {
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService;
        Core.Entities.Patient _patient;
        public Add_Consultation(IGestionPatientService gestionPatientService, Core.Entities.Patient patient, IGestionDossierMedicalService gestionDossierMedicalService)
        {
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture
            _gestionPatientService = gestionPatientService;
            _patient = patient;
            _gestionDossierMedicalService = gestionDossierMedicalService;
            InitializeComponent();
            InitFichePatient();
        
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

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_motif.Text) || string.IsNullOrWhiteSpace(Txt_obsevation?.Text) ||
                   string.IsNullOrWhiteSpace(Txt_diagnostic?.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires.",
                                "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Core.Entities.Consultation consultation = new Core.Entities.Consultation
            {
                Diagnostic = Txt_diagnostic.Text,
                Motif = Txt_motif.Text,
                Observation = Txt_obsevation.Text,
                Date = DateTime.Now
            };
            Session.Instance.AddConsultation(consultation);
            Core.Entities.Patient patient = await _gestionPatientService.GetPatientByIdAsync(_patient.Id);
            if (patient != null) {
                Core.Entities.DossierMedical dossierMedical = await _gestionDossierMedicalService.GetDossierMedicalByPatientIdAsync(patient.Id);
                dossierMedical.AddConsultation(consultation);
                await _gestionDossierMedicalService.UpdateDossierMedicalAsync(dossierMedical);
                MessageBox.Show("La consultation a été ajouter avec succès",
                              "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Indiquer que l'opération a réussi
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
