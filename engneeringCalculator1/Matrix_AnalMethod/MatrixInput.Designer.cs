namespace engneeringCalculator1
{
    partial class MatrixInput
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
            this.Rnum = new System.Windows.Forms.Label();
            this.Cnum = new System.Windows.Forms.Label();
            this.RnumText = new System.Windows.Forms.TextBox();
            this.CnumText = new System.Windows.Forms.TextBox();
            this.matrixCreate = new System.Windows.Forms.Button();
            this.MatrixFixed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Rnum
            // 
            this.Rnum.AutoSize = true;
            this.Rnum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rnum.Location = new System.Drawing.Point(13, 20);
            this.Rnum.Name = "Rnum";
            this.Rnum.Size = new System.Drawing.Size(113, 17);
            this.Rnum.TabIndex = 0;
            this.Rnum.Text = "number of Rows:";
            // 
            // Cnum
            // 
            this.Cnum.AutoSize = true;
            this.Cnum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnum.Location = new System.Drawing.Point(13, 44);
            this.Cnum.Name = "Cnum";
            this.Cnum.Size = new System.Drawing.Size(133, 17);
            this.Cnum.TabIndex = 1;
            this.Cnum.Text = "number of columns:";
            // 
            // RnumText
            // 
            this.RnumText.Location = new System.Drawing.Point(152, 17);
            this.RnumText.Name = "RnumText";
            this.RnumText.Size = new System.Drawing.Size(40, 21);
            this.RnumText.TabIndex = 2;
            this.RnumText.TextChanged += new System.EventHandler(this.RnumText_TextChanged);
            // 
            // CnumText
            // 
            this.CnumText.Location = new System.Drawing.Point(152, 44);
            this.CnumText.Name = "CnumText";
            this.CnumText.Size = new System.Drawing.Size(40, 21);
            this.CnumText.TabIndex = 3;
            this.CnumText.TextChanged += new System.EventHandler(this.CnumText_TextChanged);
            // 
            // matrixCreate
            // 
            this.matrixCreate.Location = new System.Drawing.Point(16, 64);
            this.matrixCreate.Name = "matrixCreate";
            this.matrixCreate.Size = new System.Drawing.Size(59, 32);
            this.matrixCreate.TabIndex = 4;
            this.matrixCreate.Text = "confirm";
            this.matrixCreate.UseVisualStyleBackColor = true;
            this.matrixCreate.Click += new System.EventHandler(this.matrixCreate_Click);
            // 
            // MatrixFixed
            // 
            this.MatrixFixed.BackColor = System.Drawing.Color.SandyBrown;
            this.MatrixFixed.Enabled = false;
            this.MatrixFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MatrixFixed.Location = new System.Drawing.Point(16, 102);
            this.MatrixFixed.Name = "MatrixFixed";
            this.MatrixFixed.Size = new System.Drawing.Size(59, 36);
            this.MatrixFixed.TabIndex = 5;
            this.MatrixFixed.Text = "fix\r\nmatrix";
            this.MatrixFixed.UseVisualStyleBackColor = false;
            this.MatrixFixed.Click += new System.EventHandler(this.MatrixFixed_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(90, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 461);
            this.panel1.TabIndex = 6;
            // 
            // MatrixInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MatrixFixed);
            this.Controls.Add(this.matrixCreate);
            this.Controls.Add(this.CnumText);
            this.Controls.Add(this.RnumText);
            this.Controls.Add(this.Cnum);
            this.Controls.Add(this.Rnum);
            this.Name = "MatrixInput";
            this.Size = new System.Drawing.Size(884, 531);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rnum;
        private System.Windows.Forms.Label Cnum;
        private System.Windows.Forms.TextBox RnumText;
        private System.Windows.Forms.TextBox CnumText;
        private System.Windows.Forms.Button matrixCreate;
        private System.Windows.Forms.Button MatrixFixed;
        private System.Windows.Forms.Panel panel1;
    }
}
