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
    public partial class ViewPatient : MetroForm
    {
        CleanArchitectureSGCP.Core.Entities.Patient _patient;
        public ViewPatient(Core.Entities.Patient patient)
        {
            InitializeComponent();
            this.MaximizeBox = false; // Désactive le bouton Maximiser
            this.StartPosition = FormStartPosition.CenterScreen; // Centre le formulaire à l'ouverture
            _patient = patient;
            DisplayData();
        }


        public void DisplayData()
        {
            TxtNom.Text = _patient.Nom;
            TxtPrenom.Text = _patient.Prenom;
            TxtAdresse.Text = _patient.Addresse;
            TxtCourriel.Text = _patient.AddresseCourriel;

            // Formater la date en AAAA/MM/JJ
            TxtDate.Text = _patient.DateDeNaissance.ToString("yyyy/MM/dd");

            TxtTelephone.Text = _patient.NumeroTelephones;
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
