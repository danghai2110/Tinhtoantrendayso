namespace Tinhtoantrendayso
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
            txtsbd = new TextBox();
            label4 = new Label();
            txtskt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tongcstxt = new TextBox();
            tichcstxt = new TextBox();
            tongcsctxt = new TextBox();
            tongcsltxt = new TextBox();
            tinhtoan = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 34);
            label1.Name = "label1";
            label1.Size = new Size(364, 36);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN TRÊN DÃY SỐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 106);
            label2.Name = "label2";
            label2.Size = new Size(287, 36);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn của dãy số:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 106);
            label3.Name = "label3";
            label3.Size = new Size(170, 36);
            label3.TabIndex = 2;
            label3.Text = "Số bắt đầu:";
            // 
            // txtsbd
            // 
            txtsbd.Location = new Point(524, 98);
            txtsbd.Name = "txtsbd";
            txtsbd.Size = new Size(187, 44);
            txtsbd.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(755, 106);
            label4.Name = "label4";
            label4.Size = new Size(176, 36);
            label4.TabIndex = 4;
            label4.Text = "Số kết thúc:";
            // 
            // txtskt
            // 
            txtskt.Location = new Point(949, 103);
            txtskt.Name = "txtskt";
            txtskt.Size = new Size(194, 44);
            txtskt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 158);
            label5.Name = "label5";
            label5.Size = new Size(118, 36);
            label5.TabIndex = 6;
            label5.Text = "Kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 230);
            label6.Name = "label6";
            label6.Size = new Size(174, 36);
            label6.TabIndex = 7;
            label6.Text = "Tổng các số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 298);
            label7.Name = "label7";
            label7.Size = new Size(162, 36);
            label7.TabIndex = 8;
            label7.Text = "Tích các số";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 366);
            label8.Name = "label8";
            label8.Size = new Size(247, 36);
            label8.TabIndex = 9;
            label8.Text = "Tổng các số chẵn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 441);
            label9.Name = "label9";
            label9.Size = new Size(206, 36);
            label9.TabIndex = 10;
            label9.Text = "Tổng các số lẻ";
            // 
            // tongcstxt
            // 
            tongcstxt.Location = new Point(235, 222);
            tongcstxt.Name = "tongcstxt";
            tongcstxt.Size = new Size(212, 44);
            tongcstxt.TabIndex = 11;
            // 
            // tichcstxt
            // 
            tichcstxt.Location = new Point(241, 298);
            tichcstxt.Name = "tichcstxt";
            tichcstxt.Size = new Size(206, 44);
            tichcstxt.TabIndex = 12;
            // 
            // tongcsctxt
            // 
            tongcsctxt.Location = new Point(303, 371);
            tongcsctxt.Name = "tongcsctxt";
            tongcsctxt.Size = new Size(231, 44);
            tongcsctxt.TabIndex = 13;
            // 
            // tongcsltxt
            // 
            tongcsltxt.Location = new Point(285, 448);
            tongcsltxt.Name = "tongcsltxt";
            tongcsltxt.Size = new Size(249, 44);
            tongcsltxt.TabIndex = 14;
            // 
            // tinhtoan
            // 
            tinhtoan.Location = new Point(562, 555);
            tinhtoan.Name = "tinhtoan";
            tinhtoan.Size = new Size(196, 54);
            tinhtoan.TabIndex = 15;
            tinhtoan.Text = "Tính toán";
            tinhtoan.UseVisualStyleBackColor = true;
            tinhtoan.Click += btnTinhToan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 648);
            Controls.Add(tinhtoan);
            Controls.Add(tongcsltxt);
            Controls.Add(tongcsctxt);
            Controls.Add(tichcstxt);
            Controls.Add(tongcstxt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtskt);
            Controls.Add(label4);
            Controls.Add(txtsbd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtsbd;
        private Label label4;
        private TextBox txtskt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tongcstxt;
        private TextBox tichcstxt;
        private TextBox tongcsctxt;
        private TextBox tongcsltxt;
        private Button tinhtoan;
    }
}
