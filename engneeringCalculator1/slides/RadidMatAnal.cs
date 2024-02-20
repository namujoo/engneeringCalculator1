using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1.slides
{
    public partial class RadidMatAnal : UserControl
    {
        private int Num = 0;

        public RadidMatAnal()
        {
            InitializeComponent();
            linkDiscrip.Text = "for wiki discription: here";    
            confirmBtn.Enabled = false;
        }

        private void linkDiscrip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            linkDiscrip.Links.Clear();
            linkDiscrip.Text = "for wiki discription: here";
            linkDiscrip.Links.Add(22, 4, "https://en.wikipedia.org/wiki/Eigenvalues_and_eigenvectors");
            Num = 1;
            confirmBtn.Enabled = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            linkDiscrip.Links.Clear();
            linkDiscrip.Text = "for wiki discription: here";
            linkDiscrip.Links.Add(22, 4, "https://en.wikipedia.org/wiki/Metric_space");
            Num = 2;
            confirmBtn.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            linkDiscrip.Links.Clear();
            linkDiscrip.Text = "for wiki discription: here";
            linkDiscrip.Links.Add(22, 4, "https://en.wikipedia.org/wiki/Condition_number");
            Num = 3;
            confirmBtn.Enabled = true;
        }
        
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            linkDiscrip.Links.Clear();
            linkDiscrip.Text = "for wiki discription: here";
            linkDiscrip.Links.Add(22, 4, "https://en.wikipedia.org/wiki/Norm_(mathematics)");
            Num = 4;
            confirmBtn.Enabled = true;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (Num)
            {
                case 0:
                    confirmBtn.Enabled = false;
                    break;
                case 1:
                    Matrix_AnalMethod.Eigenvalue eigenvalue= new Matrix_AnalMethod.Eigenvalue();
                    eigenvalue.ShowDialog();
                    break; 
                case 2: 
                    Matrix_AnalMethod.MatrixSpace matrixSpace= new Matrix_AnalMethod.MatrixSpace();
                    matrixSpace.ShowDialog();
                    break;
                case 3:
                    Matrix_AnalMethod.ConditionNum conditionNum= new Matrix_AnalMethod.ConditionNum();
                    conditionNum.ShowDialog();
                    break;
                case 4:
                    Matrix_AnalMethod.Norms norms=new Matrix_AnalMethod.Norms();
                    norms.ShowDialog();
                    break;

            }
        }
    }
}
