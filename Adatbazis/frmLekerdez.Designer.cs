using System.Data;
namespace Adatbazis
{
    partial class frmLekerdez
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nevekDataSet = new Adatbazis.nevekDataSet();
            this.nevekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nevekTableAdapter = new Adatbazis.nevekDataSetTableAdapters.nevekTableAdapter();
            this.azDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nevekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(514, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // nevekDataSet
            // 
            this.nevekDataSet.DataSetName = "nevekDataSet";
            this.nevekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nevekBindingSource
            // 
            this.nevekBindingSource.DataMember = "nevek";
            this.nevekBindingSource.DataSource = this.nevekDataSet;
            // 
            // nevekTableAdapter
            // 
            this.nevekTableAdapter.ClearBeforeFill = true;
            // 
            // azDataGridViewTextBoxColumn
            // 
            this.azDataGridViewTextBoxColumn.DataPropertyName = "az";
            this.azDataGridViewTextBoxColumn.HeaderText = "az";
            this.azDataGridViewTextBoxColumn.Name = "azDataGridViewTextBoxColumn";
            this.azDataGridViewTextBoxColumn.ReadOnly = true;
            this.azDataGridViewTextBoxColumn.Visible = false;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.ReadOnly = true;
            this.nevDataGridViewTextBoxColumn.Width = 52;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 60;
            // 
            // frmLekerdez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 370);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLekerdez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lekérdezés";
            this.Load += new System.EventHandler(this.frmLekerdez_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataTable Adatforras
        {
            set 
            {
                dataGridView1.DataSource = value;
            }
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private nevekDataSet nevekDataSet;
        private System.Windows.Forms.BindingSource nevekBindingSource;
        private nevekDataSetTableAdapters.nevekTableAdapter nevekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}