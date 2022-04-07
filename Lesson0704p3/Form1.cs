using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson0704p3
{
    public partial class Form1 : Form
    {
        delegate void Way();
        Way myWay;


        public Form1()
        {
            InitializeComponent();
            myWay = new Way(Left);
        }

        void Left()
        {
            button1.Left += 5;
        }
        void Down()
        {
            button1.Top += 5;
        }
        void Right()
        {
            button1.Left -= 5;
        }
        void Up()
        {
            button1.Top -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left > Width - button1.Width-45)
            {
                button1.Left = Width - button1.Width-45;
                myWay = new Way(Down);

            }
            
            if (button1.Top > Height - button1.Height - 45)
            {
                button1.Top = Height - button1.Height - 45;
                myWay = new Way(Right);
            }

            if (button1.Left <0)
            {
                button1.Left =0;
                myWay = new Way(Up);

            }
            if(button1.Top<15)//0-под самый верх
            {
                button1.Top = 15;
                myWay = new Way(Left);
            }
            myWay();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }


    }
}
