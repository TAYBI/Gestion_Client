﻿using System;
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
    public partial class FEdition : Form
    {
        public FEdition()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            new Femloye_service().Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            new Fconge_employe().Show();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            new Fconges_periode().Show();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            new Fstatistique_type().Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            new Fconge_annee_mois().Show();
        }
    }
}
