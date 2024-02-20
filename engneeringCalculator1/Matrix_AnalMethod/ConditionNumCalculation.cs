using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engneeringCalculator1.Matrix_AnalMethod
{
    internal partial class BasicMatrixControl
    {
        public double[,] IdentityMat(int n)
        {
            double[,] matI = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        matI[i, j] = 1;
                    else matI[i, j] = 0;                   
                }
            }
            return matI;
        }

        public double[,] ElementaryRowOper_rowchange(double[,]mat1, int n, int m) // n행과 m행을 교체
        {
            int leng=mat1.GetLength(0);            
            double k;
            for (int i = 0; i < leng; i++)
            {
                k = mat1[n, i];
                mat1[n,i] = mat1[m, i];
                mat1[m, i] = k;
            }
            return mat1;
        }

        public double[,] ElementaryRowOper_scarlar(double[,] mat1, int n, double r)  // n행을 r배
        {
            int leng = mat1.GetLength(0);
            for (int i = 0; i < leng; i++) {mat1[n, i] = r * mat1[n,i];}
            return mat1;
        }

        public double[,] ElementaryRowOper_addrow(double[,] mat1, int n, int m, double r)  // n 행을 r배 하여 m행에 더함!! 즉 m행만 변화함
        {
            int leng = mat1.GetLength(0);
            for (int i = 0; i < leng; i++) { mat1[m,i]=r * mat1[n,i]+mat1[m,i]; }
            return mat1;
        }


        public double[,] InverseMatrix(double[,] mat1)  //[A  |  iden]=>[iden  |  A-1] 이거 하는거임
        {
            int leng=mat1.GetLength(0);
            double[,] mat2 = new double[leng,leng];
            mat2 = IdentityMat(leng);
            for (int i = 0; i<leng; i++)
            {
                int a = 0;
                double b = 0;
                while (mat1[a, i] == 0) {  a++; } // leading one을 만들기 위해 처음으로 0이 아닌 행 찾기
                if (a != 0)
                {
                    mat1 = ElementaryRowOper_rowchange(mat1, i, a);     // i 행과 a 행을 교환
                    mat2 = ElementaryRowOper_rowchange(mat2, i, a);
                }
                b = 1 / mat1[i, i];
                mat1 =ElementaryRowOper_scarlar(mat1, i, b);   // 해당 행의 i,i 수(k)를 1로 만들기(행 전체에 1/k 배)
                mat2 = ElementaryRowOper_scarlar(mat2, i, b);
                for (int j=0; j< leng; j++)                                  // leanding 1의 열의 나머지 값들을 0으로
                {
                    if (i == j) { continue; }
                    b = (-1 * mat1[j, i]);
                    mat1 = ElementaryRowOper_addrow(mat1, i, j, b); // 이제 i 열에는 i행의 값만 1, 나머지는 0
                    mat2 = ElementaryRowOper_addrow(mat2, i, j, b);
                }
            }                        
            return mat2;
        }
    }
}
