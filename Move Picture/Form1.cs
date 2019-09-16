using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtBxName.Location = new Point(txtBxName.Location.X - 5, txtBxName.Location.Y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtBxName.Location = new Point(txtBxName.Location.X + 5, txtBxName.Location.Y);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtBxName.Location = new Point(txtBxName.Location.X , txtBxName.Location.Y -5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtBxName.Location = new Point(txtBxName.Location.X , txtBxName.Location.Y + 5);
        }
    }
}
