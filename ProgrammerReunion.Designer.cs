namespace GestionDesReunions
{
    partial class ProgrammerReunion
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
            this.TableauDeBord = new System.Windows.Forms.Button();
            this.Salle = new System.Windows.Forms.Button();
            this.Materiel = new System.Windows.Forms.Button();
            this.Reunion = new System.Windows.Forms.Button();
            this.CompteRendu = new System.Windows.Forms.Button();
            this.ParticipantDisponibles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Participant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableauDeBord
            // 
            this.TableauDeBord.Location = new System.Drawing.Point(0, 128);
            this.TableauDeBord.Name = "TableauDeBord";
            this.TableauDeBord.Size = new System.Drawing.Size(201, 58);
            this.TableauDeBord.TabIndex = 0;
            this.TableauDeBord.Text = "Tableau de Bord";
            this.TableauDeBord.UseVisualStyleBackColor = true;
            // 
            // Salle
            // 
            this.Salle.Location = new System.Drawing.Point(0, 192);
            this.Salle.Name = "Salle";
            this.Salle.Size = new System.Drawing.Size(201, 58);
            this.Salle.TabIndex = 1;
            this.Salle.Text = "Salle";
            this.Salle.UseVisualStyleBackColor = true;
            // 
            // Materiel
            // 
            this.Materiel.Location = new System.Drawing.Point(0, 256);
            this.Materiel.Name = "Materiel";
            this.Materiel.Size = new System.Drawing.Size(201, 58);
            this.Materiel.TabIndex = 2;
            this.Materiel.Text = "Materiel";
            this.Materiel.UseVisualStyleBackColor = true;
            // 
            // Reunion
            // 
            this.Reunion.Location = new System.Drawing.Point(0, 320);
            this.Reunion.Name = "Reunion";
            this.Reunion.Size = new System.Drawing.Size(201, 58);
            this.Reunion.TabIndex = 3;
            this.Reunion.Text = "Reunion";
            this.Reunion.UseVisualStyleBackColor = true;
            // 
            // CompteRendu
            // 
            this.CompteRendu.Location = new System.Drawing.Point(0, 384);
            this.CompteRendu.Name = "CompteRendu";
            this.CompteRendu.Size = new System.Drawing.Size(201, 58);
            this.CompteRendu.TabIndex = 4;
            this.CompteRendu.Text = "Compte Rendu";
            this.CompteRendu.UseVisualStyleBackColor = true;
            // 
            // ParticipantDisponibles
            // 
            this.ParticipantDisponibles.Location = new System.Drawing.Point(251, 22);
            this.ParticipantDisponibles.Name = "ParticipantDisponibles";
            this.ParticipantDisponibles.Size = new System.Drawing.Size(177, 49);
            this.ParticipantDisponibles.TabIndex = 5;
            this.ParticipantDisponibles.Text = "Les participants Disponibles";
            this.ParticipantDisponibles.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Participant,
            this.Nom,
            this.Prénom,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(251, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 257);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Participant
            // 
            this.Id_Participant.HeaderText = "ID";
            this.Id_Participant.MinimumWidth = 6;
            this.Id_Participant.Name = "Id_Participant";
            this.Id_Participant.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.MinimumWidth = 6;
            this.Prénom.Name = "Prénom";
            this.Prénom.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter une Reunion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgrammerReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ParticipantDisponibles);
            this.Controls.Add(this.CompteRendu);
            this.Controls.Add(this.Reunion);
            this.Controls.Add(this.Materiel);
            this.Controls.Add(this.Salle);
            this.Controls.Add(this.TableauDeBord);
            this.Name = "ProgrammerReunion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TableauDeBord;
        private System.Windows.Forms.Button Salle;
        private System.Windows.Forms.Button Materiel;
        private System.Windows.Forms.Button Reunion;
        private System.Windows.Forms.Button CompteRendu;
        private System.Windows.Forms.Button ParticipantDisponibles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Participant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button button1;
    }
}