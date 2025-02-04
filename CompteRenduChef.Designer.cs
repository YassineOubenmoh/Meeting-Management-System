namespace GestionDesReunions
{
    partial class CompteRenduChef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridCompte = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uploadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.textBoxfichier = new System.Windows.Forms.TextBox();
            this.fichierTextBox = new System.Windows.Forms.Label();
            this.textBoxReunion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 779);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(198, 701);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(307, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Boite de Réception";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Compte Rendus";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salle | Matériel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Réunions";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tableau de Bord";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(817, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Réunions Terminées";
            // 
            // DataGridCompte
            // 
            this.DataGridCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCompte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ChefProjet,
            this.Sujet,
            this.DateHeure,
            this.DateFin,
            this.EtatReunion,
            this.NomSalle});
            this.DataGridCompte.Location = new System.Drawing.Point(310, 90);
            this.DataGridCompte.Name = "DataGridCompte";
            this.DataGridCompte.RowHeadersWidth = 51;
            this.DataGridCompte.RowTemplate.Height = 24;
            this.DataGridCompte.Size = new System.Drawing.Size(1246, 397);
            this.DataGridCompte.TabIndex = 2;
            this.DataGridCompte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCompte_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_reunion";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 190;
            // 
            // ChefProjet
            // 
            this.ChefProjet.DataPropertyName = "full_name";
            this.ChefProjet.HeaderText = "Chef de Projet";
            this.ChefProjet.MinimumWidth = 6;
            this.ChefProjet.Name = "ChefProjet";
            this.ChefProjet.Width = 190;
            // 
            // Sujet
            // 
            this.Sujet.DataPropertyName = "Sujet";
            this.Sujet.HeaderText = "Sujet";
            this.Sujet.MinimumWidth = 6;
            this.Sujet.Name = "Sujet";
            this.Sujet.Width = 190;
            // 
            // DateHeure
            // 
            this.DateHeure.DataPropertyName = "DateHeureDebut";
            this.DateHeure.HeaderText = "Début de Réunion";
            this.DateHeure.MinimumWidth = 6;
            this.DateHeure.Name = "DateHeure";
            this.DateHeure.Width = 190;
            // 
            // DateFin
            // 
            this.DateFin.DataPropertyName = "DateHeureFin";
            this.DateFin.HeaderText = "Fin de Réunion";
            this.DateFin.MinimumWidth = 6;
            this.DateFin.Name = "DateFin";
            this.DateFin.Width = 190;
            // 
            // EtatReunion
            // 
            this.EtatReunion.DataPropertyName = "Etat_Reunion";
            this.EtatReunion.HeaderText = "Etat de Réunion";
            this.EtatReunion.MinimumWidth = 6;
            this.EtatReunion.Name = "EtatReunion";
            this.EtatReunion.Width = 190;
            // 
            // NomSalle
            // 
            this.NomSalle.DataPropertyName = "Nom";
            this.NomSalle.HeaderText = "Salle";
            this.NomSalle.MinimumWidth = 6;
            this.NomSalle.Name = "NomSalle";
            this.NomSalle.Width = 190;
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uploadButton.Location = new System.Drawing.Point(310, 502);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(283, 61);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Ajouter Un CompteRendu";
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(69)))), ((int)(((byte)(57)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveButton.Location = new System.Drawing.Point(611, 502);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 61);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Enregistrer";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // textBoxfichier
            // 
            this.textBoxfichier.Location = new System.Drawing.Point(329, 636);
            this.textBoxfichier.Name = "textBoxfichier";
            this.textBoxfichier.Size = new System.Drawing.Size(195, 22);
            this.textBoxfichier.TabIndex = 6;
            // 
            // fichierTextBox
            // 
            this.fichierTextBox.AutoSize = true;
            this.fichierTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fichierTextBox.Location = new System.Drawing.Point(324, 594);
            this.fichierTextBox.Name = "fichierTextBox";
            this.fichierTextBox.Size = new System.Drawing.Size(200, 25);
            this.fichierTextBox.TabIndex = 7;
            this.fichierTextBox.Text = "Chemin du Fichier :";
            // 
            // textBoxReunion
            // 
            this.textBoxReunion.Location = new System.Drawing.Point(1456, 513);
            this.textBoxReunion.Name = "textBoxReunion";
            this.textBoxReunion.Size = new System.Drawing.Size(100, 22);
            this.textBoxReunion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1267, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Réunion Choisie :";
            // 
            // CompteRenduChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReunion);
            this.Controls.Add(this.fichierTextBox);
            this.Controls.Add(this.textBoxfichier);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.DataGridCompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CompteRenduChef";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte Rendu";
            this.Load += new System.EventHandler(this.CompteRenduChef_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefProjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSalle;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textBoxfichier;
        private System.Windows.Forms.Label fichierTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxReunion;
        private System.Windows.Forms.Label label2;
    }
}