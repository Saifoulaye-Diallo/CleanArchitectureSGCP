using CleanArchitectureSGCP.Core.Entities;
using CleanArchitectureSGCP.Core.Interfaces;
using CleanArchitectureSGCP.Core.Services;
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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.Form_Patient
{
    public partial class UpdatePatient : MetroForm
    {

        private readonly IGestionPatientService _gestionPatientService;

        CleanArchitectureSGCP.Core.Entities.Patient _patient;
        public UpdatePatient(IGestionPatientService gestionPatientService, CleanArchitectureSGCP.Core.Entities.Patient patient)
        {
            InitializeComponent();

            _gestionPatientService = gestionPatientService;
            _patient = patient;

            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.MinimizeBox = true;  // Le bouton Minimiser reste activé (facultatif)
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture
            LoadPatientData();

        }

        private void LoadPatientData()
        {
            Nom.Text = _patient.Nom;
            Prenom.Text = _patient.Prenom;
            Telephone.Text = _patient.NumeroTelephones;
            Adresse.Text = _patient.Addresse;
            Courriel.Text = _patient.AddresseCourriel;
            Date.Value = _patient.DateDeNaissance;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            
            // Vérification des champs obligatoires
            if (string.IsNullOrWhiteSpace(Nom?.Text) || string.IsNullOrWhiteSpace(Prenom?.Text) ||
                string.IsNullOrWhiteSpace(Telephone?.Text) || string.IsNullOrWhiteSpace(Adresse?.Text) ||
                string.IsNullOrWhiteSpace(Courriel?.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires.",
                                "Erreur de Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
             CleanArchitectureSGCP.Core.Entities.Patient patient = await _gestionPatientService.GetPatientByIdAsync(_patient.Id);
            patient.Nom = Nom.Text;
            patient.Prenom = Prenom.Text;
            patient.DateDeNaissance = Date.Value;
            patient.NumeroTelephones = Telephone.Text;
            patient.Addresse = Adresse.Text;
            patient.AddresseCourriel = Courriel.Text;
           
                
            try{
                
                await _gestionPatientService.UpdatePatientAsync(patient);
                MessageBox.Show("Patient mis à jour avec succès !");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
