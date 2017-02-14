namespace Adatbazis
{
    partial class frmModositas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNev = new System.Windows.Forms.ComboBox();
            this.nevekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nevekDataSet = new Adatbazis.nevekDataSet();
            this.nevekTableAdapter = new Adatbazis.nevekDataSetTableAdapters.nevekTableAdapter();
            this.tbEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbNev
            // 
            this.cbNev.DataSource = this.nevekBindingSource;
            this.cbNev.DisplayMember = "nev";
            this.cbNev.FormattingEnabled = true;
            this.cbNev.Location = new System.Drawing.Point(100, 62);
            this.cbNev.Name = "cbNev";
            this.cbNev.Size = new System.Drawing.Size(270, 28);
            this.cbNev.TabIndex = 4;
            this.cbNev.SelectedIndexChanged += new System.EventHandler(this.cbNev_SelectedIndexChanged);
            // 
            // nevekBindingSource
            // 
            this.nevekBindingSource.DataMember = "nevek";
            this.nevekBindingSource.DataSource = this.nevekDataSet;
            // 
            // nevekDataSet
            // 
            this.nevekDataSet.DataSetName = "nevekDataSet";
            this.nevekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nevekTableAdapter
            // 
            this.nevekTableAdapter.ClearBeforeFill = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(100, 118);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(270, 26);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // frmModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.cbNev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmModositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módosítás";
            this.Load += new System.EventHandler(this.frmModositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nevekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbNev;
        private nevekDataSet nevekDataSet;
        private System.Windows.Forms.BindingSource nevekBindingSource;
        private nevekDataSetTableAdapters.nevekTableAdapter nevekTableAdapter;
        private System.Windows.Forms.TextBox tbEmail;
    }
}