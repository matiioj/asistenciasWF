using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            UserControl btn1 = new UserControl();
            btn1.Location = new Point((this.Width - btn1.Width) / 2, (this.Height - btn1.Height) / 2);
            this.Controls.Add(btn1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonWidth = btn1.Width;
            int formWidth = this.Width;
            int buttonMargin = calcMargin(formWidth, buttonWidth);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private int calcMargin(int formWidth, int objectWidth) => (formWidth - objectWidth) / 2;
    }
}
