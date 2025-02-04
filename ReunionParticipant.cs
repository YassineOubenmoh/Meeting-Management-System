using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GestionDesReunions
{


    public partial class ReunionParticipant : Form
    {
        string connectionString = "server=localhost;database=gestionreunion;user=root;password='';";
        private byte[] fileBytes;
    

        public ReunionParticipant()
        {
            InitializeComponent();
            LoadGrid();



            DataGridReunion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridReunion.MultiSelect = false;
            DataGridReunion.CellClick += new DataGridViewCellEventHandler(DataGridReunion_CellClick);
        }

        private void DataGridReunion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridReunion.Rows[e.RowIndex];

                // Assuming the column names are correct
                textBoxReunion.Text = row.Cells["ID"].Value?.ToString();

            }
        }


        private void LoadGrid()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
        SELECT 
            réunion.id_reunion, 
            Sujet, 
            DateHeureDebut,
            DateHeureFin,
            Etat_Reunion,
            salle.Nom 
        FROM 
            participation
            INNER JOIN réunion ON participation.id_reunion = réunion.id_reunion
            INNER JOIN salle ON salle.id_salle = réunion.id_salle
        WHERE Etat_Reunion = 'Terminée' AND
            participation.id_utilisateur = @IdUtilisateur" ;

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataGridReunion.DataSource = dataTable;

                        // Auto resize columns
                        DataGridReunion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridReunion.AutoResizeColumns();

                        // Set the font for the column headers
                        DataGridReunion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                        // Set alternate row colors
                        DataGridReunion.RowsDefaultCellStyle.BackColor = Color.LightGray;
                        DataGridReunion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void ReunionParticipant_Load(object sender, EventArgs e)
        {

        }

        private void EnregistrerCompteRendu_Click(object sender, EventArgs e)
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
                    string query = "UPDATE participation " +
                                   "SET fichierNom = @fichierChemin, fichierRapport = @fichier " +
                                   "WHERE id_reunion = @id_reunion AND (fichierNom IS NULL OR fichierRapport IS NULL)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_reunion", idreunion);
                        command.Parameters.AddWithValue("@fichierChemin", textBoxfichier.Text);
                        command.Parameters.AddWithValue("@fichier", fileBytes);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Compte rendu added successfully!");
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



        private void AjouterCompteRendu_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            BoiteDeReception boite1 = new BoiteDeReception();
            boite1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageAcceuil page3 = new PageAcceuil();
            page3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReunionParticipant reunionParticipant = new ReunionParticipant();
            reunionParticipant.Show();
            this.Hide();
        }
    }

        
 }

