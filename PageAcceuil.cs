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
    public partial class PageAcceuil : Form
    {
        public PageAcceuil()
        {
            InitializeComponent();
        }

        

        private void ChefDeProjet_Click(object sender, EventArgs e)
        {
            LoginDuParticipant participant = new LoginDuParticipant();
            participant.Show();
            this.Hide();
        }

        private void PageAcceuil_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginChefDeProjet chef = new LoginChefDeProjet();
            chef.Show();
            this.Hide();
        }
    }
}
