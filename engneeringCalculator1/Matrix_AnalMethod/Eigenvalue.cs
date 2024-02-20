using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace engneeringCalculator1.Matrix_AnalMethod
{    
    public partial class Eigenvalue : Form
    {
        public int m, n; //(열의수, 행의수)
        public double[,] MATRIX;
        public double eigen;
        MatrixInput MatrixInput;
        public Eigenvalue()
        {
            InitializeComponent();
            MatrixInput = new MatrixInput();
            MatrixInput.send1Ddata += new MatrixInput.SendMatData(ReceiveFromMat);
            peigen.Controls.Add(MatrixInput);
            MatrixInput.Dock = DockStyle.Fill;
        }
        
        // 데이터 전달받기
        public void ReceiveFromMat(int rowNum, int colNum, double[] matrix1D)
        {
            m = rowNum; n = colNum;
            MATRIX=new double[m, n];

            for(int i = 0; i < matrix1D.Length; i++)
            {
                MATRIX[(int)(i / n), i % n]=matrix1D[i];
            }
            calcul.Enabled = true;
        }

        // 수학적 계산 시작
        private void calcul_Click(object sender, EventArgs e)
        {            
            Matrix_AnalMethod.BasicMatrixControl eigenCalulation=new Matrix_AnalMethod.BasicMatrixControl();
            if(m!=n)
            {
                eigenResult.Text = "eigenvalues are only defined at square matrix!";
                MessageBox.Show("choose same coloumn and row number", "Not defined");
            }
            else
            {
                eigen = eigenCalulation.eigenvalue_func(MATRIX, m);
                eigenResult.Text=eigen.ToString();
            }            
        }

    }
}
