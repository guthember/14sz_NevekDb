using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Adatbazis
{
    public partial class frmModositas : Form
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\nevek.accdb";

        public string Nev
        {
            get { return cbNev.Text; } 
        }

        public string Email
        {
            get { return tbEmail.Text; }
        }

        public frmModositas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmModositas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nevekDataSet.nevek' table. You can move, or remove it, as needed.
            this.nevekTableAdapter.Fill(this.nevekDataSet.nevek);
            OleDbConnection kapcsolat = new OleDbConnection();
            kapcsolat.ConnectionString = connectionString;
            kapcsolat.Open();
            OleDbCommand emailKeres = new OleDbCommand("select [e-mail] from nevek where nev=('" + cbNev.Text +
                "')", kapcsolat);
            tbEmail.Text = emailKeres.ExecuteScalar().ToString();
            emailKeres.Cancel();
            kapcsolat.Close();
        }

        private void cbNev_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection kapcsolat = new OleDbConnection();
            kapcsolat.ConnectionString = connectionString;
            kapcsolat.Open();
            OleDbCommand emailKeres = new OleDbCommand("select [e-mail] from nevek where nev=('" + cbNev.Text +
                "')", kapcsolat);
            tbEmail.Text = emailKeres.ExecuteScalar().ToString();
            emailKeres.Cancel();
            kapcsolat.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            
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
    }
}
