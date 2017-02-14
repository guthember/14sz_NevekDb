namespace Adatbazis
{
    partial class frmTorles
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.tbAz = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(606, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.azDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.azDataGridViewTextBoxColumn.DataPropertyName = "az";
            this.azDataGridViewTextBoxColumn.HeaderText = "Azonosító";
            this.azDataGridViewTextBoxColumn.Name = "azDataGridViewTextBoxColumn";
            this.azDataGridViewTextBoxColumn.ReadOnly = true;
            this.azDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.azDataGridViewTextBoxColumn.Width = 105;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.ReadOnly = true;
            this.nevDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nevDataGridViewTextBoxColumn.Width = 61;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "e-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.emailDataGridViewTextBoxColumn.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Törlendő rekord";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(392, 33);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(154, 36);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.Location = new System.Drawing.Point(392, 85);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(154, 36);
            this.btnMegsem.TabIndex = 3;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            this.btnMegsem.Click += new System.EventHandler(this.btnMegsem_Click);
            // 
            // tbAz
            // 
            this.tbAz.Location = new System.Drawing.Point(195, 33);
            this.tbAz.Name = "tbAz";
            this.tbAz.Size = new System.Drawing.Size(153, 26);
            this.tbAz.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbAz);
            this.panel1.Controls.Add(this.btnMegsem);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 129);
            this.panel1.TabIndex = 5;
            // 
            // frmTorles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTorles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Törlés";
            this.Load += new System.EventHandler(this.frmTorles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private nevekDataSet nevekDataSet;
        private System.Windows.Forms.BindingSource nevekBindingSource;
        private nevekDataSetTableAdapters.nevekTableAdapter nevekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.TextBox tbAz;
        private System.Windows.Forms.Panel panel1;
    }
}