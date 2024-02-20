using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1.Matrix_AnalMethod
{
    public partial class MatrixSpace : Form
    {
        public int m, n, index; //(열의수, 행의수)
        public double[,] MATRIX;
        MatrixInput MatrixInput;
        public MatrixSpace()
        {
            InitializeComponent();      
            Result1.Visible = false;
            Result2.Visible = false;
            MatrixInput = new MatrixInput();
            MatrixInput.send1Ddata += new MatrixInput.SendMatData(ReceiveFromMat);
            panel1.Controls.Add(MatrixInput);
            MatrixInput.Dock = DockStyle.Fill;
        }

        public void ReceiveFromMat(int rowNum, int colNum, double[] matrix1D)
        {
            m = rowNum; n = colNum;
            MATRIX = new double[m, n];

            for (int i = 0; i < matrix1D.Length; i++)
            {
                MATRIX[(int)(i / n), i % n] = matrix1D[i];
            }
            calcul.Enabled = true;
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            Matrix_AnalMethod.BasicMatrixControl subspace = new Matrix_AnalMethod.BasicMatrixControl();
            List<double[]> Basis_Rs;
            List<double[]> Basis_Cs;
            Basis_Rs = subspace.RowSpace(MATRIX);
            Basis_Cs = subspace.ColSpace(MATRIX);
            int Rlen_List = Basis_Rs.Count, Rlen_Vec = Basis_Rs[0].Length;
            int Clen_List = Basis_Cs.Count, Clen_Vec = Basis_Cs[0].Length;
            Result1.Enabled = true;
            Result1.Visible=true;
            Result2.Enabled = true;
            Result2.Visible = true;
            Result1.Text = "The orthonomal basis of row space is composed with\r\n​{\r\n​";
            Result2.Text = "The orthonomal basis of column space is composed with\r\n​{\r\n​";
            for (int i = 0;i < Rlen_List;i++)
            {
                Result1.AppendText("[");
                for (int j = 0;j < Rlen_Vec-1;j++)
                {
                    Result1.AppendText(Basis_Rs[i][j].ToString()+", ");
                }
                Result1.AppendText(Basis_Rs[i][Rlen_Vec - 1].ToString());
                Result1.AppendText("]\r\n​\r\n​");
            }
            Result1.AppendText("}");

            for (int i = 0; i < Clen_List; i++)
            {
                Result2.AppendText("[");
                for (int j = 0; j < Clen_Vec - 1; j++)
                {
                    Result2.AppendText(Basis_Cs[i][j].ToString() + ", ");
                }
                Result2.AppendText(Basis_Cs[i][Clen_Vec - 1].ToString());
                Result2.AppendText("]\r\n​\r\n​");
            }
            Result2.AppendText("}");


        }
    }
}
