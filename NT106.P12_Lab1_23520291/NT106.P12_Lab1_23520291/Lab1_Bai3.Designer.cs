namespace NT106.P12_Lab1_23520291
{
    partial class Lab1_Bai3
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
            this.read = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.lb_input = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.box_result = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.box_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read.Location = new System.Drawing.Point(153, 107);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 33);
            this.read.TabIndex = 0;
            this.read.Text = "Đọc";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(282, 33);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(139, 24);
            this.input.TabIndex = 1;
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Cursor = System.Windows.Forms.Cursors.Default;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(54, 36);
            this.result.MaximumSize = new System.Drawing.Size(500, 40);
            this.result.MinimumSize = new System.Drawing.Size(500, 40);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(500, 40);
            this.result.TabIndex = 2;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_input.Location = new System.Drawing.Point(212, 36);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(64, 18);
            this.lb_input.TabIndex = 3;
            this.lb_input.Text = "Nhập số";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(405, 107);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 33);
            this.exit.TabIndex = 4;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // box_result
            // 
            this.box_result.Controls.Add(this.result);
            this.box_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_result.Location = new System.Drawing.Point(12, 188);
            this.box_result.Name = "box_result";
            this.box_result.Size = new System.Drawing.Size(609, 154);
            this.box_result.TabIndex = 5;
            this.box_result.TabStop = false;
            this.box_result.Text = "KẾT QUẢ";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(279, 107);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 33);
            this.clear.TabIndex = 6;
            this.clear.Text = "Xóa";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Lab1_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(633, 283);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.box_result);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.input);
            this.Controls.Add(this.read);
            this.Name = "Lab1_Bai3";
            this.Text = "Đọc số";
            this.box_result.ResumeLayout(false);
            this.box_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox box_result;
        private System.Windows.Forms.Button clear;
    }
}