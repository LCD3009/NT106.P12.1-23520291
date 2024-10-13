namespace NT106.P12_Lab1_23520291
{
    partial class Lab1_Bai2
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
            this.clear = new System.Windows.Forms.Button();
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.ComboBox();
            this.operating = new System.Windows.Forms.Button();
            this.cle = new System.Windows.Forms.Button();
            this.lb_inputA = new System.Windows.Forms.Label();
            this.lb_inputB = new System.Windows.Forms.Label();
            this.box_result = new System.Windows.Forms.GroupBox();
            this.box_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(331, 191);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 37);
            this.clear.TabIndex = 0;
            this.clear.Text = "Xóa";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // inputA
            // 
            this.inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputA.Location = new System.Drawing.Point(141, 49);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(138, 26);
            this.inputA.TabIndex = 1;
            // 
            // inputB
            // 
            this.inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputB.Location = new System.Drawing.Point(430, 49);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(138, 26);
            this.inputB.TabIndex = 2;
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Location = new System.Drawing.Point(116, 25);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(427, 116);
            this.result.TabIndex = 3;
            // 
            // select
            // 
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.select.Location = new System.Drawing.Point(237, 118);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(167, 28);
            this.select.TabIndex = 4;
            // 
            // operating
            // 
            this.operating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operating.Location = new System.Drawing.Point(92, 191);
            this.operating.Name = "operating";
            this.operating.Size = new System.Drawing.Size(172, 37);
            this.operating.TabIndex = 5;
            this.operating.Text = "Tính toán giá trị";
            this.operating.UseVisualStyleBackColor = true;
            this.operating.Click += new System.EventHandler(this.operator_Click);
            // 
            // cle
            // 
            this.cle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cle.Location = new System.Drawing.Point(473, 191);
            this.cle.Name = "cle";
            this.cle.Size = new System.Drawing.Size(75, 37);
            this.cle.TabIndex = 6;
            this.cle.Text = "Thoát";
            this.cle.UseVisualStyleBackColor = true;
            // 
            // lb_inputA
            // 
            this.lb_inputA.AutoSize = true;
            this.lb_inputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputA.Location = new System.Drawing.Point(73, 52);
            this.lb_inputA.Name = "lb_inputA";
            this.lb_inputA.Size = new System.Drawing.Size(62, 20);
            this.lb_inputA.TabIndex = 7;
            this.lb_inputA.Text = "Nhập A";
            // 
            // lb_inputB
            // 
            this.lb_inputB.AutoSize = true;
            this.lb_inputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inputB.Location = new System.Drawing.Point(362, 52);
            this.lb_inputB.Name = "lb_inputB";
            this.lb_inputB.Size = new System.Drawing.Size(62, 20);
            this.lb_inputB.TabIndex = 8;
            this.lb_inputB.Text = "Nhập B";
            // 
            // box_result
            // 
            this.box_result.Controls.Add(this.result);
            this.box_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_result.Location = new System.Drawing.Point(25, 262);
            this.box_result.Name = "box_result";
            this.box_result.Size = new System.Drawing.Size(591, 161);
            this.box_result.TabIndex = 9;
            this.box_result.TabStop = false;
            this.box_result.Text = "KẾT QUẢ";
            // 
            // Lab1_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 414);
            this.Controls.Add(this.box_result);
            this.Controls.Add(this.lb_inputB);
            this.Controls.Add(this.lb_inputA);
            this.Controls.Add(this.cle);
            this.Controls.Add(this.operating);
            this.Controls.Add(this.select);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.clear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lab1_Bai2";
            this.Text = "Tính toán";
            this.box_result.ResumeLayout(false);
            this.box_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Button operating;
        private System.Windows.Forms.Button cle;
        private System.Windows.Forms.Label lb_inputA;
        private System.Windows.Forms.Label lb_inputB;
        private System.Windows.Forms.GroupBox box_result;
    }
}