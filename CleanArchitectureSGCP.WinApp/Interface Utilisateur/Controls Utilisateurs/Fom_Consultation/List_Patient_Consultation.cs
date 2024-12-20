using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm;
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
    public partial class List_Patient_Consultation : UserControl
    {
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionDossierMedicalService _gestionDossierMedicalService;
        private readonly IGestionConsultationsService _gestionConsultationService;
        Core.Entities.Patient _patient;

        public List_Patient_Consultation(IGestionMedecinService gestionMedecinService, IGestionPatientService gestionPatientService, IGestionDossierMedicalService gestionDossierMedicalService, IGestionConsultationsService gestionConsultationService)
        {
            // Initialisation des dépendances
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionDossierMedicalService = gestionDossierMedicalService;
            _gestionConsultationService = gestionConsultationService;
            InitializeComponent();

            // Charger les données
            LoadPatients();

            // Configuration du DataGridView
            dtgPatientList.MultiSelect = false;
            dtgPatientList.AutoGenerateColumns = false;
            StyleDataGridView(dtgPatientList);

            // Abonner les événements
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;

        }

        // Charger la liste des patients dans un DataGridView
        private async void LoadPatients()
        {
            // Désélectionner toutes les cellules après le chargement
            var medecinId = Session.Instance.Medecin.Id;
            // Charger la liste des patients
            var patients = await _gestionPatientService.GetPatientsByMedecinIdAsync(medecinId);
            dtgPatientList.DataSource = null; // Réinitialisez
            dtgPatientList.DataSource = patients; // Rechargez les données
            dtgPatientList.Refresh(); // Rafraîchissez l'affichage
            dtgPatientList.ClearSelection();
            dtgPatientList.AutoGenerateColumns = false;
            dtgPatientList.ClearSelection();
        }

        private void VerifierSelection()
        {
            // Si aucune ligne n'est sélectionnée
            if (dtgPatientList.SelectedRows.Count == 0)
            {
                btn_consulter_historique.Enabled = false;
                btn_ajouter_consultation.Enabled = false;
                _patient = null; // Réinitialiser l'objet patient
                return;
            }

            // Récupérer la première ligne sélectionnée
            DataGridViewRow row = dtgPatientList.SelectedRows[0];

            // Créer et remplir l'objet Patient
            CleanArchitectureSGCP.Core.Entities.Patient _patientSelect = new CleanArchitectureSGCP.Core.Entities.Patient
            {
                Id = (int)row.Cells["ID"].Value,
                Nom = row.Cells["Nom"].Value?.ToString(),
                Prenom = row.Cells["Prenom"].Value?.ToString(),
                Addresse = row.Cells["adresse"].Value?.ToString(),
                AddresseCourriel = row.Cells["Courriel"].Value?.ToString(),
                NumeroTelephones = row.Cells["Telephone"].Value?.ToString(),
                DateDeNaissance = row.Cells["DateDeNaissance"].Value is DateTime date ? date : DateTime.MinValue
            };

            _patient = _patientSelect;

            // Activer les boutons
            btn_consulter_historique.Enabled = true;
            btn_ajouter_consultation.Enabled = true;
        }


        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection();
        }

        private void btn_ajouter_consultation_Click(object sender, EventArgs e)
        {
            var addConsultation = new Add_Consultation(_gestionPatientService, _patient, _gestionDossierMedicalService);

            var result = addConsultation.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadPatients();
                dtgPatientList.ClearSelection();
            }
        }

        private void btn_consulter_historique_Click(object sender, EventArgs e)
        {
            var historyConsultation = new History_Consultation(_patient, _gestionConsultationService);

            var result = historyConsultation.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadPatients();
                dtgPatientList.ClearSelection();
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
