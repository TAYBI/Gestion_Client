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
    public partial class Fconnexion : Form
    {
        public static Connexion C;

        public Fconnexion()
        {
            InitializeComponent();
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            C = new Connexion();
            if (C.Connecter() == true)
                new Form1().Show();
            else  
                MessageBox.Show("la connexion a echuee", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
