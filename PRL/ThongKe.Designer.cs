namespace PRL
{
    partial class ThongKe
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
            panel_Thongke = new Panel();
            txtDoanhThuDVNgay = new TextBox();
            txtDoanhThuNgay = new TextBox();
            txtSoLuongVeNgay = new TextBox();
            label3 = new Label();
            dgvThongKe = new DataGridView();
            panel_Thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel_Thongke
            // 
            panel_Thongke.Controls.Add(txtDoanhThuDVNgay);
            panel_Thongke.Controls.Add(txtDoanhThuNgay);
            panel_Thongke.Controls.Add(txtSoLuongVeNgay);
            panel_Thongke.Controls.Add(label3);
            panel_Thongke.Controls.Add(dgvThongKe);
            panel_Thongke.Location = new Point(2, 3);
            panel_Thongke.Name = "panel_Thongke";
            panel_Thongke.Size = new Size(923, 940);
            panel_Thongke.TabIndex = 0;
            // 
            // txtDoanhThuDVNgay
            // 
            txtDoanhThuDVNgay.BackColor = Color.FromArgb(255, 188, 18);
            txtDoanhThuDVNgay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoanhThuDVNgay.Location = new Point(6, 785);
            txtDoanhThuDVNgay.Multiline = true;
            txtDoanhThuDVNgay.Name = "txtDoanhThuDVNgay";
            txtDoanhThuDVNgay.Size = new Size(910, 46);
            txtDoanhThuDVNgay.TabIndex = 55;
            txtDoanhThuDVNgay.Text = "Doanh Thu Dịch Vụ : ";
            // 
            // txtDoanhThuNgay
            // 
            txtDoanhThuNgay.BackColor = Color.FromArgb(255, 188, 18);
            txtDoanhThuNgay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoanhThuNgay.Location = new Point(6, 713);
            txtDoanhThuNgay.Multiline = true;
            txtDoanhThuNgay.Name = "txtDoanhThuNgay";
            txtDoanhThuNgay.Size = new Size(910, 46);
            txtDoanhThuNgay.TabIndex = 54;
            txtDoanhThuNgay.Text = "Doanh Thu Ngày : ";
            // 
            // txtSoLuongVeNgay
            // 
            txtSoLuongVeNgay.BackColor = Color.FromArgb(255, 188, 18);
            txtSoLuongVeNgay.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongVeNgay.Location = new Point(6, 643);
            txtSoLuongVeNgay.Multiline = true;
            txtSoLuongVeNgay.Name = "txtSoLuongVeNgay";
            txtSoLuongVeNgay.Size = new Size(910, 46);
            txtSoLuongVeNgay.TabIndex = 54;
            txtSoLuongVeNgay.Text = "Số Lượng Vé Bán Trong Ngày : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(205, 29);
            label3.Name = "label3";
            label3.Size = new Size(491, 32);
            label3.TabIndex = 49;
            label3.Text = "Doanh Thu Trong Ngày Và  Số Lượng Vé Bán";
            label3.Click += label3_Click;
            // 
            // dgvThongKe
            // 
            dgvThongKe.BackgroundColor = Color.White;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(6, 184);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.RowTemplate.Height = 29;
            dgvThongKe.Size = new Size(917, 418);
            dgvThongKe.TabIndex = 0;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 0, 0);
            ClientSize = new Size(937, 876);
            Controls.Add(panel_Thongke);
            Name = "ThongKe";
            Text = "ThongKe";
            panel_Thongke.ResumeLayout(false);
            panel_Thongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Thongke;
        private DataGridView dgvThongKe;
        private Label label3;
        private TextBox txtDoanhThuNgay;
        private TextBox txtSoLuongVeNgay;
        private TextBox txtDoanhThuDVNgay;
    }
}