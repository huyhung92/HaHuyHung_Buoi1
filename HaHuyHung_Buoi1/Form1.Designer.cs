namespace HaHuyHung_Buoi1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxa = new TextBox();
            tbxb = new TextBox();
            tbxc = new TextBox();
            label6 = new Label();
            tbxkq = new TextBox();
            label7 = new Label();
            btngiai = new Button();
            btnxt = new Button();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 26);
            label1.Name = "label1";
            label1.Size = new Size(236, 24);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình Bậc 2  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 68);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Nhập a, b, c";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 103);
            label3.Name = "label3";
            label3.Size = new Size(17, 14);
            label3.TabIndex = 2;
            label3.Text = "a:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 133);
            label4.Name = "label4";
            label4.Size = new Size(18, 14);
            label4.TabIndex = 3;
            label4.Text = "b:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 163);
            label5.Name = "label5";
            label5.Size = new Size(17, 14);
            label5.TabIndex = 4;
            label5.Text = "c:";
            // 
            // tbxa
            // 
            tbxa.Location = new Point(101, 94);
            tbxa.Name = "tbxa";
            tbxa.Size = new Size(278, 23);
            tbxa.TabIndex = 5;
            // 
            // tbxb
            // 
            tbxb.Location = new Point(101, 123);
            tbxb.Name = "tbxb";
            tbxb.Size = new Size(278, 23);
            tbxb.TabIndex = 6;
            // 
            // tbxc
            // 
            tbxc.Location = new Point(101, 154);
            tbxc.Name = "tbxc";
            tbxc.Size = new Size(278, 23);
            tbxc.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(68, 199);
            label6.Name = "label6";
            label6.Size = new Size(52, 14);
            label6.TabIndex = 8;
            label6.Text = "Kết Quả";
            // 
            // tbxkq
            // 
            tbxkq.Location = new Point(68, 226);
            tbxkq.Name = "tbxkq";
            tbxkq.Size = new Size(311, 23);
            tbxkq.TabIndex = 9;
            tbxkq.TextChanged += tbxkq_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(69, 271);
            label7.Name = "label7";
            label7.Size = new Size(110, 18);
            label7.TabIndex = 10;
            label7.Text = "Chọn Thao Tác";
            // 
            // btngiai
            // 
            btngiai.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btngiai.Location = new Point(70, 307);
            btngiai.Name = "btngiai";
            btngiai.Size = new Size(89, 23);
            btngiai.TabIndex = 11;
            btngiai.Text = "Giải";
            btngiai.UseVisualStyleBackColor = true;
            btngiai.Click += btngiai_Click;
            // 
            // btnxt
            // 
            btnxt.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnxt.Location = new Point(182, 307);
            btnxt.Name = "btnxt";
            btnxt.Size = new Size(98, 23);
            btnxt.TabIndex = 12;
            btnxt.Text = "Xóa Trắng";
            btnxt.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnthoat.Location = new Point(304, 307);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(98, 23);
            btnthoat.TabIndex = 13;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(btnxt);
            Controls.Add(btngiai);
            Controls.Add(label7);
            Controls.Add(tbxkq);
            Controls.Add(label6);
            Controls.Add(tbxc);
            Controls.Add(tbxb);
            Controls.Add(tbxa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxa;
        private TextBox tbxb;
        private TextBox tbxc;
        private Label label6;
        private TextBox tbxkq;
        private Label label7;
        private Button btngiai;
        private Button btnxt;
        private Button btnthoat;
    }
}
