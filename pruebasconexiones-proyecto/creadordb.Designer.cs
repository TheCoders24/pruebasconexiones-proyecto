namespace pruebasconexiones_proyecto
{
    partial class creadordb
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
            this.btncrearbasededatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombredebasededatos = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxdatabase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrearbasededatos
            // 
            this.btncrearbasededatos.Location = new System.Drawing.Point(357, 12);
            this.btncrearbasededatos.Name = "btncrearbasededatos";
            this.btncrearbasededatos.Size = new System.Drawing.Size(75, 33);
            this.btncrearbasededatos.TabIndex = 0;
            this.btncrearbasededatos.Text = "crear";
            this.btncrearbasededatos.UseVisualStyleBackColor = true;
            this.btncrearbasededatos.Click += new System.EventHandler(this.btncrearbasededatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Base de Datos:";
            // 
            // txtnombredebasededatos
            // 
            this.txtnombredebasededatos.Location = new System.Drawing.Point(156, 12);
            this.txtnombredebasededatos.Name = "txtnombredebasededatos";
            this.txtnombredebasededatos.Size = new System.Drawing.Size(172, 20);
            this.txtnombredebasededatos.TabIndex = 2;
            this.txtnombredebasededatos.TextChanged += new System.EventHandler(this.txtnombredebasededatos_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 371);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "using";
            // 
            // comboBoxdatabase
            // 
            this.comboBoxdatabase.FormattingEnabled = true;
            this.comboBoxdatabase.Location = new System.Drawing.Point(67, 38);
            this.comboBoxdatabase.Name = "comboBoxdatabase";
            this.comboBoxdatabase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdatabase.TabIndex = 5;
            this.comboBoxdatabase.SelectedIndexChanged += new System.EventHandler(this.comboBoxdatabase_SelectedIndexChanged);
            // 
            // creadordb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxdatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtnombredebasededatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncrearbasededatos);
            this.Name = "creadordb";
            this.Text = "creadordb";
            this.Load += new System.EventHandler(this.creadordb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrearbasededatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombredebasededatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxdatabase;
    }
}