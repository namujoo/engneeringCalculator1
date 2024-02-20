namespace engneeringCalculator1.Matrix_AnalMethod
{
    partial class MatrixSpace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Result2 = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Result2);
            this.panel1.Controls.Add(this.Result1);
            this.panel1.Controls.Add(this.calcul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 578);
            this.panel1.TabIndex = 0;
            // 
            // Result2
            // 
            this.Result2.BackColor = System.Drawing.Color.Bisque;
            this.Result2.Enabled = false;
            this.Result2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.Result2.Location = new System.Drawing.Point(789, 22);
            this.Result2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result2.Multiline = true;
            this.Result2.Name = "Result2";
            this.Result2.Size = new System.Drawing.Size(469, 255);
            this.Result2.TabIndex = 5;
            // 
            // Result1
            // 
            this.Result1.BackColor = System.Drawing.Color.Bisque;
            this.Result1.Enabled = false;
            this.Result1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result1.Location = new System.Drawing.Point(310, 22);
            this.Result1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result1.Multiline = true;
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(469, 255);
            this.Result1.TabIndex = 4;
            // 
            // calcul
            // 
            this.calcul.BackColor = System.Drawing.Color.Khaki;
            this.calcul.Enabled = false;
            this.calcul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcul.Location = new System.Drawing.Point(231, 22);
            this.calcul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(77, 60);
            this.calcul.TabIndex = 3;
            this.calcul.Text = "Calculate";
            this.calcul.UseVisualStyleBackColor = false;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // MatrixSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 578);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MatrixSpace";
            this.Text = "matrix space";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Result1;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.TextBox Result2;
    }
}