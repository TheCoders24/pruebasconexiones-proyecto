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
            this.btnsavetable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrearbasededatos
            // 
            this.btncrearbasededatos.Location = new System.Drawing.Point(363, 2);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 371);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnsavetable
            // 
            this.btnsavetable.Location = new System.Drawing.Point(363, 41);
            this.btnsavetable.Name = "btnsavetable";
            this.btnsavetable.Size = new System.Drawing.Size(75, 27);
            this.btnsavetable.TabIndex = 6;
            this.btnsavetable.Text = "savetable";
            this.btnsavetable.UseVisualStyleBackColor = true;
            this.btnsavetable.Click += new System.EventHandler(this.btnsavetable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "addrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "nombre tabla";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 10;
            // 
            // creadordb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsavetable);
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
        private System.Windows.Forms.Button btnsavetable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}