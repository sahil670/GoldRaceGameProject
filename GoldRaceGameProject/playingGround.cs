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
    public partial class playingGround : Form
    {
        Contestant _Henry = new Contestant();
        Contestant _Lilly = new Contestant();
        Contestant _Tommy = new Contestant();
        public playingGround()
        {
            
            InitializeComponent();
            _Henry.budgt = 50;
            Plyer1.Text = "Henry has 50" ;
            _Lilly.budgt = 50;
            Plyer2.Text = "Lilly has 50" ;
            _Tommy.budgt = 50;
             Plyer3.Text = "Tommy has 50" ;
        }

        private void check_bet_button_Click(object sender, EventArgs e)
        {
            //here we need to set the working of the game so thus we can start 
            if (Henry.Checked == true)
            {
                if (rb1.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb1.Text + " with " + rbAmt5.Text;
                        _Henry.bet = 1;
                        _Henry.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb1.Text + " with " + rbAmt10.Text;
                        _Henry.bet = 1;
                        _Henry.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb1.Text + " with " + rbAmt30.Text;
                        _Henry.bet = 1;
                        _Henry.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb1.Text + " with " + rbAmt40.Text;
                        _Henry.bet = 1;
                        _Henry.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else if (rb2.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb2.Text + " with " + rbAmt5.Text;
                        _Henry.bet = 2;
                        _Henry.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb2.Text + " with " + rbAmt10.Text;
                        _Henry.bet = 2;
                        _Henry.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb2.Text + " with " + rbAmt30.Text;
                        _Henry.bet = 2;
                        _Henry.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb2.Text + " with " + rbAmt40.Text;
                        _Henry.bet = 2;
                        _Henry.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else if (rb3.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb3.Text + " with " + rbAmt5.Text;
                        _Henry.bet = 3;
                        _Henry.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb3.Text + " with " + rbAmt10.Text;
                        _Henry.bet = 3;
                        _Henry.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb3.Text + " with " + rbAmt30.Text;
                        _Henry.bet = 3;
                        _Henry.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb3.Text + " with " + rbAmt40.Text;
                        _Henry.bet = 1;
                        _Henry.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }

                }

                // this work according to the selected condition

                else if (rb4.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb4.Text + " with " + rbAmt5.Text;
                        _Henry.bet = 4;
                        _Henry.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb4.Text + " with " + rbAmt10.Text;
                        _Henry.bet = 4;
                        _Henry.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb4.Text + " with " + rbAmt30.Text;
                        _Henry.bet = 4;
                        _Henry.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer1.Text = "Henry select " + rb4.Text + " with " + rbAmt40.Text;
                        _Henry.bet = 4;
                        _Henry.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else
                {
                    MessageBox.Show("Need to select the Tom for racing ");
                }
            }

            // concepts works according to selected 

            else if (Lilly.Checked == true)
            {
                if (rb1.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb1.Text + " with " + rbAmt5.Text;
                        _Lilly.bet = 1;
                        _Lilly.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb1.Text + " with " + rbAmt10.Text;
                        _Lilly.bet = 1;
                        _Lilly.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb1.Text + " with " + rbAmt30.Text;
                        _Lilly.bet = 1;
                        _Lilly.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb1.Text + " with " + rbAmt40.Text;
                        _Lilly.bet = 1;
                        _Lilly.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else if (rb2.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb2.Text + " with " + rbAmt5.Text;
                        _Lilly.bet = 2;
                        _Lilly.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb2.Text + " with " + rbAmt10.Text;
                        _Lilly.bet = 2;
                        _Lilly.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb2.Text + " with " + rbAmt30.Text;
                        _Lilly.bet = 2;
                        _Lilly.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb2.Text + " with " + rbAmt40.Text;
                        _Lilly.bet = 2;
                        _Lilly.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }

                // when radio button 3 is selected

                else if (rb3.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb3.Text + " with " + rbAmt5.Text;
                        _Lilly.bet = 3;
                        _Lilly.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb3.Text + " with " + rbAmt10.Text;
                        _Lilly.bet = 3;
                        _Lilly.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb3.Text + " with " + rbAmt30.Text;
                        _Lilly.bet = 3;
                        _Lilly.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb3.Text + " with " + rbAmt40.Text;
                        _Lilly.bet = 3;
                        _Lilly.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }

                }
                // if radio button 4 is selected  

                else if (rb4.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb4.Text + " with " + rbAmt5.Text;
                        _Lilly.bet = 4;
                        _Lilly.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {

                        Plyer2.Text = "Lilly select " + rb4.Text + " with " + rbAmt10.Text;
                        _Lilly.bet = 4;
                        _Lilly.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb4.Text + " with " + rbAmt30.Text;
                        _Lilly.bet = 4;
                        _Lilly.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer2.Text = "Lilly select " + rb4.Text + " with " + rbAmt40.Text;
                        _Lilly.bet = 4;
                        _Lilly.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else
                {
                    MessageBox.Show("Need to select the Tom for racing ");
                }
            }


            else if (Tommy.Checked == true)
            {
                if (rb1.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb1.Text + " with " + rbAmt5.Text;
                        _Tommy.bet = 1;
                        _Tommy.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb1.Text + " with " + rbAmt10.Text;
                        _Tommy.bet = 1;
                        _Tommy.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb1.Text + " with " + rbAmt30.Text;
                        _Tommy.bet = 1;
                        _Tommy.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb1.Text + " with " + rbAmt40.Text;
                        _Tommy.bet = 1;
                        _Tommy.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }

                // id second radio button is checked then the following condition is met

                else if (rb2.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb2.Text + " with " + rbAmt5.Text;
                        _Tommy.bet = 2;
                        _Tommy.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb2.Text + " with " + rbAmt10.Text;
                        _Tommy.bet = 2;
                        _Tommy.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb2.Text + " with " + rbAmt30.Text;
                        _Tommy.bet = 2;
                        _Tommy.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb2.Text + " with " + rbAmt40.Text;
                        _Tommy.bet = 2;
                        _Tommy.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else if (rb3.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb3.Text + " with " + rbAmt5.Text;
                        _Tommy.bet = 3;
                        _Tommy.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt10.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb3.Text + " with " + rbAmt10.Text;
                        _Tommy.bet = 3;
                        _Tommy.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb3.Text + " with " + rbAmt30.Text;
                        _Tommy.bet = 3;
                        _Tommy.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb3.Text + " with " + rbAmt40.Text;
                        _Tommy.bet = 3;
                        _Tommy.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }

                }
                else if (rb4.Checked == true)
                {
                    if (rbAmt5.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb4.Text + " with " + rbAmt5.Text;
                        _Tommy.bet = 4;
                        _Tommy.amt = Convert.ToInt32(rbAmt5.Text);
                        Run_race_button.Enabled = true;
                    }

                    else if (rbAmt10.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb4.Text + " with " + rbAmt10.Text;
                        _Tommy.bet = 4;
                        _Tommy.amt = Convert.ToInt32(rbAmt10.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt30.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb4.Text + " with " + rbAmt30.Text;
                        _Tommy.bet = 4;
                        _Tommy.amt = Convert.ToInt32(rbAmt30.Text);
                        Run_race_button.Enabled = true;
                    }
                    else if (rbAmt40.Checked == true)
                    {
                        Plyer3.Text = "Tommy select " + rb4.Text + " with " + rbAmt40.Text;
                        _Tommy.bet = 4;
                        _Tommy.amt = Convert.ToInt32(rbAmt40.Text);
                        Run_race_button.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Need to seltect the bet Amount ");
                    }
                }
                else
                {
                    MessageBox.Show("Need to select the Tom for racing ");
                }
            }

            else {
                MessageBox.Show("First Need to select Player ");
            }

        }

        private void Run_race_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            pictureBox2.Left += _Henry.runner();
            pictureBox3.Left += _Lilly.runner();
            pictureBox4.Left += _Lilly.runner();
            pictureBox5.Left += _Tommy.runner();

            if (pictureBox2.Left>900) {
                timer1.Stop();
                MessageBox.Show("Tom boy 1 won the race");
                if (_Henry.bet > 0) {
                    _Henry.budgt = _Henry.rslt(1);
                    
                    Plyer1.Text = "Henry has " + _Henry.budgt;
                }
                if (_Lilly.bet > 0)
                {
                    _Lilly.budgt = _Lilly.rslt(1);
                    Plyer2.Text = "Lilly has " + _Lilly.budgt;
                }
                if (_Tommy.bet > 0)
                {
                    _Tommy.budgt = _Tommy.rslt(1);
                    Plyer3.Text = "Tommy has " + _Tommy.budgt;
                }
                pictureBox2.Left = 0; pictureBox3.Left = 0; pictureBox4.Left = 0; pictureBox5.Left = 0;
                Run_race_button.Enabled = false;
                 _Henry = new Contestant();_Henry.bet = 0;
                 _Lilly = new Contestant();_Lilly.bet = 0;
                 _Tommy = new Contestant();_Tommy.bet = 0;

            }


            if (pictureBox3.Left > 900)
            {
                
                timer1.Stop();
                MessageBox.Show("Tom boy 2 won the race");
                if (_Henry.bet > 0)
                {
                    _Henry.budgt = _Henry.rslt(2);
                    Plyer1.Text = "Henry has " + _Henry.budgt;
                }
                if (_Lilly.bet > 0)
                {
                    _Lilly.budgt = _Lilly.rslt(2);
                    Plyer2.Text = "Lilly has " + _Lilly.budgt;
                }
                if (_Tommy.bet > 0)
                {
                    _Tommy.budgt = _Tommy.rslt(2);
                    Plyer3.Text = "Tommy has " + _Tommy.budgt;
                }
                pictureBox2.Left = 0; pictureBox3.Left = 0; pictureBox4.Left = 0; pictureBox5.Left = 0;
                Run_race_button.Enabled = false;
                _Henry = new Contestant(); _Henry.bet = 0;
                _Lilly = new Contestant(); _Lilly.bet = 0;
                _Tommy = new Contestant(); _Tommy.bet = 0;
            }


            if (pictureBox4.Left > 900)
            {
                timer1.Stop();
                MessageBox.Show("Tom boy 3 won the race");
                if (_Henry.bet > 0)
                {
                    _Henry.budgt = _Henry.rslt(3);
                    Plyer1.Text = "Henry has " + _Henry.budgt;
                }
                if (_Lilly.bet > 0)
                {
                    _Lilly.budgt = _Lilly.rslt(3);
                    Plyer2.Text = "Lilly has " + _Lilly.budgt;
                }
                if (_Tommy.bet > 0)
                {
                    _Tommy.budgt = _Tommy.rslt(3);
                    Plyer3.Text = "Tommy has " + _Tommy.budgt;
                }
                pictureBox2.Left = 0; pictureBox3.Left = 0; pictureBox4.Left = 0; pictureBox5.Left = 0;
                Run_race_button.Enabled = false;
                _Henry = new Contestant(); _Henry.bet = 0;
                _Lilly = new Contestant(); _Lilly.bet = 0;
                _Tommy = new Contestant(); _Tommy.bet = 0;
            }

            // it work according to the timer conditions

            if (pictureBox5.Left > 900)
            {
                timer1.Stop();
                MessageBox.Show("Tom boy 4 won the race");
                if (_Henry.bet > 0)
                {
                    _Henry.budgt = _Henry.rslt(4);
                    Plyer1.Text = "Henry has " + _Henry.budgt;
                }
                if (_Lilly.bet > 0)
                {
                    _Lilly.budgt = _Lilly.rslt(4);
                    Plyer2.Text = "Lilly has " + _Lilly.budgt;
                }
                if (_Tommy.bet > 0)
                {
                    _Tommy.budgt = _Tommy.rslt(4);
                    Plyer3.Text = "Tommy has " + _Tommy.budgt;
                }
                pictureBox2.Left = 0; pictureBox3.Left = 0; pictureBox4.Left = 0; pictureBox5.Left = 0;
                Run_race_button.Enabled = false;
                _Henry = new Contestant(); _Henry.bet = 0;
                _Lilly = new Contestant(); _Lilly.bet = 0;
                _Tommy = new Contestant(); _Tommy.bet = 0;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
