using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.P12_Lab1_23520291
{
    public partial class Lab1_Main : Form
    {
        public Lab1_Main()
        {
            InitializeComponent();
        }

        private void button_goto1_Click(object sender, EventArgs e)
        {
            Lab1_Bai1 bai1 = new Lab1_Bai1();
            bai1.Show();

        }

        private void button_goto2_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 bai2 = new Lab1_Bai2();
            bai2.Show();

        }

        private void button_goto3_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 bai1 = new Lab1_Bai3();
            bai1.Show();

        }

        private void button_goto4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 bai4 = new Lab1_Bai4();
            bai4.Show();

        }

        private void button_goto5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 bai5 = new Lab1_Bai5();
            bai5.Show();

        }
    }
}
