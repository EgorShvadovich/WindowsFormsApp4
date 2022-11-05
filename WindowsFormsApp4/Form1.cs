using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && this.Top > 0)
                SetDesktopLocation(this.Left, this.Top - 50);
            else if (e.KeyCode == Keys.Down && this.Top + this.Height < Screen.PrimaryScreen.Bounds.Bottom)
                SetDesktopLocation(this.Left, this.Top + 50);
            else if (e.KeyCode == Keys.Left && this.Left > 0)
                SetDesktopLocation(this.Left - 50, this.Top);
            else if (e.KeyCode == Keys.Right && (this.Left + this.Width) < Screen.PrimaryScreen.Bounds.Right)
                SetDesktopLocation(this.Left + 50, this.Top);

        }
    }
}
