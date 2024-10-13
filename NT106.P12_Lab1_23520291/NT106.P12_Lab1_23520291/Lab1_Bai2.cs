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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Clear();
            inputA.Clear();
            inputB.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Option1(int a, int b)
        {
            result.Text = "";
            int minus = b - a;
            if (minus <= 0)
            {
                result.Text = "Vui lòng nhập B lớn hơn A\t\n";
                return;
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    string s = minus.ToString() + " x " + i.ToString() + " = ";
                    result.Text = result.Text + s + (minus * i).ToString() + "\r\n";
                }
            }
        }
        
        public void Option2(int a, int b)
        {
                result.Text = "";
                if (a - b < 0)
                {
                    result.Text = "Vui lòng nhập A lớn hơn B\t\n";
                    return;
                }
                int hieuGiaithua = 1;
                for (int i = a - b; i > 0; i--) hieuGiaithua *= i;
                result.Text = "(" + a.ToString() + " - "
                                    + b.ToString() + ")! = "
                                    + hieuGiaithua.ToString()
                                    + "\r\n";
                double tong = 0;
                for (int i = 1; i <= b; i++)
                {
                    tong = tong + Math.Pow(a, i);
                }
                result.Text += "Tổng S = " + tong.ToString();

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

        private void operator_Click(object sender, EventArgs e)
        {
            if (inputA.Text == "" || inputB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị.");
                return;
            }

            // doi tu chuoi sang so
            int number_a = Convert.ToInt32(inputA.Text);
            int number_b = Convert.ToInt32(inputB.Text);
                
            // kiem tra lua chon 
            if (select.SelectedItem?.ToString() == "") MessageBox.Show("Vui lòng chọn phép tính");
            else if (select.SelectedItem?.ToString() == "Bảng cửu chương") Option1(number_a, number_b);
            else if (select.SelectedItem?.ToString() == "Tính toán giá trị") Option2(number_a, number_b); ;

        }
    }
}

