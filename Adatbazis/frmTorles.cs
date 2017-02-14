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
    public partial class frmTorles : Form
    {
        public string Azonosito 
        {
            get { return tbAz.Text;  }
        }

        public frmTorles()
        {
            InitializeComponent();
        }

        private void frmTorles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nevekDataSet.nevek' table. You can move, or remove it, as needed.
            this.nevekTableAdapter.Fill(this.nevekDataSet.nevek);
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult eredmeny = MessageBox.Show("Biztos törlöd?","Törlés",MessageBoxButtons.YesNo);
            if (eredmeny == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {
                tbAz.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnMegsem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
