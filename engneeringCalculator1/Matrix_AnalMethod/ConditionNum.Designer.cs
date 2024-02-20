namespace engneeringCalculator1.Matrix_AnalMethod
{
    partial class ConditionNum
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
            this.Result = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.calcul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 562);
            this.panel1.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Bisque;
            this.Result.Location = new System.Drawing.Point(327, 22);
            this.Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(171, 60);
            this.Result.TabIndex = 2;
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
            this.calcul.TabIndex = 1;
            this.calcul.Text = "Calculate";
            this.calcul.UseVisualStyleBackColor = false;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // ConditionNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConditionNum";
            this.Text = "condition number";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.TextBox Result;
    }
}