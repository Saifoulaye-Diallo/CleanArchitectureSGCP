using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient;
using CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm;
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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Patient
{
    public partial class ListPatients : UserControl
    {
        private readonly IGestionMedecinService _gestionMedecinService;
        private readonly IGestionPatientService _gestionPatientService;

        CleanArchitectureSGCP.Core.Entities.Patient _patient;
        public ListPatients(IGestionMedecinService gestionMedecinService, IGestionPatientService gestionPatientService)
        {
            // Initialisation des dépendances
            _gestionMedecinService = gestionMedecinService;
            _gestionPatientService = gestionPatientService ?? throw new ArgumentNullException(nameof(gestionPatientService));

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

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            var addPatientForm = new AddPatient(_gestionMedecinService);

            var result = addPatientForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadPatients(); // Recharger les patients après ajout
                dtgPatientList.ClearSelection();
            }

        }



        private void btn_Modifier_Click(object sender, EventArgs e)
        {

            if (_patient != null)
            {
                var upDatePatientForm = new UpdatePatient(_gestionPatientService, _patient);
                var result = upDatePatientForm.ShowDialog();

                // Si l'utilisateur a cliqué sur "Save", rechargez les patients
                if (result == DialogResult.OK)
                {
                    LoadPatients(); // Recharger les patients après ajout
                    dtgPatientList.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Selectionnez un patient a modifier !!");
            }

        }

        private void VerifierSelection()
        {
            // Si aucune ligne n'est sélectionnée
            if (dtgPatientList.SelectedRows.Count == 0)
            {
                btn_consulter.Enabled = false;
                btn_Modifier.Enabled = false;
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
            btn_consulter.Enabled = true;
            btn_Modifier.Enabled = true;
        }


        private void DtgPatientList_SelectionChanged(object sender, EventArgs e)
        {
            VerifierSelection();
        }

        private void btn_consulter_Click(object sender, EventArgs e)
        {
            if (_patient != null)
            {
                var upDatePatientForm = new ViewPatient(_patient);
                var result = upDatePatientForm.ShowDialog();
            }
        }
    }
}
