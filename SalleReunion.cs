using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Paddings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDesReunions
{
    public partial class SalleReunion : Form
    {
        string connectionString = "server=localhost;database=gestionreunion;user=root;password='';";
        public SalleReunion()
        {
            InitializeComponent();
            LoadSalles();
            LoadMateriel();
            DisplayUserName();

            GridSalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridSalle.MultiSelect = false;
            GridSalle.CellClick += new DataGridViewCellEventHandler(GridSalle_CellClick);

            GridMateriel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridMateriel.MultiSelect = false;
            GridMateriel.CellClick += new DataGridViewCellEventHandler(GridMateriel_CellClick);

        }
        private void DisplayUserName()
        {
            this.labelConnect.Text = "Bonjour " + UserSession.UserName;
        }

        private void LoadData()
        {
            GridSalle.CellClick += GridSalle_CellClick;
            GridMateriel.CellClick += GridMateriel_CellClick;
        }


        private void GridSalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridSalle.Rows[e.RowIndex];

                // Assuming the column names are correct
                NomSalleTextBox.Text = row.Cells["NomSalle"].Value?.ToString();
                CapaciteSalleTextBox.Text = row.Cells["Capacite"].Value?.ToString();
              
            }
        }



        private void GridMateriel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = GridMateriel.Rows[e.RowIndex];

                // Assuming the column names are correct
                MaterielTextBox.Text = row.Cells["Materiel"].Value?.ToString();
                DescriptionTextArea.Text = row.Cells["DescriptionMateriel"].Value?.ToString();
               
            }
        }





        private void LoadSalles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT id_salle, Nom, Capacité FROM salle";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridSalle.DataSource = dt; // Assuming GridSalle is the name of your DataGridView control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading meeting rooms: " + ex.Message);
                }
            }
        }

        private void LoadMateriel()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT id_matériel, NomMateriel, Description FROM matériel";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    GridMateriel.DataSource = dt; // Assuming GridMateriel is the name of your DataGridView control
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading materials: " + ex.Message);
                }
            }
        }

        private void SalleReunion_Load(object sender, EventArgs e)
        {
            // This method can be used for form load events if needed
        }

        private void GridSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method can be used to handle cell content click events if needed
        }

        private void AjouterSalle_Click(object sender, EventArgs e)
        {
            string nomSalle = NomSalleTextBox.Text;
            string capaciteSalle = CapaciteSalleTextBox.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO salle (Nom, Capacité) VALUES (@Nom, @Capacité)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nom", nomSalle);
                    cmd.Parameters.AddWithValue("@Capacité", capaciteSalle);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nouvelle Salle a été ajoutée !");

                    // Refresh the DataGridView after insertion
                    LoadSalles();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062) // Duplicate entry error code
                    {
                        MessageBox.Show("Erreur: Une salle avec le même nom existe déjà.");
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans l'ajout de la salle: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans l'ajout de la salle: " + ex.Message);
                }
            }
        }


        private void AjouterMateriel_Click(object sender, EventArgs e)
        {
            string nomMateriel = MaterielTextBox.Text;
            string DescriptionMateriel = DescriptionTextArea.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = @"INSERT INTO matériel (NomMateriel, Description) VALUES (@nomMateriel, @DescriptionMateriel)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nomMateriel", nomMateriel);
                    cmd.Parameters.AddWithValue("@DescriptionMateriel", DescriptionMateriel);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Nouveau Matériel a été ajouté !");

                    // Refresh the DataGridView after insertion
                    LoadSalles();
                }
                catch (MySqlException ex) when (ex.Number == 1062) // 1062 is the error number for duplicate entry
                {
                    MessageBox.Show("Erreur: Le matériel avec ce nom existe déjà. Veuillez entrer un nom différent.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans l'ajout du matériel: " + ex.Message);
                }
            }
        }

        private void ModifierSalle_Click(object sender, EventArgs e)
        {
            if (GridSalle.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridSalle.SelectedRows[0];
                int salleId = Convert.ToInt32(row.Cells["ID"].Value);

                string nomSalle = NomSalleTextBox.Text;
                string capaciteSalle = CapaciteSalleTextBox.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sql = @"UPDATE salle SET Nom = @Nom, Capacité = @Capacité WHERE id_salle = @id_salle";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Nom", nomSalle);
                        cmd.Parameters.AddWithValue("@Capacité", capaciteSalle);
                        cmd.Parameters.AddWithValue("@id_salle", salleId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salle modifiée avec succès !");

                        // Refresh the DataGridView after update
                        LoadSalles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur dans la modification de la salle: " + ex.Message);
                    }
                }
            }
        }

        private void ModifierMateriel_Click(object sender, EventArgs e)
        {
            if (GridMateriel.SelectedRows.Count > 0)
            {
                DataGridViewRow row = GridMateriel.SelectedRows[0];
                int materielId = Convert.ToInt32(row.Cells["IdMateriel"].Value);

                string nomMateriel = MaterielTextBox.Text;
                string DescriptionMateriel = DescriptionTextArea.Text;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string sql = @"UPDATE matériel SET NomMateriel = @nomMateriel, Description = @DescriptionMateriel WHERE id_matériel = @id_matériel";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@nomMateriel", nomMateriel);
                        cmd.Parameters.AddWithValue("@DescriptionMateriel", DescriptionMateriel);
                        cmd.Parameters.AddWithValue("@id_matériel", materielId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Matériel modifié avec succès !");

                        // Refresh the DataGridView after update
                        LoadMateriel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur dans la modification du matériel: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjouterUneReunion reunionAjout = new AjouterUneReunion();

            // Show the LoginChefDeProjet form
            reunionAjout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalleReunion salle2 = new SalleReunion();

            // Show the LoginChefDeProjet form
            salle2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            labelConnected tabBord1 = new labelConnected();
       



            tabBord1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CompteRenduChef cptrendu2 = new CompteRenduChef();
            cptrendu2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BoiteDeReceptionChefProjet boite6 = new BoiteDeReceptionChefProjet();
            boite6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PageAcceuil page2 = new PageAcceuil();
            page2.Show();
            this.Hide();
        }
    }
}
