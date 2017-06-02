using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int speed = 10;
        int moveX = 0;
        int moveY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY = -speed;
            }
            if (e.KeyCode == Keys.Down)
            {
                moveY = speed;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveX = speed;
            }
            if(e.KeyCode == Keys.Left){
                moveX = -speed;
            }
            if (e.KeyCode == Keys.Space) {
                pictureBox2.Left = pictureBox1.Left;
                pictureBox2.Top = pictureBox1.Top;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            moveX = 0;
            moveY = 0;
        }
    }
}
