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
    public partial class labelConnected : Form
    {

        string connectionString = "server=localhost;database=gestionreunion;user=root;password='';";
        public labelConnected()
        {
            InitializeComponent();
            DisplayDashboardData();

            DisplayUserName();
        }



        private void DisplayUserName()
        {
            this.label9.Text = "Bonjour " + UserSession.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelConnected bord = new labelConnected();


            bord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterUneReunion ReunionForm = new AjouterUneReunion();


            ReunionForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalleReunion salle2 = new SalleReunion();


            salle2.Show();
        }

        

        private void DisplayDashboardData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the number of users with profile "Participant"
                    string sqlUsers = "SELECT COUNT(*) FROM utilisateur WHERE Profil = 'Participant'";
                    MySqlCommand cmdUsers = new MySqlCommand(sqlUsers, conn);
                    int numUsers = Convert.ToInt32(cmdUsers.ExecuteScalar());
                    ParticipantsLabel.Text = numUsers.ToString();

                    // Query to get the number of salles
                    string sqlSalles = "SELECT COUNT(*) FROM salle";
                    MySqlCommand cmdSalles = new MySqlCommand(sqlSalles, conn);
                    int numSalles = Convert.ToInt32(cmdSalles.ExecuteScalar());
                    SallesLabel.Text = numSalles.ToString();

                    // Query to get the number of reunions with Etat_Reunion = Programmée
                    string sqlReunions = "SELECT COUNT(*) FROM réunion WHERE Etat_Reunion = 'Programmée'";
                    MySqlCommand cmdReunions = new MySqlCommand(sqlReunions, conn);
                    int numReunions = Convert.ToInt32(cmdReunions.ExecuteScalar());
                    ReunionsProgrammeesLabel.Text = numReunions.ToString();

                    // Query to get the number of materiels
                    string sqlMateriels = "SELECT COUNT(*) FROM matériel";
                    MySqlCommand cmdMateriels = new MySqlCommand(sqlMateriels, conn);
                    int numMateriels = Convert.ToInt32(cmdMateriels.ExecuteScalar());
                    MaterielsLabel.Text = numMateriels.ToString();

                    // Query to get the number of participations where absence = 'Oui'
                    string sqlParticipations = "SELECT COUNT(*) FROM participation WHERE présence = 'Oui'";
                    MySqlCommand cmdParticipations = new MySqlCommand(sqlParticipations, conn);
                    int numParticipations = Convert.ToInt32(cmdParticipations.ExecuteScalar());
                    AbsencesLabel.Text = numParticipations.ToString();



                    string sqlReunionsQtd = "SELECT COUNT(*) FROM réunion WHERE DATE(DateHeureDebut) = CURRENT_DATE";
                    MySqlCommand cmdReunionsQtd = new MySqlCommand(sqlReunionsQtd, conn);
                    int numReunionsQtd = Convert.ToInt32(cmdReunionsQtd.ExecuteScalar());
                    ReunionTodayLabel.Text = numReunionsQtd.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void TableauDeBord_Load(object sender, EventArgs e)
        {

        }

        private void ReunionTodayLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idreunion = 29;
            CompteRenduChef cptrendu1 = new CompteRenduChef();
            cptrendu1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PageAcceuil page = new PageAcceuil();
            page.Show();
            this.Hide();
        }
    }
}
