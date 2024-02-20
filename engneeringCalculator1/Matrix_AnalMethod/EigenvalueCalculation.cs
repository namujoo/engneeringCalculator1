using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1.Matrix_AnalMethod
{
    internal partial class BasicMatrixControl
    {
        private double[,] matrix;
        int row;
        public BasicMatrixControl()
        {            
        }
        public double eigenvalue_func(double[,] mat, int m)
        {
            matrix = mat;
            row = m;
            double eigen = 0;
            double[] VectorX = new double[row];
            double[] VectorY = new double[row];
            double[] VectorZ = new double[row];

            for (int i = 0; i < row; i++) 
            { 
                VectorX[i] = 1; // X 벡터 초기화
                VectorY[i] = 0; // Y 벡터 초기화
                VectorZ[i] = 1; // Z 벡터 초기화
            }
            if(vectorAbs(MatrixVectorProduct(matrix, VectorX)) < 0.0001){ VectorX[0] = 2; }  // 초기 X에서 Ax가 0이 나오면 안되기에 다른 case하나 설정
            
            while (vectorCompare(VectorX, VectorY))
            {
                VectorX = VectorZ;
                VectorY= VectorNormalize(MatrixVectorProduct(matrix, VectorX));  // AX 를 nomalize하여 Y에 대입
                VectorZ = VectorY;                
            }
            eigen= MatrixVectorProduct(matrix, VectorY)[0] / VectorY[0];
            return eigen;
        }


        public double[,] MatrixMatrixProduct(double[,] mat1, double[,]mat2)  //메트릭스*메트릭스 연산
        {
            int a = mat1.GetLength(0), b = mat2.GetLength(1);
            double c;
            double[,] mat3 = new double[a,b];
            if (mat1.GetLength(1) != mat2.GetLength(0))
            {
                MessageBox.Show("size of matrix doesn't match, use other matrix");
                throw new ArgumentException("wrong size");
            }

            for(int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    c = 0;
                    for (int k = 0; k < mat1.GetLength(1); k++)
                    {
                        c += mat1[i, k] * mat2[k, j];
                    }
                    mat3[i,j]= c;
                }
            }
            return mat3;
        }      
               
        public double[] MatrixVectorProduct(double[,]mat, double[]vec)  // 메트릭스*벡터
        {
            double[] product = new double[mat.GetLength(0)];
            double k = 0;
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < vec.Length; j++)
                {
                    k += mat[i, j] * vec[j];
                }
                product[i] = k;
                k = 0;
            }
            return product;
        }

        public bool vectorCompare(double[] vec1, double[] vec2)  // 두 벡터의 각 항의 절댓값이 같으면 false 반환, 다르면 true
        {
            int j = 0, p = 0;
            for (int i = 0; i < vec1.Length; i++)
            {                
                if (Math.Abs(vec1[i] - vec2[i]) < 0.0001)
                    j++;
                if (Math.Abs(vec1[i] + vec2[i]) < 0.0001)
                    p++;

            }
            if (j == vec1.Length||p==vec1.Length) { return false; }
            return true;
        }

        public double[] VectorNormalize(double[] vec)  //벡터 크기 1로 정규화
        {
            double k=vectorAbs(vec);
            for (int j = 0; j < vec.Length; j++) { vec[j] = vec[j]/k; }
            return vec;                       
        }

        public double vectorAbs(double[] vec) // 벡터 제곱 합^0.5
        {
            double k = 0;
            for (int j = 0; j < vec.Length; j++) { k += (vec[j] * vec[j]); }
            return Math.Pow(k, 0.5);
        }
    }
}
