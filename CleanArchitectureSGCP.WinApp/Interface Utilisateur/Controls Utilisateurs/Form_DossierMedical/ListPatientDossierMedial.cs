using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient;
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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_DossierMedical
{
    public partial class ListPatientDossierMedial : UserControl
    {
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;
        private readonly IGestionPrescriptionService _gestionPrescriptionService;

        CleanArchitectureSGCP.Core.Entities.Patient _patient;
        public ListPatientDossierMedial(IGestionMedecinService gestionMedecinService, IGestionPatientService gestionPatientService, IGestionPrescriptionService gestionPrescriptionService)
        {
            // Initialisation des dépendances
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));
            _gestionPrescriptionService = gestionPrescriptionService;

            // Initialiser les composants
            InitializeComponent();

            // Configuration du DataGridView
            dtgPatientList.MultiSelect = false;
            dtgPatientList.AutoGenerateColumns = false;
            StyleDataGridView(dtgPatientList);

            // Charger les données
            LoadPatients();

            // Abonner les événements
            dtgPatientList.SelectionChanged += DtgPatientList_SelectionChanged;
        }

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
                btn_prescriptions.Enabled = false;

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
            btn_prescriptions.Enabled = true;

        }

        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection();
        }



        private void btn_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_prescriptions_Click(object sender, EventArgs e)
        {
            var traitementpasse = new ListPrescriptionPassees(_gestionPrescriptionService,_patient);
            traitementpasse.ShowDialog();
        }
    }
}
