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
    public partial class Participant : Form
    {
        public Participant()
        {
            InitializeComponent();
            DisplayUserName();
        }

        private void DisplayUserName()
        {
            this.labelParticipant.Text = "Bonjour " + UserSession.UserName;
        }


        private void Participant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BoiteDeReception boite = new BoiteDeReception();
            boite.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReunionParticipant reunion = new ReunionParticipant();
            reunion.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageAcceuil page4 = new PageAcceuil();
            page4.Show();
            this.Hide();
        }
    }
}
