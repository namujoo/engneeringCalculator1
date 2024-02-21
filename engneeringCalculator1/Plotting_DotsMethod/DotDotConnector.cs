using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Plottable;

namespace engneeringCalculator1.Plotting_DotsMethod
{
    public partial class DotDotConnector : Form
    {
        public double[] xcor;
        public double[] ycor;
        public int PtnNum;
        public Label PtnIn_Head = new Label();
        Label[] Points;
        PointCalMethods PointCalMethods= new PointCalMethods();

        private ScottPlot.Plottable.ScatterPlot StrLine;
        private ScottPlot.Plottable.ScatterPlot polyLine;
        private ScottPlot.Plottable.ScatterPlot HumiteLine;
        private ScottPlot.Plottable.ScatterPlot CubicLine;
        public DotDotConnector()
        {
            InitializeComponent();
            DotsInput dotsInput = new DotsInput();
            dotsInput.SendCoord += new DotsInput.SendCoortData(ReceiveData);
            dotsInput.BtnData += new DotsInput.SendBtnData(ReceiveBtnClick);
            dotsInput.Location= new Point(10,0);
            panel1.Controls.Add(dotsInput);
        }


        public void ReceiveData(double[,] Inicoor)
        {
            // confirm 버튼을 누르면 실행
            // 데이터를 이 폼으로 전달
            PtnNum = Inicoor.GetLength(1);
            double[,] SortedPtns= new double[2,PtnNum];
            SortedPtns = PointCalMethods.SortPtns(Inicoor); // 솔팅하여 x좌표 작은 순으로 정렬
            xcor = new double[PtnNum];
            ycor = new double[PtnNum];            
            plot1.Visible = true;
            plot1.Plot.Clear();            
            for (int i = 0; i < PtnNum; i++)
            {
                xcor[i]= SortedPtns[0,i];
                ycor[i]= SortedPtns[1,i];
            }


            if (Points != null) { HideFixedPoint(PtnNum); } // 이전거 숨기기
            ShowFixedPoint(PtnNum); //지금거 보이기
                        
            // 그래프 출력(기본 점)
            plot1.Plot.AddScatterPoints(xcor, ycor, Color.Navy, 10, MarkerShape.filledCircle);
            plot1.Plot.SetAxisLimits(xcor.Min()-1, xcor.Max()+1, ycor.Min()-1, ycor.Max()+1);
            plot1.Plot.Legend();
            plot1.Refresh();

            // 선택창 위치 조절 및 출력
            checkBox1.Location = new Point(12, 20 * PtnNum + 100);
            checkBox1.Visible = true;
            checkBox2.Location = new Point(12, 20 * PtnNum + 120);
            checkBox2.Visible = true;
            checkBox3.Location = new Point(12, 20 * PtnNum + 140);
            checkBox3.Visible = true;
            checkBox4.Location = new Point(12, 20 * PtnNum + 160);
            checkBox4.Visible = true;
        }

        public void ShowFixedPoint(int PtnNum)
        {
            // 헤드 생성
            Font ft1 = new Font("Segoe Print", 15, FontStyle.Bold);            
            PtnIn_Head.Location = new Point(12, 45);
            PtnIn_Head.Text = "Point Input";
            PtnIn_Head.Font= ft1;
            PtnIn_Head.Visible = true;
            PtnIn_Head.Size = new Size(150,60);
            panel1.Controls.Add(PtnIn_Head);
            PtnIn_Head.BringToFront();

            //각각 좌표 띄우기
            Points = new Label[PtnNum];
            Font ft2 = new Font("Segoe Print", 10, FontStyle.Bold);
            for (int i = 0;i < PtnNum;i++)
            {
                Points[i]= new Label();
                Points[i].Font= ft2;
                Points[i].Location = new Point(12,20*i+75);
                Points[i].Text = "("+xcor[i].ToString()+", "+ycor[i].ToString()+")";
                Points[i].Visible = true;                
                panel1.Controls.Add(Points[i]);
                Points[i].BringToFront();
            }          
        }

        public void HideFixedPoint(int PtnNum)
        {
            PtnIn_Head.Visible = false;
            for (int i = 0; i < PtnNum;i++)
            {
                Points[i].Visible = false;
            }
        }

        public void ReceiveBtnClick()
        {
            //새로운 좌표 입력, 기존거 다 지우기
            plot1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            PtnIn_Head.Visible=false;
            if (Points != null)
            {
                int k=Points.GetLength(0);
                for (int i = 0; i < k; i++) { Points[i].Visible = false; }                
            }            
        }       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // just line 구현, 색은 Red                 
            if (checkBox1.Checked==true) 
            {
                List<double> xsList = new List<double>();
                List<double> ysList = new List<double>();
                for (int i = 0; i < PtnNum - 1; i++)
                {
                    for (double j = xcor[i]; j < xcor[i + 1]; j += 0.01)
                    {
                        xsList.Add(j);
                        ysList.Add((ycor[i + 1] - ycor[i]) / (xcor[i + 1] - xcor[i]) * (j - xcor[i]) + ycor[i]);
                    }
                }
                double[] xsArr = xsList.ToArray();
                double[] ysArr = ysList.ToArray();
                StrLine = plot1.Plot.AddScatterLines(xsArr, ysArr, Color.Red, 2);
                plot1.Plot.Legend();
                plot1.Refresh();
            }
            else
            {
                plot1.Plot.Remove(StrLine);
                plot1.Plot.Legend();
                plot1.Refresh();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // 폴리노미얼 구현, 색은 Blue
            int dotnum = (int)Math.Round( (xcor[PtnNum - 1] - xcor[0])*100);
            double[] xsArr = DataGen.Consecutive(dotnum, 0.01, xcor[0]);
            double[] ysArr = new double[dotnum];
            // Ax=B 를 푸는 코드
            // A는 입력값의 모노미얼 메트릭스, B는 y값, x는 폴리노미얼의 계수
            // A에는 조까튼 입력을 하지 않았다고 가정, 예외처리는 앞에서 구현하자.
            double[,] XnsMat = new double[PtnNum,PtnNum]; 
            double[] YnsVec = (double[])ycor.Clone();
            if (checkBox2.Checked == true)
            {
                // A 만들기
                for (int i = 0; i < PtnNum; i++)
                {
                    for (int j = 0; j < PtnNum; j++)
                    {
                        XnsMat[i, j] = Math.Pow(xcor[i], j);
                    }
                }
                // LU fac으로 x 구하기
                double[] Coeff_Vec = new double[PtnNum];
                Coeff_Vec = PointCalMethods.SolveLinear(XnsMat, YnsVec);
                // 이제 ysArr 구하기
                for (int i = 0; i < dotnum; i++)
                {
                    ysArr[i] = 0;
                    for (int k = 0; k < PtnNum; k++)
                    {
                        ysArr[i] += Coeff_Vec[k] * Math.Pow(xsArr[i], k);
                }
            }

                polyLine = plot1.Plot.AddScatterLines(xsArr, ysArr, Color.Red, 2);
                plot1.Plot.Legend();
                plot1.Refresh();
            }

            else
            {
                plot1.Plot.Remove(polyLine);
                plot1.Plot.Legend();
                plot1.Refresh();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Piecewise Polynomial 구현, 색은 Green
            // Hermit cubic 
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Piecewise Polynomial 구현, 색은 Orange
            // Cubic spline
        }        
    }
}
