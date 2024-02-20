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
    public partial class RadidPlotDots : UserControl
    {
        private int Num=0;
        public RadidPlotDots()
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            linkDiscrip.Links.Clear();
            linkDiscrip.Text = "for wiki discription: here";
            linkDiscrip.Links.Add(22, 4, "https://en.wikipedia.org/wiki/Metric_space");
            Num = 2;
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
                    Plotting_DotsMethod.DotDotConnector dotDot= new Plotting_DotsMethod.DotDotConnector();                    
                    dotDot.ShowDialog ();
                    break;
                case 2:
                    Plotting_DotsMethod.DotApproximation DotApprox = new Plotting_DotsMethod.DotApproximation();
                    DotApprox.ShowDialog();
                    break;               
            }
        }
    }
}
