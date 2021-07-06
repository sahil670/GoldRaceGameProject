using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldRaceGameProject
{
    public partial class Form1 : Form
    {
        int y = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            y++;
            label1.Text = "" + y;
            if (y==5) {
                timer1.Stop();
                playingGround ground = new playingGround();
                ground.Show();
                this.Hide();
            }
        }
    }
}
