namespace engneeringCalculator1.slides
{
    partial class chooseMenew
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinearSystem = new System.Windows.Forms.Button();
            this.plottingDot = new System.Windows.Forms.Button();
            this.matrixAnalysis = new System.Windows.Forms.Button();
            this.pchoose1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose what you want to do";
            // 
            // LinearSystem
            // 
            this.LinearSystem.Location = new System.Drawing.Point(42, 210);
            this.LinearSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LinearSystem.Name = "LinearSystem";
            this.LinearSystem.Size = new System.Drawing.Size(101, 60);
            this.LinearSystem.TabIndex = 1;
            this.LinearSystem.Text = "Linear System solving";
            this.LinearSystem.UseVisualStyleBackColor = true;
            this.LinearSystem.Click += new System.EventHandler(this.LinearSystem_Click);
            // 
            // plottingDot
            // 
            this.plottingDot.Location = new System.Drawing.Point(42, 330);
            this.plottingDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plottingDot.Name = "plottingDot";
            this.plottingDot.Size = new System.Drawing.Size(101, 60);
            this.plottingDot.TabIndex = 2;
            this.plottingDot.Text = "plotting\r\ndots on \r\ncoordinate";
            this.plottingDot.UseVisualStyleBackColor = true;
            this.plottingDot.Click += new System.EventHandler(this.plottingDot_Click);
            // 
            // matrixAnalysis
            // 
            this.matrixAnalysis.Location = new System.Drawing.Point(42, 92);
            this.matrixAnalysis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matrixAnalysis.Name = "matrixAnalysis";
            this.matrixAnalysis.Size = new System.Drawing.Size(101, 60);
            this.matrixAnalysis.TabIndex = 3;
            this.matrixAnalysis.Text = "Matrix\r\nAnalysis";
            this.matrixAnalysis.UseVisualStyleBackColor = true;
            this.matrixAnalysis.Click += new System.EventHandler(this.matrixAnalysis_Click);
            // 
            // pchoose1
            // 
            this.pchoose1.BackColor = System.Drawing.Color.Transparent;
            this.pchoose1.Location = new System.Drawing.Point(200, 39);
            this.pchoose1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pchoose1.Name = "pchoose1";
            this.pchoose1.Size = new System.Drawing.Size(554, 407);
            this.pchoose1.TabIndex = 4;
            // 
            // chooseMenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pchoose1);
            this.Controls.Add(this.matrixAnalysis);
            this.Controls.Add(this.plottingDot);
            this.Controls.Add(this.LinearSystem);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "chooseMenew";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LinearSystem;
        private System.Windows.Forms.Button plottingDot;
        private System.Windows.Forms.Button matrixAnalysis;
        private System.Windows.Forms.Panel pchoose1;
    }
}
