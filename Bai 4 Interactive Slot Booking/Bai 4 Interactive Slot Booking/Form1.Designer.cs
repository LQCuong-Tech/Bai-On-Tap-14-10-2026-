namespace Bai_4_Interactive_Slot_Booking
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpSeats = new System.Windows.Forms.FlowLayoutPanel();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.cboTimeSlot = new System.Windows.Forms.ComboBox();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();

            this.grpStats.SuspendLayout();
            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(230, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.Text = "SƠ ĐỒ CHỌN VỊ TRÍ";

            // FlowLayoutPanel - Nơi chứa 20 nút tự động sinh ra
            this.flpSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpSeats.Location = new System.Drawing.Point(20, 60);
            this.flpSeats.Name = "flpSeats";
            this.flpSeats.Size = new System.Drawing.Size(400, 320); // Kích thước này vừa đẹp cho 5 nút ngang (5 cột), 4 nút dọc (4 hàng)
            this.flpSeats.TabIndex = 0;

            // Khung Thống kê & Nút chức năng bên phải
            this.grpStats.Controls.Add(this.btnCancelAll);
            this.grpStats.Controls.Add(this.btnConfirm);
            this.grpStats.Controls.Add(this.lblTotal);
            this.grpStats.Controls.Add(this.lblSelectedCount);
            this.grpStats.Controls.Add(this.cboTimeSlot);
            this.grpStats.Controls.Add(this.lblTimeSlot);
            this.grpStats.Location = new System.Drawing.Point(440, 60);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(250, 320);
            this.grpStats.TabIndex = 1;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Thông tin Đặt bàn";

            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(20, 40);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Text = "Chọn khung giờ:";

            this.cboTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimeSlot.Location = new System.Drawing.Point(20, 60);
            this.cboTimeSlot.Name = "cboTimeSlot";
            this.cboTimeSlot.Size = new System.Drawing.Size(200, 23);
            this.cboTimeSlot.TabIndex = 2;
            this.cboTimeSlot.SelectedIndexChanged += new System.EventHandler(this.cboTimeSlot_SelectedIndexChanged);

            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSelectedCount.Location = new System.Drawing.Point(20, 110);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Text = "Số vị trí đang chọn: 0";

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(20, 150);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "Tạm tính tiền: 0 VNĐ";

            this.btnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.Location = new System.Drawing.Point(20, 210);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 40);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận đặt";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAll.Location = new System.Drawing.Point(20, 260);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(200, 40);
            this.btnCancelAll.TabIndex = 4;
            this.btnCancelAll.Text = "Hủy chọn tất cả";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 400);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.flpSeats);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interactive Slot Booking";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpSeats;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.ComboBox cboTimeSlot;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancelAll;
    }
}