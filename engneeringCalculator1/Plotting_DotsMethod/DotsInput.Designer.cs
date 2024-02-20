namespace engneeringCalculator1.Plotting_DotsMethod
{
    partial class DotsInput
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.DotInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PointNumText = new System.Windows.Forms.TextBox();
            this.DotPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DotInput
            // 
            this.DotInput.BackColor = System.Drawing.Color.Pink;
            this.DotInput.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotInput.ForeColor = System.Drawing.Color.Indigo;
            this.DotInput.Location = new System.Drawing.Point(98, 20);
            this.DotInput.Name = "DotInput";
            this.DotInput.Size = new System.Drawing.Size(74, 25);
            this.DotInput.TabIndex = 0;
            this.DotInput.Text = "Dot input";
            this.DotInput.UseVisualStyleBackColor = false;
            this.DotInput.Click += new System.EventHandler(this.DotInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of initial data(Point) :";
            // 
            // PointNumText
            // 
            this.PointNumText.BackColor = System.Drawing.Color.LavenderBlush;
            this.PointNumText.Location = new System.Drawing.Point(6, 24);
            this.PointNumText.Name = "PointNumText";
            this.PointNumText.Size = new System.Drawing.Size(86, 21);
            this.PointNumText.TabIndex = 2;
            this.PointNumText.Text = "Input here(int)";
            this.PointNumText.Click += new System.EventHandler(this.PointNumText_Click);
            // 
            // DotPanel
            // 
            this.DotPanel.Location = new System.Drawing.Point(0, 50);
            this.DotPanel.Name = "DotPanel";
            this.DotPanel.Size = new System.Drawing.Size(258, 227);
            this.DotPanel.TabIndex = 3;
            this.DotPanel.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(125, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Y coor";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(45, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "X coor";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.UseWaitCursor = true;
            this.textBox2.Visible = false;
            // 
            // DotsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DotPanel);
            this.Controls.Add(this.PointNumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DotInput);
            this.Name = "DotsInput";
            this.Size = new System.Drawing.Size(262, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DotInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PointNumText;
        private System.Windows.Forms.Panel DotPanel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
    }
}
