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
    public partial class chooseMenew : UserControl
    {
        slides.RadidMatAnal MatrixAnal=new slides.RadidMatAnal();
        slides.RadidPlotDots PlotDots = new slides.RadidPlotDots();
        public chooseMenew()
        {
            InitializeComponent();
        }

        private void matrixAnalysis_Click(object sender, EventArgs e)
        {
            pchoose1.Controls.Clear();    
            MatrixAnal.Location=new Point(0,0);
            pchoose1.Controls.Add(MatrixAnal);
        }

        private void LinearSystem_Click(object sender, EventArgs e)
        {
            pchoose1.Controls.Clear();
            MatrixAnal.Location = new Point(0, 90);
            pchoose1.Controls.Add(MatrixAnal);
        }

        private void plottingDot_Click(object sender, EventArgs e)
        {
            pchoose1.Controls.Clear();
            PlotDots.Location = new Point(0, 215);
            pchoose1.Controls.Add(PlotDots);
        }
    }
}
