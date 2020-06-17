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
    public partial class Fconges_periode : Form
    {
        public Fconges_periode()
        {
            InitializeComponent();
        }

        private void Fconges_periode_Load(object sender, EventArgs e)
        {
            TxtDate1.Text = "__/__/____";
            TxtDate2.Text = "__/__/____";
            TxtDate1.Enter += new System.EventHandler(this.TxtDate1_Enter);
            TxtDate1.Leave += new System.EventHandler(this.TxtDate1_Leave);
            TxtDate2.Enter += new System.EventHandler(this.TxtDate2_Enter);
            TxtDate2.Leave += new System.EventHandler(this.TxtDate2_Leave);
        }

        private void TxtDate2_Enter(object sender, EventArgs e)
        {
            if (TxtDate2.Text == "__/__/____")
            {
                TxtDate2.Text = "";
                TxtDate2.ForeColor = SystemColors.WindowText;
            }
        }

        private void TxtDate2_Leave(object sender, EventArgs e)
        {
            if (TxtDate2.Text.Length == 0)
            {
                TxtDate2.Text = "__/__/____";
                TxtDate2.ForeColor = SystemColors.GrayText;
            }
        }

        private void TxtDate1_Leave(object sender, EventArgs e)
        {
            if (TxtDate1.Text.Length == 0)
            {
                TxtDate1.Text = "__/__/____";
                TxtDate1.ForeColor = SystemColors.GrayText;
            }
        }

        private void TxtDate1_Enter(object sender, EventArgs e)
        {
            if (TxtDate1.Text == "__/__/____")
            {
                TxtDate1.Text = "";
                TxtDate1.ForeColor = SystemColors.WindowText;
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                TxtDate2.Select();
        }

        private void TxtDate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    DateTime.Parse(TxtDate1.Text);
                    DateTime.Parse(TxtDate2.Text);
                }
                catch (Exception m)
                {
                    MessageBox.Show(m.Message);
                }
                finally
                {
                    Conge C = new Conge(FMenu.C);
                    C.conge_periode(TxtDate1.Text, TxtDate2.Text);
                    DGV.DataSource = C.GetConnextion().dt;
                }
            }
        }

        private void BtnEtat_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime.Parse(TxtDate1.Text);
                DateTime.Parse(TxtDate2.Text);
            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            finally
            {
                Conge C = new Conge(FMenu.C);
                C.conge_periode(TxtDate1.Text, TxtDate2.Text);
                DGV.DataSource = C.GetConnextion().dt;
            }
        }
    }
}
