using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionDesReunions
{
    public partial class CompteRenduChef : Form
    {
        private string connectionString = "server=localhost;database=gestionreunion;uid=root;password=;";
        private byte[] fileBytes;

        public CompteRenduChef()
        {
            InitializeComponent();

            DataGridCompte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridCompte.MultiSelect = false;
            DataGridCompte.CellClick += new DataGridViewCellEventHandler(DataGridReunion_CellClick);

        }


        private void DataGridReunion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridCompte.Rows[e.RowIndex];

                // Assuming the column names are correct
                textBoxReunion.Text = row.Cells["ID"].Value?.ToString();

            }
        }

        private void CompteRenduChef_Load(object sender, EventArgs e)
        {
            LoadReunions();
        }

        private void LoadReunions()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT 
                        id_reunion, 
                        full_name, 
                        Sujet, 
                        DateHeureDebut,
                        DateHeureFin,
                        Etat_Reunion, 
                        salle.Nom 
                    FROM 
                        réunion 
                        INNER JOIN utilisateur ON réunion.id_chefequipe = utilisateur.id_utilisateur 
                        INNER JOIN salle ON salle.id_salle = réunion.id_salle 
                    WHERE 
                        Etat_Reunion = 'Terminée' AND 
                        id_chefequipe = @IdUtilisateur";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataGridCompte.DataSource = dataTable;

                        // Auto resize columns
                        DataGridCompte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridCompte.AutoResizeColumns();

                        // Set the font for the column headers
                        DataGridCompte.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                        // Set alternate row colors
                        DataGridCompte.RowsDefaultCellStyle.BackColor = Color.LightGray;
                        DataGridCompte.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
         
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

           
        }

        

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void fichierTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uploadButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.SafeFileName;
                string filePath = openFileDialog.FileName;

                textBoxfichier.Text = fileName;
                fileBytes = File.ReadAllBytes(filePath);
            }
        }




        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string idreunion = textBoxReunion.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verify if the IdReunion exists in the 'réunion' table
                    string checkQuery = "SELECT COUNT(*) FROM réunion WHERE id_reunion = @id_reunion";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id_reunion", idreunion);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("The specified réunion ID does not exist.");
                            return;
                        }
                    }

                    // Update the participation table only if the fields are NULL
                    string query = "INSERT INTO compterendu (id_reunion, fichierChemin, fichier) VALUES (@id_reunion, @fichierChemin, @fichier)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_reunion", idreunion);
                        command.Parameters.AddWithValue("@fichierChemin", textBoxfichier.Text);
                        command.Parameters.AddWithValue("@fichier", fileBytes);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Nouveau compte rendu a été inséré !");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. The fields might not be NULL.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DataGridCompte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BoiteDeReceptionChefProjet boitechef = new BoiteDeReceptionChefProjet();
            boitechef.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageAcceuil page5 = new PageAcceuil();
            page5.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelConnected bord4 = new labelConnected();


            bord4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterUneReunion ajoutReunion = new AjouterUneReunion();
            ajoutReunion.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalleReunion salle = new SalleReunion();
            salle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CompteRenduChef compte7 = new CompteRenduChef();
            compte7.Show();
            this.Hide();
        }
    }
}

