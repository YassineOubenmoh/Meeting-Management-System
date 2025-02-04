using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GestionDesReunions
{
    public partial class BoiteDeReception : Form
    {

        private string connectionString = "server=localhost;database=gestionreunion;uid=root;password=;";
        public BoiteDeReception()
        {
            InitializeComponent();

            LoadInfos();
            LoadLastNotification();
            DisplayUserName();

            DataGridNotif.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridNotif.MultiSelect = false;
            DataGridNotif.CellClick += new DataGridViewCellEventHandler(DataGridNotif_CellClick);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void DataGridNotif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridNotif.Rows[e.RowIndex];

                // Assuming the column names are correct
                textBoxReunion.Text = row.Cells["Reunion"].Value?.ToString();

            }
        }

        private void LoadInfos()
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
                        salle.Nom 
                    FROM 
                        participation
                        INNER JOIN réunion ON participation.id_reunion = réunion.id_reunion
                        INNER JOIN salle ON salle.id_salle = réunion.id_salle
                    WHERE 
                        participation.id_utilisateur = @IdUtilisateur";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataGridNotif.DataSource = dataTable;

                        // Auto resize columns
                        DataGridNotif.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridNotif.AutoResizeColumns();

                        // Set the font for the column headers
                        DataGridNotif.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                        // Set alternate row colors
                        DataGridNotif.RowsDefaultCellStyle.BackColor = Color.LightGray;
                        DataGridNotif.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DisplayUserName()
        {
            this.label7.Text = "Bonjour " + UserSession.UserName;
        }

        private void BoiteDeReception_Load(object sender, EventArgs e)
        {

        }

        private void LoadLastNotification()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Sujet Label
                    string sqlSujet = "SELECT Sujet FROM réunion INNER JOIN notificationparticipation ON réunion.id_reunion = notificationparticipation.id_reunion WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdSujet = new MySqlCommand(sqlSujet, conn);
                    cmdSujet.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultSujet = cmdSujet.ExecuteScalar();
                    if (resultSujet != null)
                    {
                        string sujet = resultSujet.ToString();
                        SujetLabel.Text = sujet;
                    }

                    // Salle Label
                    string sqlSalle = "SELECT Nom FROM salle INNER JOIN réunion ON réunion.id_salle = salle.id_salle INNER JOIN notificationparticipation ON réunion.id_reunion = notificationparticipation.id_reunion WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdSalle = new MySqlCommand(sqlSalle, conn);
                    cmdSalle.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultSalle = cmdSalle.ExecuteScalar();
                    if (resultSalle != null)
                    {
                        string salle = resultSalle.ToString();
                        SalleLabel.Text = salle;
                    }

                    // Debut Label
                    string sqlDebut = "SELECT DateHeureDebut FROM réunion INNER JOIN notificationparticipation ON réunion.id_reunion = notificationparticipation.id_reunion WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdDebut = new MySqlCommand(sqlDebut, conn);
                    cmdDebut.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultDebut = cmdDebut.ExecuteScalar();
                    if (resultDebut != null)
                    {
                        string debut = resultDebut.ToString();
                        DebutLabel.Text = debut;
                    }

                    // Fin Label
                    string sqlFin = "SELECT DateHeureFin FROM réunion INNER JOIN notificationparticipation ON réunion.id_reunion = notificationparticipation.id_reunion WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdFin = new MySqlCommand(sqlFin, conn);
                    cmdFin.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultFin = cmdFin.ExecuteScalar();
                    if (resultFin != null)
                    {
                        string fin = resultFin.ToString();
                        FinLabel.Text = fin;
                    }

                    // Chef  Label
                    string sqlChef = "SELECT full_name FROM utilisateur INNER JOIN réunion ON réunion.id_chefequipe = utilisateur.id_utilisateur INNER JOIN notificationparticipation ON réunion.id_reunion = notificationparticipation.id_reunion WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdChef = new MySqlCommand(sqlChef, conn);
                    cmdChef.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultChef = cmdChef.ExecuteScalar();
                    if (resultChef != null)
                    {
                        string Chef = resultChef.ToString();
                        ChefLabel.Text = "Envoyé par : " + Chef;
                    }

                    // envoi  Label
                    string sqlenvoi = "SELECT date_envoi FROM notificationparticipation WHERE notificationparticipation.id_participant = @IdUtilisateur ORDER BY notificationparticipation.id_notification DESC LIMIT 1";
                    MySqlCommand cmdenvoi = new MySqlCommand(sqlenvoi, conn);
                    cmdenvoi.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultenvoi = cmdenvoi.ExecuteScalar();
                    if (resultenvoi != null)
                    {
                        string envoi= resultenvoi.ToString();
                        EnvoiLabel.Text = "le : " + envoi;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string idreunion = textBoxReunion.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verify if the IdReunin exists in the 'réunion' table
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

                    string presence = comboBoxPresence.SelectedItem.ToString();
                    string justification = richTextBoxJustification.Text;

                    if (presence == "Non" && string.IsNullOrEmpty(justification))
                    {
                        MessageBox.Show("Veuillez fournir une justification pour l'absence.");
                        return;
                    }

                    // Update the participation table only if the fields are NULL
                    string query = "UPDATE participation SET présence = IF(présence IS NULL, @presence, présence), justificationAbsence = IF(justificationAbsence IS NULL, @justification, justificationAbsence) WHERE id_reunion = @id_reunion";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_reunion", idreunion);
                        command.Parameters.AddWithValue("@presence", presence);
                        command.Parameters.AddWithValue("@justification", justification);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Modifications faites avec succès !");
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

        private void button4_Click(object sender, EventArgs e)
        {
            PageAcceuil page7 = new PageAcceuil();
            page7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReunionParticipant reunion = new ReunionParticipant();
            reunion.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoiteDeReception boiteReception = new BoiteDeReception();
            boiteReception.Show();
            this.Hide();
        }
    }
}
