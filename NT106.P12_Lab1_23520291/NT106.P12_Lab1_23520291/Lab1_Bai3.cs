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
    public partial class Lab1_Bai3 : Form
    {
        // 3 mảng dưới đây tham khảo từ ChatGpt
        // 1. Mảng chứa cách đọc các số từ 0 đến 9
        string[] ones = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        // 2. Mảng chứa cách đọc hàng chục
        string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        // 3. Mảng chứa cách đọc các đơn vị hàng nghìn, triệu, tỷ
        string[] bigNumbers = { "", "nghìn", "triệu", "tỷ" };

        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        // Hàm chuyển 3 chữ số thành chữ -- tham khảo ChatGpt và chỉnh sửa khác đi khoảng 60 - 70%
        string ConvertThreeDigits(int number)
        {
            string result = "";

            int hundreds = number / 100;
            int remainder = number % 100;
            int tensValue = remainder / 10;
            int onesValue = remainder % 10;
            // nếu hàng trăm lơn hơn 0 thì đọc, ngược lại thì bỏ qua
            if (hundreds > 0)
            {
                result += ones[hundreds] + " trăm";
                if (remainder != 0)
                    result += " ";
            }

            // nếu hàng chục lớn hơn 1 thì đọc bình thường, nhỏ hơn bằng 1 là trường hợp đặc biệt
            if (tensValue > 1)
            {
                result += tens[tensValue];
                // đọc hàng đơn vị
                if (onesValue > 0)
                {
                    if (onesValue == 1) result += " mốt";
                    if (onesValue == 5) result += " lăm";
                    else result += " " + ones[onesValue];
                }

            }
            else  // trường hợp đặc biệt
                if (remainder > 0)  // nếu có phần dư từ 01 đến 19, còn 00 thì bỏ qua
            {
                if (tensValue == 1)
                {
                    // khi phần dư là 10 đến 19
                    if (onesValue == 0) result += "mười";
                    else result += "mười " + ones[onesValue];
                }
                // khi phần dư 01 đến 09
                else
                    // khi có hàng trăm
                    if (tensValue == 0 && hundreds != 0) result += "lẻ " + ones[remainder];
                // không có hàng trăm
                else result += ones[onesValue];
            }
            return result;
        }

        // Hàm chuyển số thành chữ -- tham khảo ChatGpt và chỉnh sửa khác đi khoảng 70%
        string ConvertNumberToWords(long number)
        {
            if (number == 0) return "không";

            int bigNumberIndex = 0;
            string words = "";

            while (number > 0)
            {
                int threeDigits = (int)(number % 1000);
                number /= 1000;

                // khi phần đọc lớn hơn 0
                if (threeDigits > 0)
                {
                    if (number > 0) // khi phía trước còn số
                    {
                        if (threeDigits <= 99) // phần đọc chỉ có 2 chữ số
                        {
                            // từ 10 đến 99
                            if (threeDigits >= 10) words = "không trăm " + ConvertThreeDigits(threeDigits) + " " + bigNumbers[bigNumberIndex] + " " + words;
                            // từ 1 đến 9
                            if (threeDigits <= 9) words = "không trăm lẻ " + ConvertThreeDigits(threeDigits) + " " + bigNumbers[bigNumberIndex] + " " + words;
                        }
                        else  // phần đọc lớn hơn bằng 100
                            words = ConvertThreeDigits(threeDigits) + " " + bigNumbers[bigNumberIndex] + " " + words;

                    }
                    else // khi phía trước không còn số
                    {
                        words = ConvertThreeDigits(threeDigits) + " " + bigNumbers[bigNumberIndex] + " " + words;
                    }
                }

                // khi phần đọc bằng 0 và phía trước còn số và phần phía sau đã được đọc
                if (threeDigits == 0 && number > 0 && words != "")
                    words = "không " + bigNumbers[bigNumberIndex] + " " + words;
                bigNumberIndex++;
            }

            return words;
        }

        private void read_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá trị");
            }
            else
            {
                string output = ConvertNumberToWords(Convert.ToInt64(input.Text));
                // viết hoa chữ cái đầu
                output = char.ToUpper(output[0]) + output.Substring(1);
                result.Text = output;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Clear();
            result.Clear();
        }

        // chỉ cho phép nhâp kí tự số -- tham khảo ChatGPT
        private void input_KeyPress(object sender, KeyPressEventArgs e)
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
