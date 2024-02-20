using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1
{
    public partial class MatrixInput : UserControl
    {
        public int m, n; //(열의수, 행의수)
        public TextBox[] numbers;
        public delegate void SendMatData(int row, int col, double[] Matr);
        public event SendMatData send1Ddata;
        public MatrixInput()
        {
            InitializeComponent();
        }

        private void matrixCreate_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            numbers = new TextBox[n*m];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new TextBox();
                numbers[i].Size = new Size(40,20);
                numbers[i].Location = new Point(((i - ((int)(i / n)) * n)) * (numbers[i].Width + 2), 
                    ((int)(i / n)) * (numbers[i].Height + 10));
                panel1.Controls.Add(numbers[i]);
                if(i==m*n-1)
                    MatrixFixed.Enabled = true;
            }
        }

        private void CnumText_TextChanged(object sender, EventArgs e)
        {
            n = Int32.Parse(CnumText.Text);
        }
        
        private void RnumText_TextChanged(object sender, EventArgs e)
        {
            m= Int32.Parse(RnumText.Text);
        }
        private void MatrixFixed_Click(object sender, EventArgs e)
        {
            double[] matrix1D = new double[n*m];
            for (int i = 0;i<n*m;i++)
            {
                if (numbers[i].Text == "")
                    numbers[i].Text = "0";
                // 여기 부터 텍스트 박스들을 2차원 배열로 치환 및 부모 폼으로 데이터 전달
                matrix1D[i] = Double.Parse(numbers[i].Text);
            }
            this.send1Ddata(m, n, matrix1D);
        }
    }
}
