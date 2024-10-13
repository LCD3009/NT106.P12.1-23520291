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
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }



        // hàm tìm sô nhỏ nhất
        public double Find_Min(double x, double y)
        {
            if (x < y) return x;
            return y;
        }

        // hàm tìm số lớn nhất
        public double Find_Max(double x, double y)
        {
            if (x > y) return x;
            return y;
        }

        // kiểm tra giá trị nhập vào chỉ là số
        public bool CheckBox()
        {
            if (input1.Text == "" || input2.Text == "" || input3.Text == "") return false;
            bool check1 = (input1.Text).All(char.IsDigit);
            bool check2 = (input2.Text).All(char.IsDigit);
            bool check3 = (input3.Text).All(char.IsDigit);
            if (check1 && check2 && check3) return true;
            return false;
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (CheckBox())
            {
                double num1 = Convert.ToDouble(input1.Text);
                double num2 = Convert.ToDouble(input2.Text);
                double num3 = Convert.ToDouble(input3.Text);
                double min = Find_Min(num1, Find_Min(num2, num3));
                double max = Find_Max(num1, Find_Max(num2, num3));
                outputMin.Text = min.ToString();
                outputMax.Text = max.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị là số");
                input1.Enabled = false;
                input2.Enabled = false;
                input3.Enabled = false;
                find.Enabled = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {

            input1.Clear();
            input2.Clear();
            input3.Clear();
            input1.Enabled = true;
            input2.Enabled = true;
            input3.Enabled = true;
            find.Enabled = true;
        }

        // chỉ cho phép nhâp kí tự số -- tham khảo ChatGPT
        private void text_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số và cũng không phải là phím backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự xuất hiện
                e.Handled = true;
            }
        }
    }
}
