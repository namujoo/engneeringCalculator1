using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engneeringCalculator1.Plotting_DotsMethod
{
    internal partial class PointCalMethods
    {
        public double[,] SortPtns(double[,] ptns)
        {
            int lengt = ptns.GetLength(1);
            for (int i=0;i< lengt-1; i++)
            {
                int temp=i;
                for(int j=i+1;j< lengt; j++)
                {
                    if (ptns[0,i] > ptns[0,j]) temp = j;
                }
                double k = ptns[0, i];
                ptns[0, i] = ptns[0, temp];
                ptns[0, temp] = k;
                k = ptns[1, i];
                ptns[1,i]= ptns[1,temp];
                ptns[1, temp] = k;
            }            
            return ptns;
        }

        public double[] SolveLinear(double[,]mat_A, double[] vec_B)
        {
            // mat1은 LU 분해 가능한 것만 받았다 하고 진행
            int lengt = mat_A.GetLength(0);
            double[,] Lmat = new double[lengt, lengt];
            double[,] Umat = (double[,])mat_A.Clone();

            for (int k = 0; k < lengt - 1; k++)
            {
                for (int i = k + 1; i < lengt; i++) { Lmat[i, k] = mat_A[i, k] / mat_A[k, k]; }                    
                for (int j = k + 1; j < lengt; j++)
                {
                    for (int i = k + 1; i < lengt; i++)
                        Lmat[i, j] = Lmat[i, j] - Lmat[i, k] * Lmat[k, j];
                }
            }

            for (int j = 0; j < lengt; j++)
            {
                for (int i = 0; i < lengt; i++)
                {
                    if (i == j) { Lmat[j, i] = 1; }                        
                    else if (i > j) { Lmat[j, i] = 0; }                    
                    else if (i < j) { Lmat[j, i] = 0; }                    
                }
            }// L과 U 로 나눔
            // 이제 Ly=B 풀기
            double[] vec_Y = new double[lengt];
            for (int i = 0; i < lengt; i++)
            {
                vec_Y[i] = vec_B[i]/Lmat[i,i];
                for (int j = i + 1; j < lengt; j++)
                {
                    vec_B[j] = vec_B[j] - vec_Y[i] * Lmat[j,i];
                }
            }
            // 이제 Ux=y 풀기, x 반환
            double[] vec_X = new double[lengt];
            for(int i = lengt-1; i>-1; i--)
            {
                vec_X[i] = vec_Y[i] / Umat[i, i];
                for (int j = 0; j < i; j++)
                {
                    vec_Y[j] = vec_Y[j] - vec_X[i] * Umat[j, i];
                }
            }

            return vec_X;
        }
    }
}
