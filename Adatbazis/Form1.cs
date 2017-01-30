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
    public partial class frmFo : Form
    {
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\nevek.accdb";
        
        public frmFo()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lekérdezésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form létrehozása
            frmLekerdez formLekerdez = new frmLekerdez(); 
            // kapcsolat felépítése
            OleDbConnection kapcsolat = new OleDbConnection();
            kapcsolat.ConnectionString = connectionString;
            try
            {
                // próba a megnyitásra
                kapcsolat.Open();
                OleDbDataAdapter Adapter = new OleDbDataAdapter();
                Adapter.SelectCommand = new OleDbCommand("SELECT * FROM NEVEK", kapcsolat);
                DataSet dataset = new DataSet();
                Adapter.Fill(dataset);
                formLekerdez.Adatforras = dataset.Tables["Table"];
                kapcsolat.Close();
                formLekerdez.ShowDialog();
            }
            catch (Exception kivetel)
            {
                MessageBox.Show(kivetel.Message, "Adatbázis hiba!");
                //throw;
            }
        }

        private void adatbevitelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBevitel formBevitel = new frmBevitel();
            if (formBevitel.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Eddig jó!", "Csak ellenőrzés");
            }
        }
    }
}
