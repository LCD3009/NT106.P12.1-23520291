namespace NT106.P12_Lab1_23520291
{
    partial class Lab1_Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.find = new System.Windows.Forms.Button();
            this.inputDay = new System.Windows.Forms.TextBox();
            this.inputYear = new System.Windows.Forms.TextBox();
            this.inputMonth = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.lb_inputDay = new System.Windows.Forms.Label();
            this.lb_inputYear = new System.Windows.Forms.Label();
            this.lb_inputMonth = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Location = new System.Drawing.Point(171, 126);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 34);
            this.find.TabIndex = 0;
            this.find.Text = "Tìm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // inputDay
            // 
            this.inputDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDay.Location = new System.Drawing.Point(122, 44);
            this.inputDay.Name = "inputDay";
            this.inputDay.Size = new System.Drawing.Size(78, 26);
            this.inputDay.TabIndex = 1;
            // 
            // inputYear
            // 
            this.inputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputYear.Location = new System.Drawing.Point(498, 41);
            this.inputYear.Name = "inputYear";
            this.inputYear.Size = new System.Drawing.Size(78, 26);
            this.inputYear.TabIndex = 2;
            // 
            // inputMonth
            // 
            this.inputMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMonth.Location = new System.Drawing.Point(310, 44);
            this.inputMonth.Name = "inputMonth";
            this.inputMonth.Size = new System.Drawing.Size(78, 26);
            this.inputMonth.TabIndex = 3;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(302, 206);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(148, 26);
            this.result.TabIndex = 4;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(312, 126);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 34);
            this.clear.TabIndex = 5;
            this.clear.Text = "Xóa";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(453, 126);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 34);
            this.exit.TabIndex = 6;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lb_inputDay
            // 
            this.lb_inputDay.AutoSize = true;
            this.lb_inputDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputDay.Location = new System.Drawing.Point(71, 47);
            this.lb_inputDay.Name = "lb_inputDay";
            this.lb_inputDay.Size = new System.Drawing.Size(45, 20);
            this.lb_inputDay.TabIndex = 7;
            this.lb_inputDay.Text = "Ngày";
            // 
            // lb_inputYear
            // 
            this.lb_inputYear.AutoSize = true;
            this.lb_inputYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputYear.Location = new System.Drawing.Point(450, 44);
            this.lb_inputYear.Name = "lb_inputYear";
            this.lb_inputYear.Size = new System.Drawing.Size(42, 20);
            this.lb_inputYear.TabIndex = 8;
            this.lb_inputYear.Text = "Năm";
            // 
            // lb_inputMonth
            // 
            this.lb_inputMonth.AutoSize = true;
            this.lb_inputMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputMonth.Location = new System.Drawing.Point(250, 47);
            this.lb_inputMonth.Name = "lb_inputMonth";
            this.lb_inputMonth.Size = new System.Drawing.Size(54, 20);
            this.lb_inputMonth.TabIndex = 9;
            this.lb_inputMonth.Text = "Tháng";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.Location = new System.Drawing.Point(249, 209);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(47, 20);
            this.lb_result.TabIndex = 10;
            this.lb_result.Text = "Cung";
            // 
            // Lab1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 277);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lb_inputMonth);
            this.Controls.Add(this.lb_inputYear);
            this.Controls.Add(this.lb_inputDay);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputMonth);
            this.Controls.Add(this.inputYear);
            this.Controls.Add(this.inputDay);
            this.Controls.Add(this.find);
            this.Name = "Lab1_Bai4";
            this.Text = "Hoàng Đạo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox inputDay;
        private System.Windows.Forms.TextBox inputYear;
        private System.Windows.Forms.TextBox inputMonth;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label lb_inputDay;
        private System.Windows.Forms.Label lb_inputYear;
        private System.Windows.Forms.Label lb_inputMonth;
        private System.Windows.Forms.Label lb_result;
    }
}