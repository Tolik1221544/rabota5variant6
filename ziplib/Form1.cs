using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ziplib
{
    public partial class Form1 : Form
    {
        
        int countElement = 0;
        Point LocMouse;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            if (countElement % 2 == 0)
            {
               
                Button bn = new Button();
                bn.Name = "But" + countElement;
                bn.Location = LocMouse;
                bn.Size = new Size(100, 24);
                bn.Text = "Кнопка";
                bn.TabIndex = countElement;
                this.Controls.Add(bn);
                countElement++;
            }
            else
            {
              
                TextBox tx = new TextBox();
                tx.Name = "tex" + countElement;
                tx.Location = new Point(100 + LocMouse.X, LocMouse.Y);
                tx.Size = new Size(100, 24);
                tx.Text = "";
                tx.TabIndex = countElement;
                this.Controls.Add(tx);
                countElement++;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            LocMouse = new Point(e.X, e.Y);
        }
    }
}
