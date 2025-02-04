using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace GestionDesReunions
{
    public partial class LoginChefDeProjet : Form
    {
        string connectionString = "server=localhost;database=gestionreunion;user=root;password='';";

        public LoginChefDeProjet()
        {
            InitializeComponent();
        }

        public static class Session
        {
            public static int IdUtilisateur { get; set; }
            public static string UserName { get; set; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Entrez votre Email et Mot de passe.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id_utilisateur, Prénom FROM utilisateur WHERE Email = @Email AND MotDePasse = @MotDePasse";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@MotDePasse", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int idUtilisateur = reader.GetInt32("id_utilisateur");
                                string userName = reader.GetString("Prénom");

                                // Store the id_utilisateur and userName in the session
                                UserSession.IdUtilisateur = idUtilisateur;
                                UserSession.UserName = userName;

                                // Successful login
                                MessageBox.Show("Login successful!");

                                // Navigate to AjouterUneReunion form
                                AjouterUneReunion ajouterUneReunionForm = new AjouterUneReunion();
                                ajouterUneReunionForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                // Invalid credentials
                                MessageBox.Show("Email ou Mot de passe invalide.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoginParticipant_Load(object sender, EventArgs e)
        {

        }
    }
}
