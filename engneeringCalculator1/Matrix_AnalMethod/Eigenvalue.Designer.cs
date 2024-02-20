namespace engneeringCalculator1.Matrix_AnalMethod
{
    partial class Eigenvalue
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
            this.peigen = new System.Windows.Forms.Panel();
            this.eigenResult = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.peigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // peigen
            // 
            this.peigen.Controls.Add(this.eigenResult);
            this.peigen.Controls.Add(this.calcul);
            this.peigen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peigen.Location = new System.Drawing.Point(0, 0);
            this.peigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.peigen.Name = "peigen";
            this.peigen.Size = new System.Drawing.Size(1010, 615);
            this.peigen.TabIndex = 0;
            // 
            // eigenResult
            // 
            this.eigenResult.BackColor = System.Drawing.Color.Bisque;
            this.eigenResult.Location = new System.Drawing.Point(327, 22);
            this.eigenResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eigenResult.Name = "eigenResult";
            this.eigenResult.Size = new System.Drawing.Size(173, 25);
            this.eigenResult.TabIndex = 1;
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
            this.calcul.TabIndex = 0;
            this.calcul.Text = "Calculate";
            this.calcul.UseVisualStyleBackColor = false;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // Eigenvalue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 615);
            this.Controls.Add(this.peigen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Eigenvalue";
            this.Text = "eigenvalue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.peigen.ResumeLayout(false);
            this.peigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel peigen;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.TextBox eigenResult;
    }
}