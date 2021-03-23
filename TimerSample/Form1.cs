using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerSample
{
    public partial class timerSample : Form
    {
        int a = 0;
        
        public timerSample()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (a == 0)
            {
                this.lblName.Text = "Ibu";
                a++;
            }
            else if (a == 1)
            {
                this.lblName.Text = "Akhila";
                a++;
            }
            else if (a == 2)
            {
                this.lblName.Text = "arun";
                a++;
            }
            else if (a == 3)
            {
                this.lblName.Text = "mila";
                a++;
            }
            else if (a == 4)
            {
                this.lblName.Text = "indu";
                a++;
            }
            else
            {
                this.lblName.Text = "";
                this.BackColor = Color.Red;

            }
        }
    }
}
