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
    public partial class FMenu : Form
    {
        public static Connexion C;

        public FMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            C = new Connexion();
            if (C.Connecter() == true)
                msg.Text = "la connexion a effectuee";
            else
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "la connexion a echuee";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            new Fservice().Show();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            new Femplyee().Show();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            new Fconge().Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            new FEdition().Show();
        }
    }
}
