using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engneeringCalculator1.Plotting_DotsMethod
{
    public partial class DotsInput : UserControl
    {
        int ptnNum;
        public double[,] XYcoord;
        public TextBox[] PointX_coor;
        public TextBox[] PointY_coor;
        public Label[] PointLabel;
        public delegate void SendCoortData(double[,] XYcoor);
        public event SendCoortData SendCoord;
        public delegate void SendBtnData();
        public event SendBtnData BtnData;
        public DotsInput()
        {
            InitializeComponent();
        }

        private void DotInput_Click(object sender, EventArgs e)
        {
            ptnNum= Int32.Parse(PointNumText.Text);
            DotPanel.Controls.Clear();
            PointX_coor = new TextBox[ptnNum];
            PointY_coor = new TextBox[ptnNum];
            PointLabel = new Label[ptnNum];

            DotPanel.Visible = true;
            textBox2.Visible = true;
            textBox2.BringToFront();
            textBox4.Visible = true;
            textBox4.BringToFront();

            for (int i = 0; i < ptnNum; i++)
            {
                PointX_coor[i] = new TextBox();
                PointY_coor[i] = new TextBox();
                PointLabel[i] = new Label();

                PointX_coor[i].Size = new Size(80, 20);
                PointY_coor[i].Size = new Size(80, 20);
                PointLabel[i].Size = new Size(45, 20);

                PointX_coor[i].Location = new Point(45, 20 * (i+1));
                PointY_coor[i].Location = new Point(125, 20 * (i+1));
                PointLabel[i].Location = new Point(0, 20 * (i+1));

                PointLabel[i].Text = "Point "+(i+1).ToString();

                DotPanel.Controls.Add(PointX_coor[i]);
                DotPanel.Controls.Add(PointY_coor[i]);
                DotPanel.Controls.Add(PointLabel[i]);
            }
            Button confirmBtn = new Button();
            confirmBtn.Location = new Point(80, 20 * (ptnNum + 1));
            confirmBtn.BackColor = Color.HotPink;
            confirmBtn.Text = "Confirm";
            confirmBtn.Click += new EventHandler(confirmBtn_Click);
            DotPanel.Controls.Add(confirmBtn);

            this.BtnData();
        }

        void confirmBtn_Click(object sender, EventArgs e)
        {
            XYcoord= new double[2, ptnNum];
            for(int i = 0; i<ptnNum; i++)
            {
                XYcoord[0, i] = double.Parse(PointX_coor[i].Text);
                XYcoord[1, i] = double.Parse(PointY_coor[i].Text);
            }
            textBox2.Visible = false;
            textBox4.Visible = false;
            DotPanel.Visible = false;
            this.SendCoord(XYcoord);
        }

        private void PointNumText_Click(object sender, EventArgs e)
        {
            PointNumText.Text = "";
        }
    }
}
