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
    public partial class main : UserControl
    {
        public event EventHandler ButtonSTARTClick;

        public main()
        {
            InitializeComponent();
            InitializeButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
        private void InitializeButton()
        {
            Button btnSwitch = new Button();
            btnSwitch.Text = "Start";
            btnSwitch.Click += BtnSwitch_Click;
            btnSwitch.Location = new System.Drawing.Point(520,160);
            btnSwitch.Size=new System.Drawing.Size(90, 47);
            btnSwitch.BackColor = System.Drawing.Color.LightPink;
            btnSwitch.Font = new Font("Segoe Script", 16, FontStyle.Bold);
            Controls.Add(btnSwitch);
        }
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            // Raise the event to notify the main form
            ButtonSTARTClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
