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
    public partial class Femplyee : Form
    {
        Employe E;

        public void actualise()
        {
            E = new Employe(FMenu.C);
            E.lister();
            DGV.DataSource = E.GetConnextion().dt;
            //TxtCode.Text = "";
            //TxtLibelle.Text = "";
            //msg.Text = "";
            //TxtCode.Select();

        }

        public Femplyee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Femplyee_Load(object sender, EventArgs e)
        {
            actualise();
        }
    }
}
