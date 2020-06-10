using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Client
{
    public partial class Fconge : Form
    {
        Conge conge;
        public void actualiser()
        {
            conge = new Conge(FMenu.C);
            conge.lister();
            DGV.DataSource = conge.GetConnextion().dt;
            TxtMatricule.Text = "";
            TxtDuree.Text = "";
            TxtType.Text = "";
            TxtConge.Text = DateTime.Today.ToShortDateString();

        }

        public Fconge()
        {
            InitializeComponent();
        }

        private void Fconge_Load(object sender, EventArgs e)
        {
            actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
