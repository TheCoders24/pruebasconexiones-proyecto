namespace pruebasconexiones_proyecto
{
    partial class principal
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
            this.DATABASE = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DATABASE
            // 
            this.DATABASE.FormattingEnabled = true;
            this.DATABASE.Location = new System.Drawing.Point(-1, 2);
            this.DATABASE.Name = "DATABASE";
            this.DATABASE.Size = new System.Drawing.Size(212, 446);
            this.DATABASE.TabIndex = 0;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DATABASE);
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DATABASE;
    }
}