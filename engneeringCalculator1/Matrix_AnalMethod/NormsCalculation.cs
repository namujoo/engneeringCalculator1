using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engneeringCalculator1.Matrix_AnalMethod
{
    internal partial class BasicMatrixControl
    {
        public double[,] MatrixTran(double[,] mat1) //transpose
        {
            int a = mat1.GetLength(0), b = mat1.GetLength(1);
            double[,] mat2 = new double[b, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mat2[j, i] = mat1[i, j];
                }
            }
            return mat2;
        }


        public double Determinant(double[,] mat1)  //det 구하기
        {
            double det = 0;
            if (mat1.GetLength(0) != mat1.GetLength(1)) { return 0; }
            if (mat1.GetLength(0) == 2) { det = mat1[0, 0] * mat1[1, 1] - mat1[1, 0] * mat1[0, 1]; }
            else
            {
                for (int i = 0; i < mat1.GetLength(0); i++)
                {
                    det += mat1[0, i] * Math.Pow(-1, i) * Minor(mat1, 0, i);
                }
            }
            return det;
        }


        public double Minor(double[,] mat1, int row_rem, int col_rem)  // 제거하고싶은 행 열 대입, minor 반환
        {
            int row_num = mat1.GetLength(0), col_num = mat1.GetLength(1);
            double min_det = 0;
            double[,] mat2 = new double[row_num - 1, col_num - 1];
            for (int i = 0; i < row_num - 1; i++)
            {
                for (int j = 0; j < col_num - 1; j++)
                {
                    if (i < row_rem)
                    {
                        if (j < col_rem)
                            mat2[i, j] = mat1[i, j];
                        else
                            mat2[i, j] = mat1[i, j + 1];
                    }
                    else
                    {
                        if (j < col_rem)
                            mat2[i, j] = mat1[i + 1, j];
                        else
                            mat2[i, j] = mat1[i + 1, j + 1];
                    }
                }
            }
            min_det = Determinant(mat2);
            return min_det;
        }

        public double MatrixNorm_p2(double[,]mat1)
        {
            int n = mat1.GetLength(1);
            double p;
            double[,] NNmat = new double[n, n];
            NNmat = MatrixMatrixProduct(MatrixTran(mat1), mat1);
            p = Math.Pow(eigenvalue_func(NNmat, n),0.5);
            return p;
        }
    }



}
