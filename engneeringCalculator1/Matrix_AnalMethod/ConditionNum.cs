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
    public partial class ConditionNum : Form
    {
        public int m, n, index; //(열의수, 행의수)
        public double[,] MATRIX1, MATRIX2;
        public double condition;
        MatrixInput MatrixInput;

        public ConditionNum()
        {
            InitializeComponent();
            MatrixInput = new MatrixInput();
            MatrixInput.send1Ddata += new MatrixInput.SendMatData(ReceiveFromMat);
            panel1.Controls.Add(MatrixInput);
            MatrixInput.Dock = DockStyle.Fill;
        }

        public void ReceiveFromMat(int rowNum, int colNum, double[] matrix1D)
        {
            m = rowNum; n = colNum;
            MATRIX1 = new double[m, n];
            MATRIX2 = new double[m, n];
            for (int i = 0; i < matrix1D.Length; i++)
            {
                MATRIX1[(int)(i / n), i % n] = matrix1D[i];
                MATRIX2[(int)(i / n), i % n] = matrix1D[i];
            }                       
            calcul.Enabled = true;
        }
        private void calcul_Click(object sender, EventArgs e)
        {
            BasicMatrixControl conditionCalulation = new BasicMatrixControl();
            if (m != n) { Result.Text = "condition number cna only be defined at square martix!"; }
            else
            {
                double[,] MATRIX_inverse = new double[m, m];
                MATRIX_inverse= conditionCalulation.InverseMatrix(MATRIX1);
                condition=(conditionCalulation.MatrixNorm_p2(MATRIX_inverse))* (conditionCalulation.MatrixNorm_p2(MATRIX2));                
                Result.Text = "condition number of this matrix is \n"+condition.ToString();
            }            
        }
    }
}
