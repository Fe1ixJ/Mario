using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace SupermarioTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int gravity = 1;
        int Rörelse = 0;
        int ticks = 0;
        bool MarioFlying = true;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                timer2.Stop();
                if (gravity != 0)
                    gravity = 8;

            }

            if (e.KeyCode == Keys.Left)
                Rörelse = 0;
            if (e.KeyCode == Keys.Right)
                Rörelse = 0;

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (!MarioFlying)
                {
                    gravity = -64;
                    MarioFlying = true;

                }

            }

            if (e.KeyCode == Keys.Left)
                Rörelse = -15;
            if (e.KeyCode == Keys.Right)
                Rörelse = 15;

            else if (e.KeyCode == Keys.Enter)
                timer1.Start();


        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mario.Top += gravity;
            Mario.Left += Rörelse;


            if (Mario.Bottom == Marken.Top)
            {
                gravity = 0;
                MarioFlying = false;
                timer2.Stop();
            }
            if (Mario.Bottom == Block1.Top)
            {
                gravity = 0;
                MarioFlying = false;
                timer2.Stop();
            }
            if (Mario.Bottom == Block2.Top)
            {
                gravity = 0;
                MarioFlying = false;
                timer2.Stop();
            }

            // Console.WriteLine(MarioFlying.ToString());
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            /* ticks++;
             if (ticks>3)
             {
                 ticks = 3;

             }*/

            Console.WriteLine(ticks.ToString());

        }

        private void Mario_Click(object sender, EventArgs e)
        {

        }
    }
}
