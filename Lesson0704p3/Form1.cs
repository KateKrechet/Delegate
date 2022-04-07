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
        List<ButtonMove> buttonMove;
        public Form1()
        {
            InitializeComponent();
            buttonMove = new List<ButtonMove>()
            {
                new ButtonMove(button1,this),
                new ButtonMove(button2,this),
            };
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<buttonMove.Count;i++)
            buttonMove[i].Run();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }


    }
}
