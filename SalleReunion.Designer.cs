namespace GestionDesReunions
{
    partial class SalleReunion
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
            this.labelConnect = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridSalle = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.GridMateriel = new System.Windows.Forms.DataGridView();
            this.IdMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materiel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionMateriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.NomSalleTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CapaciteSalleTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaterielTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextArea = new System.Windows.Forms.RichTextBox();
            this.AjouterSalle = new System.Windows.Forms.Button();
            this.ModifierSalle = new System.Windows.Forms.Button();
            this.AjouterMateriel = new System.Windows.Forms.Button();
            this.ModifierMateriel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMateriel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.labelConnect);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 779);
            this.panel1.TabIndex = 0;
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConnect.Location = new System.Drawing.Point(16, 11);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(85, 29);
            this.labelConnect.TabIndex = 6;
            this.labelConnect.Text = "label7";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(-1, 538);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(305, 58);
            this.button6.TabIndex = 5;
            this.button6.Text = "Boite de Réception";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(305, 58);
            this.button5.TabIndex = 4;
            this.button5.Text = "Compte Rendus";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salles | Matériel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 58);
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
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tableau de Bord";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salles :";
            // 
            // GridSalle
            // 
            this.GridSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomSalle,
            this.Capacite});
            this.GridSalle.Location = new System.Drawing.Point(311, 58);
            this.GridSalle.Name = "GridSalle";
            this.GridSalle.RowHeadersWidth = 51;
            this.GridSalle.RowTemplate.Height = 24;
            this.GridSalle.Size = new System.Drawing.Size(626, 269);
            this.GridSalle.TabIndex = 2;
            this.GridSalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridSalle_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_salle";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 208;
            // 
            // NomSalle
            // 
            this.NomSalle.DataPropertyName = "Nom";
            this.NomSalle.HeaderText = "Nom de Salle";
            this.NomSalle.MinimumWidth = 6;
            this.NomSalle.Name = "NomSalle";
            this.NomSalle.Width = 200;
            // 
            // Capacite
            // 
            this.Capacite.DataPropertyName = "Capacité";
            this.Capacite.HeaderText = "Capacité";
            this.Capacite.MinimumWidth = 6;
            this.Capacite.Name = "Capacite";
            this.Capacite.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matériel : ";
            // 
            // GridMateriel
            // 
            this.GridMateriel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMateriel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMateriel,
            this.Materiel,
            this.DescriptionMateriel});
            this.GridMateriel.Location = new System.Drawing.Point(311, 406);
            this.GridMateriel.Name = "GridMateriel";
            this.GridMateriel.RowHeadersWidth = 51;
            this.GridMateriel.RowTemplate.Height = 24;
            this.GridMateriel.Size = new System.Drawing.Size(626, 268);
            this.GridMateriel.TabIndex = 4;
            // 
            // IdMateriel
            // 
            this.IdMateriel.DataPropertyName = "id_matériel";
            this.IdMateriel.HeaderText = "ID";
            this.IdMateriel.MinimumWidth = 6;
            this.IdMateriel.Name = "IdMateriel";
            this.IdMateriel.Width = 200;
            // 
            // Materiel
            // 
            this.Materiel.DataPropertyName = "NomMateriel";
            this.Materiel.HeaderText = "Nom du Matériel";
            this.Materiel.MinimumWidth = 6;
            this.Materiel.Name = "Materiel";
            this.Materiel.Width = 200;
            // 
            // DescriptionMateriel
            // 
            this.DescriptionMateriel.DataPropertyName = "Description";
            this.DescriptionMateriel.HeaderText = "Description du Matériel";
            this.DescriptionMateriel.MinimumWidth = 6;
            this.DescriptionMateriel.Name = "DescriptionMateriel";
            this.DescriptionMateriel.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(976, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom de Salle :";
            // 
            // NomSalleTextBox
            // 
            this.NomSalleTextBox.Location = new System.Drawing.Point(1149, 112);
            this.NomSalleTextBox.Name = "NomSalleTextBox";
            this.NomSalleTextBox.Size = new System.Drawing.Size(183, 22);
            this.NomSalleTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(976, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacité :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(968, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nom de Matériel :";
            // 
            // CapaciteSalleTextBox
            // 
            this.CapaciteSalleTextBox.Location = new System.Drawing.Point(1149, 179);
            this.CapaciteSalleTextBox.Name = "CapaciteSalleTextBox";
            this.CapaciteSalleTextBox.Size = new System.Drawing.Size(183, 22);
            this.CapaciteSalleTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(968, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description du Matériel :";
            // 
            // MaterielTextBox
            // 
            this.MaterielTextBox.Location = new System.Drawing.Point(1222, 409);
            this.MaterielTextBox.Name = "MaterielTextBox";
            this.MaterielTextBox.Size = new System.Drawing.Size(258, 22);
            this.MaterielTextBox.TabIndex = 11;
            // 
            // DescriptionTextArea
            // 
            this.DescriptionTextArea.Location = new System.Drawing.Point(1222, 467);
            this.DescriptionTextArea.Name = "DescriptionTextArea";
            this.DescriptionTextArea.Size = new System.Drawing.Size(258, 96);
            this.DescriptionTextArea.TabIndex = 12;
            this.DescriptionTextArea.Text = "";
            // 
            // AjouterSalle
            // 
            this.AjouterSalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.AjouterSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterSalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AjouterSalle.Location = new System.Drawing.Point(1076, 234);
            this.AjouterSalle.Name = "AjouterSalle";
            this.AjouterSalle.Size = new System.Drawing.Size(126, 52);
            this.AjouterSalle.TabIndex = 13;
            this.AjouterSalle.Text = "Ajouter";
            this.AjouterSalle.UseVisualStyleBackColor = false;
            this.AjouterSalle.Click += new System.EventHandler(this.AjouterSalle_Click);
            // 
            // ModifierSalle
            // 
            this.ModifierSalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.ModifierSalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierSalle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModifierSalle.Location = new System.Drawing.Point(1208, 234);
            this.ModifierSalle.Name = "ModifierSalle";
            this.ModifierSalle.Size = new System.Drawing.Size(124, 52);
            this.ModifierSalle.TabIndex = 14;
            this.ModifierSalle.Text = "Modifier";
            this.ModifierSalle.UseVisualStyleBackColor = false;
            this.ModifierSalle.Click += new System.EventHandler(this.ModifierSalle_Click);
            // 
            // AjouterMateriel
            // 
            this.AjouterMateriel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.AjouterMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterMateriel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AjouterMateriel.Location = new System.Drawing.Point(1222, 590);
            this.AjouterMateriel.Name = "AjouterMateriel";
            this.AjouterMateriel.Size = new System.Drawing.Size(126, 52);
            this.AjouterMateriel.TabIndex = 15;
            this.AjouterMateriel.Text = "Ajouter";
            this.AjouterMateriel.UseVisualStyleBackColor = false;
            this.AjouterMateriel.Click += new System.EventHandler(this.AjouterMateriel_Click);
            // 
            // ModifierMateriel
            // 
            this.ModifierMateriel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.ModifierMateriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierMateriel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModifierMateriel.Location = new System.Drawing.Point(1354, 590);
            this.ModifierMateriel.Name = "ModifierMateriel";
            this.ModifierMateriel.Size = new System.Drawing.Size(126, 52);
            this.ModifierMateriel.TabIndex = 16;
            this.ModifierMateriel.Text = "Modifier";
            this.ModifierMateriel.UseVisualStyleBackColor = false;
            this.ModifierMateriel.Click += new System.EventHandler(this.ModifierMateriel_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(202, 711);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SalleReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1539, 760);
            this.Controls.Add(this.ModifierMateriel);
            this.Controls.Add(this.AjouterMateriel);
            this.Controls.Add(this.ModifierSalle);
            this.Controls.Add(this.AjouterSalle);
            this.Controls.Add(this.DescriptionTextArea);
            this.Controls.Add(this.MaterielTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CapaciteSalleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomSalleTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridMateriel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridSalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SalleReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salles";
            this.Load += new System.EventHandler(this.SalleReunion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMateriel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridSalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridMateriel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomSalleTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CapaciteSalleTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MaterielTextBox;
        private System.Windows.Forms.RichTextBox DescriptionTextArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacite;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateriel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionMateriel;
        private System.Windows.Forms.Button AjouterSalle;
        private System.Windows.Forms.Button ModifierSalle;
        private System.Windows.Forms.Button AjouterMateriel;
        private System.Windows.Forms.Button ModifierMateriel;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Button button4;
    }
}