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

namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Controls_Utilisateurs.PatientForm
{
    public partial class AddPatient : MetroForm
    {
        private readonly IGestionMedecinService _gestionMedecinService;
       
        public AddPatient(IGestionMedecinService gestionMedecinService)
        {
           
            InitializeComponent();

            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture
            _gestionMedecinService = gestionMedecinService;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Fonction pour nettoyer les champs après ajout
        private void ClearFields()
        {
            Nom.Text = string.Empty;
            Prenom.Text = string.Empty;
            Date.Value = DateTime.Now;
            Telephone.Text = string.Empty;
            Adresse.Text = string.Empty;
            Courriel.Text = string.Empty;
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
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

                // Création et assignation de l'objet Patient
                CleanArchitectureSGCP.Core.Entities.Patient patient = new CleanArchitectureSGCP.Core.Entities.Patient
                {
                    Nom = Nom.Text,
                    Prenom = Prenom.Text,
                    DateDeNaissance = Date?.Value ?? DateTime.Now,
                    NumeroTelephones = Telephone.Text,
                    Addresse = Adresse.Text,
                    AddresseCourriel = Courriel.Text,
                    
                    
                };
                DossierMedical dossierMedical = new DossierMedical();
                patient.DossierMedical = dossierMedical;
                Session.Instance.DateDeconnexion = DateTime.Now;
                var medecin = Session.Instance.Medecin;
                medecin.AddPatient(patient);
               
                await _gestionMedecinService.UpdateAsync(medecin);
            
                MessageBox.Show("Le patient a été ajouté avec succès.", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Nettoyage du formulaire
                ClearFields();
                // Indiquer que l'opération a réussi
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
