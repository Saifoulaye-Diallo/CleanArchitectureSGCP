namespace CleanArchitectureSGCP.WinApp.Interface_Utilisateur.Accueil
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LableUserName = new Label();
            TxtUserName = new TextBox();
            LblPassword = new Label();
            TxtPassword = new TextBox();
            Btn_Connexion = new Button();
            toolTip = new ToolTip(components);
            btn_fermer = new Button();
            SuspendLayout();
            // 
            // LableUserName
            // 
            LableUserName.AutoSize = true;
            LableUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LableUserName.ForeColor = Color.DarkSlateGray;
            LableUserName.Location = new Point(80, 80);
            LableUserName.Name = "LableUserName";
            LableUserName.Size = new Size(153, 21);
            LableUserName.TabIndex = 5;
            LableUserName.Text = "Nom d'utilisateur :";
            // 
            // TxtUserName
            // 
            TxtUserName.BackColor = Color.White;
            TxtUserName.Font = new Font("Segoe UI", 11F);
            TxtUserName.ForeColor = Color.DarkSlateGray;
            TxtUserName.Location = new Point(260, 80);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(250, 27);
            TxtUserName.TabIndex = 1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblPassword.ForeColor = Color.DarkSlateGray;
            LblPassword.Location = new Point(80, 130);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(118, 21);
            LblPassword.TabIndex = 4;
            LblPassword.Text = "Mot de passe :";
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.White;
            TxtPassword.Font = new Font("Segoe UI", 11F);
            TxtPassword.ForeColor = Color.DarkSlateGray;
            TxtPassword.Location = new Point(260, 130);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '●';
            TxtPassword.Size = new Size(250, 27);
            TxtPassword.TabIndex = 2;
            // 
            // Btn_Connexion
            // 
            Btn_Connexion.BackColor = Color.MediumSeaGreen;
            Btn_Connexion.FlatStyle = FlatStyle.Flat;
            Btn_Connexion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Btn_Connexion.ForeColor = Color.White;
            Btn_Connexion.ImageAlign = ContentAlignment.TopLeft;
            Btn_Connexion.Location = new Point(260, 184);
            Btn_Connexion.Name = "Btn_Connexion";
            Btn_Connexion.Size = new Size(129, 32);
            Btn_Connexion.TabIndex = 3;
            Btn_Connexion.Text = "Se Connecter";
            Btn_Connexion.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip.SetToolTip(Btn_Connexion, "Entrer vos informations et cliquer ici pour vous connecter .");
            Btn_Connexion.UseVisualStyleBackColor = false;
            Btn_Connexion.Click += Btn_Connexion_Click;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 200;
            toolTip.ReshowDelay = 100;
            toolTip.ShowAlways = true;
            // 
            // btn_fermer
            // 
            btn_fermer.BackColor = Color.FromArgb(255, 82, 82);
            btn_fermer.FlatAppearance.BorderSize = 0;
            btn_fermer.FlatStyle = FlatStyle.Flat;
            btn_fermer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_fermer.ForeColor = Color.White;
            btn_fermer.Image = (Image)resources.GetObject("btn_fermer.Image");
            btn_fermer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_fermer.Location = new Point(403, 184);
            btn_fermer.Name = "btn_fermer";
            btn_fermer.Size = new Size(107, 32);
            btn_fermer.TabIndex = 6;
            btn_fermer.Text = "Fermer";
            btn_fermer.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(btn_fermer, "Cliquez ici pour enregistrer l'ajout de la nouvelle consultation.");
            btn_fermer.UseVisualStyleBackColor = false;
            btn_fermer.Click += btn_fermer_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(649, 239);
            Controls.Add(btn_fermer);
            Controls.Add(Btn_Connexion);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUserName);
            Controls.Add(LableUserName);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Système de Gestion des Consultations et des Prescriptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LableUserName;
        private TextBox TxtUserName;
        private Label LblPassword;
        private TextBox TxtPassword;
        private Button Btn_Connexion;
        private ToolTip toolTip;
        private Button btn_fermer;
    }
}
