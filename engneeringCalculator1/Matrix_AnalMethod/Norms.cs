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
    public partial class Norms : Form
    {
        public int m, n, index; //(열의수, 행의수)
        public double[,] MATRIX;
        MatrixInput MatrixInput;
        public Norms()
        {
            InitializeComponent();
            MatrixInput = new MatrixInput();
            MatrixInput.send1Ddata += new MatrixInput.SendMatData(ReceiveFromMat);
            panel1.Controls.Add(MatrixInput);
            MatrixInput.Dock = DockStyle.Fill;
        }

        private void calcul_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    double k = 0;
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0;j < n; j++)
                        {
                            k+= Math.Pow(MATRIX[i,j],2);
                        }
                    }
                    label1.Text = "Frobenious Norm is\n"+Math.Pow(k,0.5).ToString();
                    break;

                case 1:
                    double p = 0;                    
                    for (int j = 0; j < n; j++)
                    {
                        k = 0;
                        for (int i = 0; i < m; i++)
                        {
                            k += Math.Abs(MATRIX[i,j]);
                        }
                        p=Math.Max(k, p);
                    }
                    label1.Text = "Column sum Norm is\n" + p.ToString();
                    break; 

                case 2:
                    p = 0;                    
                    for (int i = 0; i < m; i++)
                    {
                        k = 0;
                        for (int j = 0; j < n; j++)
                        {
                            k += Math.Abs(MATRIX[i, j]);
                        }
                        p = Math.Max(k, p);
                    }
                    label1.Text = "Row sum Norm is\n" + p.ToString();
                    break;
                    
                case 3:
                    BasicMatrixControl normCalulation = new BasicMatrixControl();
                    p = normCalulation.MatrixNorm_p2(MATRIX);
                    label1.Text = "Matrix Norm(p=2 induced norm, max eigenvalue's square) is\n"+p.ToString();
                    break;


                case 4:
                    k = 0;
                    if (m == 1)                    
                        for (int j = 0; j < n; j++)
                            k += Math.Abs(MATRIX[0,j]);
                    if(n==1)
                        for (int i = 0; i < m; i++)
                            k += Math.Abs(MATRIX[i, 0]);
                    label1.Text = "p=1 vector norm is\n" + k.ToString();
                    break; 

                case 5:
                    k = 0;
                    if (m == 1)
                        for (int j = 0; j < n; j++)
                            k += Math.Pow(MATRIX[0, j],2);
                    if (n == 1)
                        for (int i = 0; i < m; i++)
                            k += Math.Pow(MATRIX[i, 0],2);
                    label1.Text = "p=2 vector norm(uclidean norm) is\n" + Math.Pow(k,0.5).ToString();
                    break;

                case 6:
                    k = 0;
                    if (m == 1)
                        for (int j = 0; j < n; j++)
                            k = Math.Max(k, Math.Abs(MATRIX[0, j]));
                    if (n == 1)
                        for (int i = 0; i < m; i++)
                            k = Math.Max(k, Math.Abs(MATRIX[i, 0]));
                    label1.Text = "p=infinity vector norm is\n" + k.ToString();
                    break;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            ComboBox sendercombo = (ComboBox) sender;
            index=sendercombo.SelectedIndex;
            calcul.Enabled = true;
        }

        public void ReceiveFromMat(int rowNum, int colNum, double[] matrix1D)
        {
            m = rowNum; n = colNum;
            MATRIX = new double[m, n];

            for (int i = 0; i < matrix1D.Length; i++)
            {
                MATRIX[(int)(i / n), i % n] = matrix1D[i];
            }

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Frobenious Norm");
            comboBox1.Items.Add("coloum sum Norm");
            comboBox1.Items.Add("row sum Norm");
            comboBox1.Items.Add("Matrix Norm");
            if (m == 1 || n == 1)
            {
                comboBox1.Items.Add("Recomanded: p=1 vector norm");
                comboBox1.Items.Add("Recomanded: p=2 vector norm");
                comboBox1.Items.Add("Recomanded: p=infinity vector norm");
            }            
        }
    }
}
