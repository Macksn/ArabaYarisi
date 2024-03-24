using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace araba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int puan = 0, a = 1;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                biz.Left -= 5;

            }
            if (e.KeyCode == Keys.D)
            {
                biz.Left += 5;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          puan++;

            label1.Text = puan.ToString();
            if (a == 1)
            {
               dusman.Top += 10;
                dusman2.Top += 10;
            }
            if ((biz.Top + 25 >= dusman.Top) && (biz.Top <= dusman.Top + 25))
            {
                if ((biz.Left + 25 >= dusman.Left) && (biz.Left <= dusman.Left + 25))
                {
                    timer2.Stop();
                    MessageBox.Show("yandın");
                }
                  }
            if ((biz.Top + 25 >= dusman2.Top) && (biz.Top <= dusman2.Top + 25))
            {
                if ((biz.Left + 25 >= dusman2.Left) && (biz.Left <= dusman2.Left + 25))
                {
                    timer2.Stop();
                    MessageBox.Show("yandın");

                }
            }
            if ((dusman2.Top + 25 >= 454) && (dusman.Top + 25 >= 454))
            {
                dusman2.Location = new Point(rnd.Next(190,260),0);
                dusman.Location = new Point(rnd.Next(228,413),-120);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
             timer2.Start();
             timer1.Start();
          }   
        }
    }

