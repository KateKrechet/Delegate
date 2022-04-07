using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson0704p3
{
    class ButtonMove
    {
        Form form;
        Button button1;
        delegate void Way();
        Way myWay;


        public ButtonMove(Button button,Form form)
        {
            button1 = button;
            this.form = form;
            myWay = new Way(Left);
        }
        void Left()
        {
            button1.Left += 5;
            if (button1.Left > form.Width - button1.Width - 45)
            {
                button1.Left = form.Width - button1.Width - 45;
                myWay = new Way(Down);

            }
        }
        void Down()
        {
            button1.Top += 5;
            if (button1.Top > form.Height - button1.Height - 45)
            {
                button1.Top = form.Height- button1.Height - 45;
                myWay = new Way(Right);
            }
        }
        void Right()
        {
            button1.Left -= 5;
            if (button1.Left < 0)
            {
                button1.Left = 0;
                myWay = new Way(Up);

            }
        }
        void Up()
        {
            button1.Top -= 5;
            if (button1.Top < 15)//0-под самый верх
            {
                button1.Top = 15;
                myWay = new Way(Left);
            }
        }
        public void Run()
        {
            myWay();
        }

    }
}
