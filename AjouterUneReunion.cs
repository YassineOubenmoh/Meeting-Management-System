using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDesReunions {

 
    public partial class AjouterUneReunion : Form
    {


        string connectionString = "server=localhost;database=gestionreunion;user=root;password='';";
        public AjouterUneReunion()
        {
            InitializeComponent();

            LoadMaterielComboBox();
            LoadSalleComboBox();

            DisplayUserName();

            // Add the event handlers
            dateTimePickerDebut.ValueChanged += new EventHandler(dateTimePicker_ValueChanged);
            dateTimePickerFin.ValueChanged += new EventHandler(dateTimePicker_ValueChanged);

            // Initial load
            LoadData();
            LoadListBox();

            // Configure the DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;


           
            // Load data from the database into the DataGridView


            // Add CellClick event handler
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            listBox1.SelectionMode = SelectionMode.MultiExtended;



        }


        

        private void DisplayUserName()
        {
            this.labelConnected.Text = "Bonjour " + UserSession.UserName;
        }


        // Ajouter un combo box pour les materiels
        private void LoadMaterielComboBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    NomMateriel,
                    id_matériel
                FROM 
                    matériel 
                WHERE 
                    id_matériel NOT IN (
                        SELECT 
                            id_matériel 
                        FROM 
                            réservationmatériel 
                        INNER JOIN 
                            réunion 
                        ON 
                            réunion.id_reunion = réservationmatériel.id_réunion 
                        WHERE 
                            @DateHeureDebut BETWEEN DateHeureDebut AND DateHeureFin
                            OR 
                            @DateHeureFin BETWEEN DateHeureDebut AND DateHeureFin
                            OR 
                            DateHeureDebut BETWEEN @DateHeureDebut AND @DateHeureFin
                            OR 
                            DateHeureFin BETWEEN @DateHeureDebut AND @DateHeureFin
                    )";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DateHeureDebut", dateTimePickerDebut.Value);
                    cmd.Parameters.AddWithValue("@DateHeureFin", dateTimePickerFin.Value);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        comboBox1.DataSource = dt;
                        comboBox1.DisplayMember = "NomMateriel";
                        comboBox1.ValueMember = "id_matériel";
                    }
                    else
                    {
                        MessageBox.Show("No available materials for the selected time range.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading materials: " + ex.Message);
                }
            }
        }




        //Ajouter un combobox pour les salles
        private void LoadSalleComboBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"
            SELECT Nom, id_salle 
            FROM salle 
            WHERE id_salle NOT IN (
                SELECT id_salle 
                FROM réunion 
                WHERE (@DateHeureDebut BETWEEN DateHeureDebut AND DateHeureFin) 
                   OR (@DateHeureFin BETWEEN DateHeureDebut AND DateHeureFin)
                   OR (DateHeureDebut BETWEEN @DateHeureDebut AND @DateHeureFin)
                   OR (DateHeureFin BETWEEN @DateHeureDebut AND @DateHeureFin)
            )";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DateHeureDebut", dateTimePickerDebut.Value);
                    cmd.Parameters.AddWithValue("@DateHeureFin", dateTimePickerFin.Value);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    SalleCombo.DataSource = dt;
                    SalleCombo.DisplayMember = "Nom";
                    SalleCombo.ValueMember = "id_salle";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
            }
        }

        // Event handler for the DateTimePicker value changed event
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadSalleComboBox();
            LoadMaterielComboBox();
            LoadListBox();
        }




        private void LoadData()
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {

        }



        private void LoadListBox()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT CONCAT(utilisateur.nom, ' ', utilisateur.Prénom) AS full_name 
                           FROM utilisateur
                           LEFT JOIN participation ON utilisateur.id_utilisateur = participation.id_utilisateur
                           LEFT JOIN réunion ON participation.id_reunion = réunion.id_reunion 
                                AND ((@DateHeureDebut BETWEEN réunion.DateHeureDebut AND réunion.DateHeureFin) 
                                OR (@DateHeureFin BETWEEN réunion.DateHeureDebut AND réunion.DateHeureFin) 
                                OR (réunion.DateHeureDebut BETWEEN @DateHeureDebut AND @DateHeureFin) 
                                OR (réunion.DateHeureFin BETWEEN @DateHeureDebut AND @DateHeureFin))
                           WHERE (participation.id_utilisateur IS NULL
                              OR réunion.id_reunion IS NULL)
                             AND utilisateur.Profil = 'Participant'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@DateHeureDebut", dateTimePickerDebut.Value);
                    cmd.Parameters.AddWithValue("@DateHeureFin", dateTimePickerFin.Value);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    listBox1.DataSource = dt;
                    listBox1.DisplayMember = "full_name";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading list box: " + ex.Message);
                }





               
            }
        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Assuming the column names are correct
                textBoxSujet.Text = row.Cells["Sujet"].Value?.ToString();
                textBoxIdChefEquipe.Text = row.Cells["ChefProjet"].Value?.ToString();
                dateTimePickerDebut.Value = row.Cells["HeureDebut"].Value != null ? Convert.ToDateTime(row.Cells["HeureDebut"].Value) : DateTime.MinValue;
                dateTimePickerFin.Value = row.Cells["HeureFin"].Value != null ? Convert.ToDateTime(row.Cells["HeureFin"].Value) : DateTime.MinValue;

                // Populate materiel ComboBox
                string materielName = row.Cells["Materiel"].Value?.ToString();
                if (!string.IsNullOrEmpty(materielName))
                {
                    DataRowView materielItem = comboBox1.Items.Cast<DataRowView>()
                                               .FirstOrDefault(item => item["NomMateriel"].ToString() == materielName);
                    if (materielItem != null)
                    {
                        comboBox1.SelectedItem = materielItem;
                    }
                    else
                    {
                        // If the materiel from the DataGridView row is not found in the ComboBox items
                        MessageBox.Show($"Materiel '{materielName}' not found in the ComboBox items.");
                    }
                }

                // Populate salle ComboBox
                string salleName = row.Cells["Salle"].Value?.ToString();
                if (!string.IsNullOrEmpty(salleName))
                {
                    DataRowView salleItem = SalleCombo.Items.Cast<DataRowView>()
                                            .FirstOrDefault(item => item["Nom"].ToString() == salleName);
                    if (salleItem != null)
                    {
                        SalleCombo.SelectedItem = salleItem;
                    }
                    else
                    {
                        // If the salle from the DataGridView row is not found in the ComboBox items
                        MessageBox.Show($"Salle '{salleName}' not found in the ComboBox items.");
                    }
                }
            }
        }









        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Get the current date and time
                    DateTime currentDateTime = DateTime.Now;

                    // Get the selected start and end dates from the DateTimePickers
                    DateTime selectedStartDateTime = dateTimePickerDebut.Value;
                    DateTime selectedEndDateTime = dateTimePickerFin.Value;

                    // Check if the selected start or end dates are in the past
                    if (selectedStartDateTime < currentDateTime || selectedEndDateTime < currentDateTime)
                    {
                        MessageBox.Show("Il est impossible de programmer une réunion au passé !");
                        return; // Exit the method
                    }

                    conn.Open();

                    // Calculate TotalSelectedItem
                    int TotalSelectedItem = listBox1.SelectedItems.Count;

                    // Fetch the Capacité from the salle table
                    string capacityQuery = "SELECT Capacité FROM salle WHERE id_salle = @id_salle";
                    MySqlCommand capacityCmd = new MySqlCommand(capacityQuery, conn);
                    capacityCmd.Parameters.AddWithValue("@id_salle", SalleCombo.SelectedValue);

                    int capacité = Convert.ToInt32(capacityCmd.ExecuteScalar());

                    if (TotalSelectedItem > capacité)
                    {
                        throw new Exception("Il n y à pas assez de place dans cette salle !");
                    }

                    // Check if the same data already exists
                    string checkQuery = "SELECT COUNT(*) FROM réunion WHERE Sujet = @Sujet AND DateHeureDebut = @DateHeureDebut AND DateHeureFin = @DateHeureFin AND id_chefequipe = @id_chefequipe AND id_salle = @id_salle";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Sujet", textBoxSujet.Text);
                    checkCmd.Parameters.AddWithValue("@DateHeureDebut", dateTimePickerDebut.Value);
                    checkCmd.Parameters.AddWithValue("@DateHeureFin", dateTimePickerFin.Value);
                    checkCmd.Parameters.AddWithValue("@id_chefequipe", textBoxIdChefEquipe.Text);
                    checkCmd.Parameters.AddWithValue("@id_salle", SalleCombo.SelectedValue);

                    int existingRows = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existingRows > 0)
                    {
                        MessageBox.Show("This data already exists in the database.");
                    }
                    else
                    {
                        // Proceed with insertion
                        string sql = "INSERT INTO réunion (Sujet, DateHeureDebut, DateHeureFin, id_chefequipe, id_salle) VALUES (@Sujet, @DateHeureDebut, @DateHeureFin, @id_chefequipe, @id_salle)";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Sujet", textBoxSujet.Text);
                        cmd.Parameters.AddWithValue("@DateHeureDebut", dateTimePickerDebut.Value);
                        cmd.Parameters.AddWithValue("@DateHeureFin", dateTimePickerFin.Value);
                        cmd.Parameters.AddWithValue("@id_chefequipe", textBoxIdChefEquipe.Text);
                        cmd.Parameters.AddWithValue("@id_salle", SalleCombo.SelectedValue);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            long lastInsertId = cmd.LastInsertedId;

                            // Insert into réservationmatériel table
                            string sqlQuery = "INSERT INTO réservationmatériel (id_matériel, id_réunion) VALUES (@id_matériel, @id_réunion)";
                            MySqlCommand cmd2 = new MySqlCommand(sqlQuery, conn);
                            cmd2.Parameters.AddWithValue("@id_matériel", comboBox1.SelectedValue);
                            cmd2.Parameters.AddWithValue("@id_réunion", lastInsertId);

                            cmd2.ExecuteNonQuery();

                            // Insert into participation table
                            foreach (var selectedItem in listBox1.SelectedItems)
                            {
                                try
                                {
                                    // Assuming the selected item represents the full name directly
                                    DataRowView rowView = (DataRowView)selectedItem;
                                    string fullName = rowView["full_name"].ToString();

                                    // Assuming 'utilisateur' table has a 'full_name' column and an 'id_utilisateur' primary key
                                    string userQuery = "SELECT id_utilisateur FROM utilisateur WHERE full_name = @fullName";
                                    MySqlCommand userCmd = new MySqlCommand(userQuery, conn);
                                    userCmd.Parameters.AddWithValue("@fullName", fullName);

                                    object userIdObj = userCmd.ExecuteScalar();
                                    if (userIdObj != null)
                                    {
                                        int userId = Convert.ToInt32(userIdObj);

                                        // Insert user participation
                                        string participationQuery = "INSERT INTO participation (id_utilisateur, id_reunion) VALUES (@userId, @lastInsertId)";
                                        MySqlCommand participationCmd = new MySqlCommand(participationQuery, conn);
                                        participationCmd.Parameters.AddWithValue("@userId", userId);
                                        participationCmd.Parameters.AddWithValue("@lastInsertId", lastInsertId);

                                        participationCmd.ExecuteNonQuery();

                                        string notificationQuery = "INSERT INTO notificationparticipation (id_participant, id_reunion) VALUES (@userId, @lastInsertId)";
                                        MySqlCommand notificationCmd = new MySqlCommand(notificationQuery, conn);
                                        notificationCmd.Parameters.AddWithValue("@userId", userId);
                                        notificationCmd.Parameters.AddWithValue("@lastInsertId", lastInsertId);

                                        notificationCmd.ExecuteNonQuery();
                                    }
                                    else
                                    {
                                        MessageBox.Show("User not found for: " + fullName);
                                        // Handle the case where a user is not found in the database.
                                        // You might want to log this or take other appropriate action.
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error inserting participant: " + ex.Message);
                                    // Handle the exception accordingly. You might want to log this.
                                }
                            }

                        }

                        MessageBox.Show("Record Added");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue; // Change font color to blue on hover
            }
        }

        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.Black; // Revert font color to black when mouse leaves row
            }
        }



        private void textBoxSujet_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdSalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AjouterUneReunion_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonTerminees_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT id_reunion, Sujet, DateHeureDebut, DateHeureFin, salle.Nom, Etat_Reunion, matériel.NomMateriel, id_chefequipe FROM réunion INNER JOIN réservationmatériel ON réunion.id_reunion = réservationmatériel.id_réunion INNER JOIN matériel ON matériel.id_matériel = réservationmatériel.id_matériel INNER JOIN salle ON réunion.id_salle = salle.id_salle WHERE Etat_Reunion = 'Terminée'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Assuming dataGridViewReunions is the name of your DataGridView control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed meetings: " + ex.Message);
                }
            }
        }

        private void buttonProgrammees_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_reunion, Sujet, DateHeureDebut, DateHeureFin, salle.Nom, Etat_Reunion, matériel.NomMateriel, id_chefequipe FROM réunion INNER JOIN réservationmatériel ON réunion.id_reunion = réservationmatériel.id_réunion INNER JOIN matériel ON matériel.id_matériel = réservationmatériel.id_matériel INNER JOIN salle ON réunion.id_salle = salle.id_salle WHERE Etat_Reunion = 'Programmée'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Assuming dataGridViewReunions is the name of your DataGridView control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed meetings: " + ex.Message);
                }
            }
        }

        private void buttonReunions_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_reunion, Sujet, DateHeureDebut, DateHeureFin, salle.Nom, Etat_Reunion, matériel.NomMateriel, id_chefequipe FROM réunion INNER JOIN réservationmatériel ON réunion.id_reunion = réservationmatériel.id_réunion INNER JOIN matériel ON matériel.id_matériel = réservationmatériel.id_matériel INNER JOIN salle ON réunion.id_salle = salle.id_salle";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt; // Assuming dataGridViewReunions is the name of your DataGridView control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading completed meetings: " + ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Create an instance of the LoginChefDeProjet form
            SalleReunion salle = new SalleReunion();

            // Show the LoginChefDeProjet form
            salle.Show();
        }

        private void textBoxIdChefEquipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelConnected bord1 = new labelConnected();


            bord1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterUneReunion ReunionForm1 = new AjouterUneReunion();


            ReunionForm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompteRenduChef compte3 = new CompteRenduChef();
            compte3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BoiteDeReceptionChefProjet boiteChef = new BoiteDeReceptionChefProjet();
            boiteChef.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageAcceuil page8 = new PageAcceuil();
            page8.Show();
            this.Hide();
        }
    }
}