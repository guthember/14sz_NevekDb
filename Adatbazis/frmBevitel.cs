using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adatbazis
{
    public partial class frmBevitel : Form
    {
        public string Nev 
        { 
            get { return tbNev.Text; }
            set { tbNev.Text = value; } 
        }

        public string Email 
        { 
            get { return tbEmail.Text; }
            set { tbEmail.Text = value; } 
        }

        public frmBevitel()
        {
            InitializeComponent();
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNev_Validating(object sender, CancelEventArgs e)
        {
            string nev = tbNev.Text;
            for (int i = 0; i < nev.Length; i++)
            {
                if (!Char.IsLetter(nev[i]) && nev[i] != ' ')
                {
                    e.Cancel = true;
                    MessageBox.Show("Csak betű és szóköz!", "Adatbevitel hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = tbEmail.Text;

            bool van = false;
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@') 
                {
                    van = true;
                    break;
                }
            }
            if (!van)
            {
                e.Cancel = true;
                MessageBox.Show("Nem érvényes e-mail cím", "Adatbevitel hiba",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool vanHiba = false;
            if (tbNev.Text.Length == 0)
            {
                MessageBox.Show("Nem lehet üres a név", "Adatbevitel hiba",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                vanHiba = true;
            }
            if (tbEmail.Text.Length == 0)
            {
                MessageBox.Show("Nem lehet üres az e-mail", "Adatbevitel hiba",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                vanHiba = true;
            }
            if (!vanHiba)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
