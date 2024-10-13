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
    public partial class Lab1_Bai5 : Form
    {
        static int countID = 0;

        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputName.Clear();
            inputScore1.Clear();
            inputScore2.Clear();
            inputScore3.Clear();
            selectGender.Items.Clear();
        }

        // xếp loại
        private string Classification(double average, double score1, double score2, double score3)
        {
            if (average >= 8 && score1 >= 6.5 && score2 >= 6.5 && score3 >= 6.5)
                return "Giỏi";
            else if (average >= 6.5 && score1 >= 5 && score2 >= 5 && score3 >= 5)
                return "Khá";
            else if (average >= 5 && score1 >= 3.5 && score2 >= 3.5 && score3 >= 3.5)
                return "Trung Bình";
            else if (average >= 3.5 && score1 >= 2 && score2 >= 2 && score3 >= 2)
                return "Yếu";
            else
                return "Kém";
        }

        // lưu giá trị vào bảng
        private void save_Click(object sender, EventArgs e)
        {
            
            string tempName = inputName.Text;
            string tempGender = selectGender.SelectedItem?.ToString();

            // TryParse - Có tham khảo ChatGpt
            if (double.TryParse(inputScore1.Text, out double tempScore1) && double.TryParse(inputScore2.Text, out double tempScore2) && double.TryParse(inputScore3.Text, out double tempScore3))
            {
                // kiểm tra giá trị của điểm
                if (tempScore1 > 10 || tempScore1 < 0 || tempScore2 > 10 || tempScore2 < 0 || tempScore3 > 10 || tempScore3 < 0)
                {
                    MessageBox.Show("Vui lòng nhập điểm hợp lệ.");
                    return;
                }

                countID++;
                string id = "TS" + countID.ToString("000");
                double averageScore = (tempScore1 + tempScore2 + tempScore3) / 3;
                string rank = Classification(averageScore, tempScore1, tempScore2, tempScore1);
                string[] row = { id, tempName, tempGender, tempScore1.ToString(), tempScore2.ToString(), tempScore3.ToString(), averageScore.ToString("0.00"), rank };
                list.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ.");
            }
        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
                {
                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa hàng tại chỉ số e.RowIndex
                      list.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void thongke_Click(object sender, EventArgs e)
        {
            int tongThiSinh = list.Rows.Count-1;
            if(tongThiSinh == 0)
            {
                MessageBox.Show("Chưa có thí sinh nào");
                return;
            }
                string thiSinh_max = string.Empty;
                double dtb_max = 0;

                int gioi = 0;
                int kha = 0;
                int trungbinh = 0;
                int yeukem = 0;

            for (int i = 1; i < list.Rows.Count; i++)
            {
                DataGridViewRow row = list.Rows[i];
                string ten = row.Cells["name"].Value?.ToString();
                double diemTrungBinh = Convert.ToDouble(row.Cells["average"].Value ?.ToString());
                string rank = row.Cells["rank"].Value?.ToString(); ;

                // Kiểm tra thí sinh có điểm trung bình cao nhất
                if (diemTrungBinh > dtb_max)
                    {
                        dtb_max = diemTrungBinh;
                        thiSinh_max = ten;
                    }

                    // Thống kê xếp loại
                    switch (rank)
                    {
                        case "Giỏi":
                            gioi++;
                            break;
                        case "Khá":
                            kha++;
                            break;
                        case "Trung bình":
                            trungbinh++;
                            break;
                        case "Yếu":
                        case "Kém":
                            yeukem++;
                            break;
                    }
                }

            // Hiển thị kết quả thống kê
            MessageBox.Show(
                "Số lượng thí sinh dự thi: " + tongThiSinh.ToString() +
                "\nThí sinh có điểm trung bình cao nhất: " + thiSinh_max + " " + dtb_max.ToString() +
                "\nSố lượng thí sinh xếp loại Giỏi: " + gioi.ToString() +
                "\nSố lượng thí sinh xếp loại Khá: " + kha.ToString() +
                "\nSố lượng thí sinh xếp loại Trung bình: " + trungbinh.ToString() +
                "\nSố lượng thí sinh không đạt (Yếu/Kém): " + yeukem.ToString() +
                "\nThống kê thí sinh");
        
        }
    }
}
