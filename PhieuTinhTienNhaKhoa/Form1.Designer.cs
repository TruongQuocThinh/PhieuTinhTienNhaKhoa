
namespace PhieuTinhTienNhaKhoa
{
    partial class Form1
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lbTramRang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.cbTramRang = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCaoVoi = new System.Windows.Forms.Label();
            this.nbNhoRang = new System.Windows.Forms.NumericUpDown();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.lbNhoRang = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nbNhoRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(159, 66);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(219, 22);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.TextChanged += new System.EventHandler(this.textHoTen_TextChanged);
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.HoTen_Validating);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(204, 324);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 22);
            this.txtTongTien.TabIndex = 3;
            // 
            // lbTramRang
            // 
            this.lbTramRang.AutoSize = true;
            this.lbTramRang.Location = new System.Drawing.Point(100, 160);
            this.lbTramRang.Name = "lbTramRang";
            this.lbTramRang.Size = new System.Drawing.Size(74, 17);
            this.lbTramRang.TabIndex = 4;
            this.lbTramRang.Text = "Trám răng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÍNH TIỀN NHA KHOA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(64, 66);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(55, 17);
            this.lbHoTen.TabIndex = 5;
            this.lbHoTen.Text = "Họ Tên";
            this.lbHoTen.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbTramRang
            // 
            this.cbTramRang.AutoSize = true;
            this.cbTramRang.Location = new System.Drawing.Point(204, 156);
            this.cbTramRang.Name = "cbTramRang";
            this.cbTramRang.Size = new System.Drawing.Size(82, 21);
            this.cbTramRang.TabIndex = 6;
            this.cbTramRang.Text = "200.000";
            this.cbTramRang.UseVisualStyleBackColor = true;
            this.cbTramRang.CheckedChanged += new System.EventHandler(this.cbTramRang_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "DỊCH VỤ SỬ DỤNG";
            // 
            // lbCaoVoi
            // 
            this.lbCaoVoi.AutoSize = true;
            this.lbCaoVoi.Location = new System.Drawing.Point(100, 192);
            this.lbCaoVoi.Name = "lbCaoVoi";
            this.lbCaoVoi.Size = new System.Drawing.Size(55, 17);
            this.lbCaoVoi.TabIndex = 9;
            this.lbCaoVoi.Text = "Cạo vôi\r\n";
            // 
            // nbNhoRang
            // 
            this.nbNhoRang.Location = new System.Drawing.Point(204, 281);
            this.nbNhoRang.Name = "nbNhoRang";
            this.nbNhoRang.Size = new System.Drawing.Size(82, 22);
            this.nbNhoRang.TabIndex = 10;
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Location = new System.Drawing.Point(204, 192);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(82, 21);
            this.cbCaoVoi.TabIndex = 11;
            this.cbCaoVoi.Text = "300.000";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            // 
            // lbNhoRang
            // 
            this.lbNhoRang.AutoSize = true;
            this.lbNhoRang.Location = new System.Drawing.Point(100, 281);
            this.lbNhoRang.Name = "lbNhoRang";
            this.lbNhoRang.Size = new System.Drawing.Size(67, 34);
            this.lbNhoRang.TabIndex = 12;
            this.lbNhoRang.Text = "Nhổ răng\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "(Đơn giá 100.000/răng)";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(100, 324);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(68, 17);
            this.lbTongTien.TabIndex = 14;
            this.lbTongTien.Text = "Tổng tiền";
            this.lbTongTien.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(99, 367);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTien.TabIndex = 15;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbNhoRang);
            this.Controls.Add(this.cbCaoVoi);
            this.Controls.Add(this.nbNhoRang);
            this.Controls.Add(this.lbCaoVoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTramRang);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTramRang);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbNhoRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lbTramRang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.CheckBox cbTramRang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCaoVoi;
        private System.Windows.Forms.NumericUpDown nbNhoRang;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.Label lbNhoRang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

