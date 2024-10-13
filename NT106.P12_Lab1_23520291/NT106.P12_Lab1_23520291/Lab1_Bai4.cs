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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        public int Find_Day_Max(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (year % 4 == 0) return 29;
                    else return 28;
                default:
                    return 30;
            }
        }

        public bool Check(int day, int month, int year)
        {
            if (year < 1) return false;
            else if (month < 1 || month > 12) return false;
            else if (day < 1 || day > Find_Day_Max(month, year)) return false;
            return true;
        }

        // tham khảo ChatGPT
        public string Find_Zodiac(int day, int month)
        {
            switch (month)
            {
                case 1:
                    return (day <= 19) ? "Ma Kết" : "Bảo Bình";
                case 2:
                    return (day <= 18) ? "Bảo Bình" : "Song Ngư";
                case 3:
                    return (day <= 20) ? "Song Ngư" : "Bạch Dương";
                case 4:
                    return (day <= 19) ? "Bạch Dương" : "Kim Ngưu";
                case 5:
                    return (day <= 20) ? "Kim Ngưu" : "Song Tử";
                case 6:
                    return (day <= 20) ? "Song Tử" : "Cự Giải";
                case 7:
                    return (day <= 22) ? "Cự Giải" : "Sư Tử";
                case 8:
                    return (day <= 22) ? "Sư Tử" : "Xử Nữ";
                case 9:
                    return (day <= 22) ? "Xử Nữ" : "Thiên Bình";
                case 10:
                    return (day <= 22) ? "Thiên Bình" : "Bọ Cạp";
                case 11:
                    return (day <= 21) ? "Bọ Cạp" : "Nhân Mã";
                case 12:
                    return (day <= 21) ? "Nhân Mã" : "Ma Kết";
                default:
                    return "Không tìm thấy";
            }

        }


        private void find_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt16(inputDay.Text);
            int month = Convert.ToInt16(inputMonth.Text);
            int year = Convert.ToInt16(inputYear.Text);
            if (!Check(day, month, year))
                MessageBox.Show("Ngày không tồn tại.");
            else
                result.Text = Find_Zodiac(day, month);
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

        private void clear_Click(object sender, EventArgs e)
        {
            inputDay.Clear();
            inputMonth.Clear();
            inputYear.Clear();
            result.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
