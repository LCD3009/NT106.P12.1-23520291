namespace NT106.P12_Lab1_23520291
{
    partial class Lab1_Bai5
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
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rank = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.boxInfo = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.lb_inputScore3 = new System.Windows.Forms.Label();
            this.lb_inputScore2 = new System.Windows.Forms.Label();
            this.lb_inputScore1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputScore2 = new System.Windows.Forms.TextBox();
            this.inputScore3 = new System.Windows.Forms.TextBox();
            this.inputScore1 = new System.Windows.Forms.TextBox();
            this.selectGender = new System.Windows.Forms.ComboBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.lb_list = new System.Windows.Forms.Label();
            this.thongke = new System.Windows.Forms.Button();
            this.lab1Bai5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.boxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab1Bai5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.gender,
            this.Score1,
            this.score2,
            this.score3,
            this.average,
            this.rank,
            this.delete});
            this.list.Location = new System.Drawing.Point(23, 245);
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.Size = new System.Drawing.Size(777, 227);
            this.list.TabIndex = 0;
            this.list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.HeaderText = "Họ và Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Phái";
            this.gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 75;
            // 
            // Score1
            // 
            this.Score1.HeaderText = "Môn 1";
            this.Score1.Name = "Score1";
            this.Score1.ReadOnly = true;
            this.Score1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Score1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Score1.Width = 75;
            // 
            // score2
            // 
            this.score2.HeaderText = "Môn 2";
            this.score2.Name = "score2";
            this.score2.ReadOnly = true;
            this.score2.Width = 75;
            // 
            // score3
            // 
            this.score3.HeaderText = "Môn 3";
            this.score3.Name = "score3";
            this.score3.ReadOnly = true;
            this.score3.Width = 75;
            // 
            // average
            // 
            this.average.HeaderText = "Trung bình";
            this.average.Name = "average";
            this.average.ReadOnly = true;
            this.average.Width = 75;
            // 
            // rank
            // 
            this.rank.HeaderText = "Xếp loại";
            this.rank.Items.AddRange(new object[] {
            "Giỏi",
            "Khá",
            "Trung bình",
            "Yếu",
            "Kém"});
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete.HeaderText = "Xóa";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xóa";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // boxInfo
            // 
            this.boxInfo.Controls.Add(this.clear);
            this.boxInfo.Controls.Add(this.save);
            this.boxInfo.Controls.Add(this.lb_inputScore3);
            this.boxInfo.Controls.Add(this.lb_inputScore2);
            this.boxInfo.Controls.Add(this.lb_inputScore1);
            this.boxInfo.Controls.Add(this.label2);
            this.boxInfo.Controls.Add(this.label1);
            this.boxInfo.Controls.Add(this.inputScore2);
            this.boxInfo.Controls.Add(this.inputScore3);
            this.boxInfo.Controls.Add(this.inputScore1);
            this.boxInfo.Controls.Add(this.selectGender);
            this.boxInfo.Controls.Add(this.inputName);
            this.boxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInfo.Location = new System.Drawing.Point(33, 22);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Size = new System.Drawing.Size(499, 188);
            this.boxInfo.TabIndex = 1;
            this.boxInfo.TabStop = false;
            this.boxInfo.Text = "Nhập Thí Sinh";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(133, 139);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 32);
            this.clear.TabIndex = 10;
            this.clear.Text = "Xóa";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.White;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(26, 139);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 32);
            this.save.TabIndex = 9;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // lb_inputScore3
            // 
            this.lb_inputScore3.AutoSize = true;
            this.lb_inputScore3.Location = new System.Drawing.Point(281, 111);
            this.lb_inputScore3.Name = "lb_inputScore3";
            this.lb_inputScore3.Size = new System.Drawing.Size(77, 16);
            this.lb_inputScore3.TabIndex = 2;
            this.lb_inputScore3.Text = "Điểm Môn 3";
            // 
            // lb_inputScore2
            // 
            this.lb_inputScore2.AutoSize = true;
            this.lb_inputScore2.Location = new System.Drawing.Point(281, 75);
            this.lb_inputScore2.Name = "lb_inputScore2";
            this.lb_inputScore2.Size = new System.Drawing.Size(77, 16);
            this.lb_inputScore2.TabIndex = 8;
            this.lb_inputScore2.Text = "Điểm Môn 2";
            // 
            // lb_inputScore1
            // 
            this.lb_inputScore1.AutoSize = true;
            this.lb_inputScore1.Location = new System.Drawing.Point(281, 36);
            this.lb_inputScore1.Name = "lb_inputScore1";
            this.lb_inputScore1.Size = new System.Drawing.Size(77, 16);
            this.lb_inputScore1.TabIndex = 7;
            this.lb_inputScore1.Text = "Điểm Môn 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và Tên";
            // 
            // inputScore2
            // 
            this.inputScore2.Location = new System.Drawing.Point(360, 72);
            this.inputScore2.Name = "inputScore2";
            this.inputScore2.Size = new System.Drawing.Size(114, 22);
            this.inputScore2.TabIndex = 4;
            // 
            // inputScore3
            // 
            this.inputScore3.Location = new System.Drawing.Point(360, 108);
            this.inputScore3.Name = "inputScore3";
            this.inputScore3.Size = new System.Drawing.Size(114, 22);
            this.inputScore3.TabIndex = 3;
            // 
            // inputScore1
            // 
            this.inputScore1.Location = new System.Drawing.Point(360, 33);
            this.inputScore1.Name = "inputScore1";
            this.inputScore1.Size = new System.Drawing.Size(114, 22);
            this.inputScore1.TabIndex = 2;
            // 
            // selectGender
            // 
            this.selectGender.BackColor = System.Drawing.Color.White;
            this.selectGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectGender.FormattingEnabled = true;
            this.selectGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.selectGender.Location = new System.Drawing.Point(87, 71);
            this.selectGender.Name = "selectGender";
            this.selectGender.Size = new System.Drawing.Size(149, 24);
            this.selectGender.TabIndex = 1;
            // 
            // inputName
            // 
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Location = new System.Drawing.Point(87, 35);
            this.inputName.MaxLength = 30;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(149, 22);
            this.inputName.TabIndex = 0;
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(20, 225);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(105, 13);
            this.lb_list.TabIndex = 2;
            this.lb_list.Text = "Danh Sách Thí Sinh";
            // 
            // thongke
            // 
            this.thongke.Location = new System.Drawing.Point(725, 215);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(75, 23);
            this.thongke.TabIndex = 3;
            this.thongke.Text = "Thống Kê";
            this.thongke.UseVisualStyleBackColor = true;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // lab1Bai5BindingSource
            // 
            this.lab1Bai5BindingSource.DataSource = typeof(NT106.P12_Lab1_23520291.Lab1_Bai5);
            // 
            // Lab1_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(822, 452);
            this.Controls.Add(this.thongke);
            this.Controls.Add(this.lb_list);
            this.Controls.Add(this.boxInfo);
            this.Controls.Add(this.list);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab1_Bai5";
            this.Text = "Thông tin thí sinh";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.boxInfo.ResumeLayout(false);
            this.boxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab1Bai5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list;
        private System.Windows.Forms.GroupBox boxInfo;
        private System.Windows.Forms.TextBox inputScore2;
        private System.Windows.Forms.TextBox inputScore3;
        private System.Windows.Forms.TextBox inputScore1;
        private System.Windows.Forms.ComboBox selectGender;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label lb_inputScore2;
        private System.Windows.Forms.Label lb_inputScore1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_inputScore3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score1;
        private System.Windows.Forms.DataGridViewTextBoxColumn score2;
        private System.Windows.Forms.DataGridViewTextBoxColumn score3;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.DataGridViewComboBoxColumn rank;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.BindingSource lab1Bai5BindingSource;
        private System.Windows.Forms.Label lb_list;
        private System.Windows.Forms.Button thongke;
    }
}