namespace GestionDesReunions
{
    partial class ReunionParticipant
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridReunion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateHeure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AjouterCompteRendu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfichier = new System.Windows.Forms.TextBox();
            this.EnregistrerCompteRendu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReunion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReunion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 779);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(204, 704);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(308, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Boite de Réception";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mes Réunions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridReunion
            // 
            this.DataGridReunion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridReunion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sujet,
            this.DateHeure,
            this.DateFin,
            this.EtatReunion,
            this.Salle});
            this.DataGridReunion.Location = new System.Drawing.Point(310, 12);
            this.DataGridReunion.Name = "DataGridReunion";
            this.DataGridReunion.RowHeadersWidth = 51;
            this.DataGridReunion.RowTemplate.Height = 24;
            this.DataGridReunion.Size = new System.Drawing.Size(1260, 271);
            this.DataGridReunion.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_reunion";
            this.ID.HeaderText = "Id Réunion";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 215;
            // 
            // Sujet
            // 
            this.Sujet.DataPropertyName = "Sujet";
            this.Sujet.HeaderText = "Sujet";
            this.Sujet.MinimumWidth = 6;
            this.Sujet.Name = "Sujet";
            this.Sujet.Width = 215;
            // 
            // DateHeure
            // 
            this.DateHeure.DataPropertyName = "DateHeureDebut";
            this.DateHeure.HeaderText = "Début de Réunion";
            this.DateHeure.MinimumWidth = 6;
            this.DateHeure.Name = "DateHeure";
            this.DateHeure.Width = 215;
            // 
            // DateFin
            // 
            this.DateFin.DataPropertyName = "DateHeureFin";
            this.DateFin.HeaderText = "Fin de Réunion";
            this.DateFin.MinimumWidth = 6;
            this.DateFin.Name = "DateFin";
            this.DateFin.Width = 215;
            // 
            // EtatReunion
            // 
            this.EtatReunion.DataPropertyName = "Etat_Reunion";
            this.EtatReunion.HeaderText = "Etat de Réunion";
            this.EtatReunion.MinimumWidth = 6;
            this.EtatReunion.Name = "EtatReunion";
            this.EtatReunion.Width = 215;
            // 
            // Salle
            // 
            this.Salle.DataPropertyName = "Nom";
            this.Salle.HeaderText = "Salle";
            this.Salle.MinimumWidth = 6;
            this.Salle.Name = "Salle";
            this.Salle.Width = 215;
            // 
            // AjouterCompteRendu
            // 
            this.AjouterCompteRendu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(112)))), ((int)(((byte)(156)))));
            this.AjouterCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterCompteRendu.Location = new System.Drawing.Point(310, 301);
            this.AjouterCompteRendu.Name = "AjouterCompteRendu";
            this.AjouterCompteRendu.Size = new System.Drawing.Size(339, 54);
            this.AjouterCompteRendu.TabIndex = 2;
            this.AjouterCompteRendu.Text = "Ajouter un Compte Rendu";
            this.AjouterCompteRendu.UseVisualStyleBackColor = false;
            this.AjouterCompteRendu.Click += new System.EventHandler(this.AjouterCompteRendu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chemin du fichier : ";
            // 
            // textBoxfichier
            // 
            this.textBoxfichier.Location = new System.Drawing.Point(310, 423);
            this.textBoxfichier.Name = "textBoxfichier";
            this.textBoxfichier.Size = new System.Drawing.Size(339, 22);
            this.textBoxfichier.TabIndex = 4;
            // 
            // EnregistrerCompteRendu
            // 
            this.EnregistrerCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnregistrerCompteRendu.Location = new System.Drawing.Point(671, 301);
            this.EnregistrerCompteRendu.Name = "EnregistrerCompteRendu";
            this.EnregistrerCompteRendu.Size = new System.Drawing.Size(158, 54);
            this.EnregistrerCompteRendu.TabIndex = 5;
            this.EnregistrerCompteRendu.Text = "Enregistrer";
            this.EnregistrerCompteRendu.UseVisualStyleBackColor = true;
            this.EnregistrerCompteRendu.Click += new System.EventHandler(this.EnregistrerCompteRendu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1257, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Réunion Choisie :";
            // 
            // textBoxReunion
            // 
            this.textBoxReunion.Location = new System.Drawing.Point(1446, 301);
            this.textBoxReunion.Name = "textBoxReunion";
            this.textBoxReunion.Size = new System.Drawing.Size(124, 22);
            this.textBoxReunion.TabIndex = 7;
            // 
            // ReunionParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.textBoxReunion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnregistrerCompteRendu);
            this.Controls.Add(this.textBoxfichier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AjouterCompteRendu);
            this.Controls.Add(this.DataGridReunion);
            this.Controls.Add(this.panel1);
            this.Name = "ReunionParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reunion Des Participants";
            this.Load += new System.EventHandler(this.ReunionParticipant_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridReunion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataGridReunion;
        private System.Windows.Forms.Button AjouterCompteRendu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfichier;
        private System.Windows.Forms.Button EnregistrerCompteRendu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateHeure;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReunion;
        private System.Windows.Forms.Button button3;
    }
}