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
    public partial class frmLekerdez : Form
    {
        public frmLekerdez()
        {
            InitializeComponent();
        }

        private void frmLekerdez_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nevekDataSet.nevek' table. You can move, or remove it, as needed.
            this.nevekTableAdapter.Fill(this.nevekDataSet.nevek);

        }
    }
}
