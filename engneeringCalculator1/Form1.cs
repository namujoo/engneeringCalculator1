using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1
{
    public partial class Form1 : Form
    {
        private slides.main slide1;
        private slides.chooseMenew slide2;

        public Form1()
        {
            InitializeComponent();
            InitializeUserControls();
        }
        private void InitializeUserControls()
        {
            // Instantiate uc1 and add it to the mainPanel
            slide1 = new slides.main();
            mainPanel.Controls.Add(slide1);
            slide1.Size = new System.Drawing.Size(800,800);

            // Wire up the button click event in uc1
            slide1.ButtonSTARTClick += Slide1_ButtonClick;
        }

        private void Slide1_ButtonClick(object sender, EventArgs e)
        {
            // Remove uc1 from mainPanel
            mainPanel.Controls.Remove(slide1);

            // Instantiate uc2 and add it to mainPanel
            slide2 = new slides.chooseMenew();
            mainPanel.Controls.Add(slide2);
        }
    }
}
