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

namespace GestionDesReunions
{
    public partial class BoiteDeReceptionChefProjet : Form
    {

        private string connectionString = "server=localhost;database=gestionreunion;uid=root;password=;";

        public BoiteDeReceptionChefProjet()
        {
            InitializeComponent();
            LoadLastNotificationChef();
            AbsenceLoad();



            DataGridAbsence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridAbsence.MultiSelect = false;
            DataGridAbsence.CellClick += new DataGridViewCellEventHandler(DataGridAbsence_CellClick);
        }

        private void DataGridAbsence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridAbsence.Rows[e.RowIndex];

                // Assuming the column names are correct
                textBoxMsg.Text = row.Cells["Participation"].Value?.ToString();

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelConnected tabBord2 = new labelConnected();




            tabBord2.Show();
        }



        private void AbsenceLoad()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT
                        id_participation,
                        réunion.id_reunion, 
                        utilisateur.full_name, 
                        Sujet, 
                        DateHeureDebut,
                        DateHeureFin,
                        participation.présence
                    FROM 
                        réunion 
                        INNER JOIN participation ON réunion.id_reunion = participation.id_reunion
                        INNER JOIN utilisateur ON utilisateur.id_utilisateur = participation.id_utilisateur
                    WHERE 
                        participation.présence = 'Non' AND 
                        id_chefequipe = @IdUtilisateur";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataGridAbsence.DataSource = dataTable;

                        // Auto resize columns
                        DataGridAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        DataGridAbsence.AutoResizeColumns();

                        // Set the font for the column headers
                        DataGridAbsence.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

                        // Set alternate row colors
                        DataGridAbsence.RowsDefaultCellStyle.BackColor = Color.LightGray;
                        DataGridAbsence.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void LoadLastNotificationChef()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Debut Chef

                    HelloLabel.Text = "Hello " + UserSession.UserName;



                    // Sujet Label
                    string sqlpresent = "SELECT présence FROM participation INNER JOIN réunion ON réunion.id_reunion = participation.id_reunion WHERE réunion.id_chefequipe = @IdUtilisateur ORDER BY participation.id_participation DESC LIMIT 1";
                    MySqlCommand cmdpresent = new MySqlCommand(sqlpresent, conn);
                    cmdpresent.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultpresent = cmdpresent.ExecuteScalar();
                    if (resultpresent != null)
                    {
                        string present = resultpresent.ToString();
                        if (present == "Oui")
                        {
                            presentLabel.Text = present + "Je confirme ma présence pour la réunion qui aura lieu le";
                        }
                        else if (present == "Non")
                        {
                            presentLabel.Text = present + "Je m'excuse je ne serai pas présent pour la réunion qui aura lieu le";
                        }

                    }


                    // Debut Label
                    string sqlDebut = "SELECT DateHeureDebut FROM réunion INNER JOIN participation ON réunion.id_reunion = participation.id_reunion WHERE réunion.id_chefequipe = @IdUtilisateur ORDER BY participation.id_participation DESC LIMIT 1";
                    MySqlCommand cmdDebut = new MySqlCommand(sqlDebut, conn);
                    cmdDebut.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultDebut = cmdDebut.ExecuteScalar();
                    if (resultDebut != null)
                    {
                        string debut = resultDebut.ToString();
                        labelDateDebut.Text = debut;
                    }

                    //Justification
                    string sqlJustification = "SELECT justificationAbsence FROM participation INNER JOIN réunion ON réunion.id_reunion = participation.id_reunion WHERE réunion.id_chefequipe = @IdUtilisateur ORDER BY participation.id_participation DESC LIMIT 1";
                    MySqlCommand cmdJustification = new MySqlCommand(sqlJustification, conn);
                    cmdJustification.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultJustification = cmdJustification.ExecuteScalar();
                    if (resultJustification != null)
                    {
                        string Justification = resultJustification.ToString();
                        JustificationLabel.Text = Justification;
                    }


                    //Participant
                    string sqlParticipant = "SELECT full_name FROM utilisateur INNER JOIN participation ON utilisateur.id_utilisateur = participation.id_utilisateur INNER JOIN réunion ON réunion.id_reunion = participation.id_reunion WHERE réunion.id_chefequipe = @IdUtilisateur ORDER BY participation.id_participation DESC LIMIT 1";
                    MySqlCommand cmdParticipant = new MySqlCommand(sqlParticipant, conn);
                    cmdParticipant.Parameters.AddWithValue("@IdUtilisateur", UserSession.IdUtilisateur);
                    object resultParticipant = cmdParticipant.ExecuteScalar();
                    if (resultParticipant != null)
                    {
                        string Participant = resultParticipant.ToString();
                        ParticipantLabel.Text = Participant;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




        private void BoiteDeReceptionChefProjet_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcceptJustification_Click(object sender, EventArgs e)
        {
            string idparticipation = textBoxMsg.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verify if the IdReunion exists in the 'réunion' table
                    string checkQuery = "SELECT COUNT(*) FROM participation WHERE id_participation = @id_participation";
                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@id_participation", idparticipation);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("The specified réunion ID does not exist.");
                            return;
                        }
                    }

                    // Update the participation table only if the fields are NULL
                    string query = "DELETE FROM participation WHERE id_participation = @id_participation";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id_participation", idparticipation);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Le participant a été retiré de la table de participation !");
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

        private void button6_Click(object sender, EventArgs e)
        {
            PageAcceuil page6 = new PageAcceuil();
            page6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AjouterUneReunion ajout1 = new AjouterUneReunion();
            ajout1.Show();
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
            CompteRenduChef compte = new CompteRenduChef();
            compte.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BoiteDeReceptionChefProjet boiteReception = new BoiteDeReceptionChefProjet();
            boiteReception.Show();
            this.Hide();
        }
    }
}
