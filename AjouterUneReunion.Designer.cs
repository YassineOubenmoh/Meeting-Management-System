using System.Drawing;
using System.Windows.Forms;

namespace GestionDesReunions
{
    partial class AjouterUneReunion
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeureFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EtatReunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materiel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonTerminees = new System.Windows.Forms.Button();
            this.buttonProgrammees = new System.Windows.Forms.Button();
            this.buttonReunions = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxSujet = new System.Windows.Forms.TextBox();
            this.textBoxIdChefEquipe = new System.Windows.Forms.TextBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SalleCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.labelConnected = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sujet,
            this.HeureDebut,
            this.HeureFin,
            this.Salle,
            this.EtatReunion,
            this.Materiel,
            this.ChefProjet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Beige;
            this.dataGridView1.Location = new System.Drawing.Point(306, 81);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_reunion";
            this.ID.FillWeight = 150F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Sujet
            // 
            this.Sujet.DataPropertyName = "Sujet";
            this.Sujet.HeaderText = "Sujet";
            this.Sujet.MinimumWidth = 6;
            this.Sujet.Name = "Sujet";
            // 
            // HeureDebut
            // 
            this.HeureDebut.DataPropertyName = "DateHeureDebut";
            this.HeureDebut.HeaderText = "Heure de début";
            this.HeureDebut.MinimumWidth = 6;
            this.HeureDebut.Name = "HeureDebut";
            // 
            // HeureFin
            // 
            this.HeureFin.DataPropertyName = "DateHeureFin";
            this.HeureFin.HeaderText = "Heure de Fin";
            this.HeureFin.MinimumWidth = 6;
            this.HeureFin.Name = "HeureFin";
            // 
            // Salle
            // 
            this.Salle.DataPropertyName = "Nom";
            this.Salle.HeaderText = "Salle";
            this.Salle.MinimumWidth = 6;
            this.Salle.Name = "Salle";
            // 
            // EtatReunion
            // 
            this.EtatReunion.DataPropertyName = "Etat_Reunion";
            this.EtatReunion.HeaderText = "Etat de Réunion";
            this.EtatReunion.MinimumWidth = 6;
            this.EtatReunion.Name = "EtatReunion";
            // 
            // Materiel
            // 
            this.Materiel.DataPropertyName = "NomMateriel";
            this.Materiel.HeaderText = "Matériel Réservé";
            this.Materiel.MinimumWidth = 6;
            this.Materiel.Name = "Materiel";
            // 
            // ChefProjet
            // 
            this.ChefProjet.DataPropertyName = "id_chefequipe";
            this.ChefProjet.HeaderText = "Chef de Projet";
            this.ChefProjet.MinimumWidth = 6;
            this.ChefProjet.Name = "ChefProjet";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(1309, 335);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(226, 46);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Ajouter d\'horaire";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonTerminees
            // 
            this.buttonTerminees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonTerminees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminees.ForeColor = System.Drawing.Color.Black;
            this.buttonTerminees.Location = new System.Drawing.Point(306, 21);
            this.buttonTerminees.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTerminees.Name = "buttonTerminees";
            this.buttonTerminees.Size = new System.Drawing.Size(260, 52);
            this.buttonTerminees.TabIndex = 16;
            this.buttonTerminees.Text = "Réunions Terminées";
            this.buttonTerminees.UseVisualStyleBackColor = false;
            this.buttonTerminees.Click += new System.EventHandler(this.buttonTerminees_Click);
            // 
            // buttonProgrammees
            // 
            this.buttonProgrammees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonProgrammees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgrammees.ForeColor = System.Drawing.Color.Black;
            this.buttonProgrammees.Location = new System.Drawing.Point(574, 21);
            this.buttonProgrammees.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProgrammees.Name = "buttonProgrammees";
            this.buttonProgrammees.Size = new System.Drawing.Size(280, 52);
            this.buttonProgrammees.TabIndex = 17;
            this.buttonProgrammees.Text = "Réunions Programmées";
            this.buttonProgrammees.UseVisualStyleBackColor = false;
            this.buttonProgrammees.Click += new System.EventHandler(this.buttonProgrammees_Click);
            // 
            // buttonReunions
            // 
            this.buttonReunions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonReunions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReunions.ForeColor = System.Drawing.Color.White;
            this.buttonReunions.Location = new System.Drawing.Point(862, 21);
            this.buttonReunions.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReunions.Name = "buttonReunions";
            this.buttonReunions.Size = new System.Drawing.Size(181, 52);
            this.buttonReunions.TabIndex = 18;
            this.buttonReunions.Text = "Réunions";
            this.buttonReunions.UseVisualStyleBackColor = false;
            this.buttonReunions.Click += new System.EventHandler(this.buttonReunions_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(1120, 335);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(181, 46);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxSujet
            // 
            this.textBoxSujet.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxSujet.Location = new System.Drawing.Point(306, 434);
            this.textBoxSujet.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSujet.Name = "textBoxSujet";
            this.textBoxSujet.Size = new System.Drawing.Size(300, 30);
            this.textBoxSujet.TabIndex = 3;
            this.textBoxSujet.TextChanged += new System.EventHandler(this.textBoxSujet_TextChanged);
            // 
            // textBoxIdChefEquipe
            // 
            this.textBoxIdChefEquipe.Font = new System.Drawing.Font("Arial", 12F);
            this.textBoxIdChefEquipe.Location = new System.Drawing.Point(629, 434);
            this.textBoxIdChefEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdChefEquipe.Name = "textBoxIdChefEquipe";
            this.textBoxIdChefEquipe.Size = new System.Drawing.Size(300, 30);
            this.textBoxIdChefEquipe.TabIndex = 5;
            this.textBoxIdChefEquipe.TextChanged += new System.EventHandler(this.textBoxIdChefEquipe_TextChanged);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerDebut.Font = new System.Drawing.Font("Arial", 12F);
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(954, 434);
            this.dateTimePickerDebut.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(265, 30);
            this.dateTimePickerDebut.TabIndex = 6;
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePickerFin.Font = new System.Drawing.Font("Arial", 12F);
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(1270, 434);
            this.dateTimePickerFin.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(265, 30);
            this.dateTimePickerFin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(301, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sujet :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(624, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Salles Disponibles :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(626, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chef de projet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(949, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date de début :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1265, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date de fin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(301, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Matériel Disponible :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 540);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 31);
            this.comboBox1.TabIndex = 14;
            // 
            // SalleCombo
            // 
            this.SalleCombo.DropDownWidth = 250;
            this.SalleCombo.Font = this.comboBox1.Font;
            this.SalleCombo.FormattingEnabled = true;
            this.SalleCombo.Location = new System.Drawing.Point(629, 540);
            this.SalleCombo.Name = "SalleCombo";
            this.SalleCombo.Size = new System.Drawing.Size(237, 31);
            this.SalleCombo.TabIndex = 15;
            this.SalleCombo.SelectedIndexChanged += new System.EventHandler(this.SalleCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(952, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Participants Disponibles :";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(957, 540);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 96);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.labelConnected);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.panel1.Location = new System.Drawing.Point(-9, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 779);
            this.panel1.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(203, 719);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnected.ForeColor = System.Drawing.Color.White;
            this.labelConnected.Location = new System.Drawing.Point(12, 17);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(273, 29);
            this.labelConnected.TabIndex = 6;
            this.labelConnected.Text = "Gestion Des Réunions";
            this.labelConnected.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(3, 521);
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
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(3, 414);
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
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(3, 309);
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
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(3, 211);
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
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(3, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tableau De Bord";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AjouterUneReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1582, 760);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalleCombo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFin);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.textBoxIdChefEquipe);
            this.Controls.Add(this.textBoxSujet);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonReunions);
            this.Controls.Add(this.buttonProgrammees);
            this.Controls.Add(this.buttonTerminees);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjouterUneReunion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reunion Manager";
            this.Load += new System.EventHandler(this.AjouterUneReunion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }










        //#endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonTerminees;
        private System.Windows.Forms.Button buttonProgrammees;
        private System.Windows.Forms.Button buttonReunions;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxSujet;
        private System.Windows.Forms.TextBox textBoxIdChefEquipe;
        private System.Windows.Forms.DateTimePicker dateTimePickerDebut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox SalleCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeureFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EtatReunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefProjet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private Panel panel1;
        private Button button1;
        private Label labelConnected;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}

