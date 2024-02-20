namespace engneeringCalculator1.Plotting_DotsMethod
{
    partial class DotDotConnector
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
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.plot1 = new ScottPlot.FormsPlot();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.plot1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 524);
            this.panel1.TabIndex = 0;
            // 
            // checkBox4
            // 
            this.checkBox4.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox4.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox4.Location = new System.Drawing.Point(174, 326);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(140, 20);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Cubic spline";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox3.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox3.Location = new System.Drawing.Point(174, 301);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 20);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Humite Cubic";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox2.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(174, 276);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 25);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Ploynomial";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox1.Font = new System.Drawing.Font("PMingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(174, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Straight Line";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // plot1
            // 
            this.plot1.Location = new System.Drawing.Point(320, 0);
            this.plot1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(1000, 600);
            this.plot1.TabIndex = 0;
            this.plot1.Visible = false;
            // 
            // DotDotConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 524);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DotDotConnector";
            this.Text = "DotDotConnector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ScottPlot.FormsPlot plot1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}