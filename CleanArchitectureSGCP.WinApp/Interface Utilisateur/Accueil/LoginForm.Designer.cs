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
            LableUserName = new Label();
            TxtUserName = new TextBox();
            LblPassword = new Label();
            TxtPassword = new TextBox();
            Btn_Connexion = new Button();
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
            Btn_Connexion.Size = new Size(250, 32);
            Btn_Connexion.TabIndex = 3;
            Btn_Connexion.Text = "Se Connecter";
            Btn_Connexion.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Connexion.UseVisualStyleBackColor = false;
            Btn_Connexion.Click += Btn_Connexion_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(649, 239);
            Controls.Add(Btn_Connexion);
            Controls.Add(TxtPassword);
            Controls.Add(LblPassword);
            Controls.Add(TxtUserName);
            Controls.Add(LableUserName);
            MaximizeBox = false;
            Name = "MainForm";
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
    }
}
