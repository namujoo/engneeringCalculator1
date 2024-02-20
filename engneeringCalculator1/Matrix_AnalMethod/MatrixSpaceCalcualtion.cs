using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engneeringCalculator1.Matrix_AnalMethod
{
    internal partial class BasicMatrixControl
    {
        public List<double[]> RowSpace(in double[,] mat1)
        {
            int rownum=mat1.GetLength(0);
            int colnum=mat1.GetLength(1);
            double[] RowVector = new double[colnum];            
            List<double[]> listBasis = new List<double[]>();

            for(int i = 0; i < rownum; i++) // 총 행의 수만큼 실행
            {
                for(int j = 0; j < colnum; j++) // BasicCompo를 이번에 다룰 행으로 초기화: say R1
                {
                    RowVector[j] = mat1[i, j];
                }               
                if (listBasis.Count == 0)       // 아직 basis에 아무것도 없다면 
                {
                    listBasis.Add((double[])VectorNormalize(RowVector).Clone());  // 정규화된 초기 행을 벡터 공간에 넣기
                    continue;
                }
                for(int j = 0;j < listBasis.Count; j++) //배이스에 들어있는 정규 벡터 수만큼 돌아감
                {
                    double dotpro;
                    double[] TempArr= new double[colnum];
                    dotpro =DotProduct(RowVector, listBasis[j]);    // R1 내적 기저벡터= dotpro
                    TempArr = Vector_prod_Scalar(listBasis[j], dotpro);     // dotpro X 기저벡터
                    RowVector = VectorSubstrac(RowVector, TempArr);   
                    // 결국 이 과정은 현재 대상 BasisCompo의 구성 벡터에서 에서 기저벡터1을 제거하는것
                    for(int  k = 0; k < colnum; k++)
                    {
                        Console.WriteLine(RowVector[k]+"엘렐레");
                    }
                    Console.WriteLine("엘렐레\n");
                }
                if (vectorAbs(RowVector) < 0.00001) { continue; }     
                // 만족 한다면 결국 RowVector은 이미 기저공간에 있는 벡터들로 만 표현 가능한 것 따라서 버림, 다음 행으로 넘어가기
                RowVector = VectorNormalize(RowVector); // 0 이 아니라면 기저벡터로 표현 불가능한 성분 존재,
                listBasis.Add((double[])RowVector.Clone()); //그 성분을 정규화하여 basis에 추가                                   
            }
            for (int i = 0; i < listBasis.Count; i++)
            {
                for(int j = 0; j< listBasis[i].Length; j++)
                {
                    Console.WriteLine(listBasis[i][j]);
                }
                Console.WriteLine("\n");
            }
            return listBasis;
        }

        public List<double[]> ColSpace(in double[,] mat1)
        {
            int rownum = mat1.GetLength(0);
            int colnum = mat1.GetLength(1);
            double[] ColVector = new double[rownum];
            List<double[]> listBasis = new List<double[]>();

            for (int i = 0; i < colnum; i++) // 총 열의 수만큼 실행
            {
                for (int j = 0; j < rownum; j++) // BasicCompo를 이번에 다룰 열으로 초기화: say C1
                {
                    ColVector[j] = mat1[j, i];
                }
                if (listBasis.Count == 0)       // 아직 basis에 아무것도 없다면 
                {
                    listBasis.Add((double[])VectorNormalize(ColVector).Clone());  // 정규화된 초기 열을 벡터 공간에 넣기
                    continue;
                }
                for (int j = 0; j < listBasis.Count; j++) //배이스에 들어있는 정규 벡터 수만큼 돌아감
                {
                    double dotpro;
                    double[] TempArr = new double[rownum];
                    dotpro = DotProduct(ColVector, listBasis[j]);    // R1 내적 기저벡터= dotpro
                    TempArr = Vector_prod_Scalar(listBasis[j], dotpro);     // dotpro X 기저벡터
                    ColVector = VectorSubstrac(ColVector, TempArr);
                    // 결국 이 과정은 현재 대상 BasisCompo의 구성 벡터에서 에서 기저벡터1을 제거하는것                    
                }

                if (vectorAbs(ColVector) < 0.00001) { continue; }
                // 만족 한다면 결국 RowVector은 이미 기저공간에 있는 벡터들로 만 표현 가능한 것 따라서 버림, 다음 행으로 넘어가기
                ColVector = VectorNormalize(ColVector); // 0 이 아니라면 기저벡터로 표현 불가능한 성분 존재,
                listBasis.Add((double[])ColVector.Clone()); //그 성분을 정규화하여 basis에 추가                                   
            }
            for (int i = 0; i < listBasis.Count; i++)
            {
                for (int j = 0; j < listBasis[i].Length; j++)
                {
                    Console.WriteLine(listBasis[i][j]);
                }
                Console.WriteLine("\n");
            }
            return listBasis;
        }

        public double DotProduct(in double[] vec1, in double[] vec2)  // vec1 내적 vec2
        {
            int len=vec1.Length;
            double sum = 0;
            for(int i = 0;i < len;i++) {sum += vec1[i]*vec2[i];}
            return sum;
        }

        public double[] VectorSubstrac(in double[] vec1, in double[] vec2)    // vec1 - vec2 아니 원레 연산자 오버로딩 할라다가, 일이 너무 커질거 같아서;;ㅋㅎ
        {
            int len=vec1.Length;
            double[] vec3=new double[len];
            for(int i = 0; i< len; i++) { vec3[i] = vec1[i] - vec2[i]; }
            return vec3;
        }

        public double[] Vector_prod_Scalar(in double[] vec1, double r)    // vec1 X 상수
        {
            int len = vec1.Length;
            double[] vec2 = new double[len];
            for (int i = 0; i < len; i++) { vec2[i] = vec1[i]*r; }
            return vec2;
        }
    }
}
