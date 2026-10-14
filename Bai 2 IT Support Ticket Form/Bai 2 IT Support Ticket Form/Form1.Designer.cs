namespace Bai_2_IT_Support_Ticket_Form
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

            // Thông tin phiếu
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblTicketID = new System.Windows.Forms.Label();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lblRequester = new System.Windows.Forms.Label();
            this.txtRequester = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();

            // Mức độ ưu tiên
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.radLow = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();

            // Phân loại & Chi tiết
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.chkDesktop = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();

            // Ảnh lỗi
            this.picErrorImage = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();

            // Nút chức năng
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.grpInfo.SuspendLayout();
            this.grpPriority.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorImage)).BeginInit();
            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 30);
            this.lblTitle.Text = "TIẾP NHẬN SỰ CỐ IT";

            // --- Group: Thông tin phiếu ---
            this.grpInfo.Controls.Add(this.dtpDate);
            this.grpInfo.Controls.Add(this.lblDate);
            this.grpInfo.Controls.Add(this.txtRequester);
            this.grpInfo.Controls.Add(this.lblRequester);
            this.grpInfo.Controls.Add(this.txtTicketID);
            this.grpInfo.Controls.Add(this.lblTicketID);
            this.grpInfo.Location = new System.Drawing.Point(20, 50);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(530, 90);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Thông tin phiếu";

            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Location = new System.Drawing.Point(15, 25);
            this.lblTicketID.Text = "Mã phiếu:";

            this.txtTicketID.Location = new System.Drawing.Point(90, 22);
            this.txtTicketID.Size = new System.Drawing.Size(150, 23);
            this.txtTicketID.TabIndex = 1;

            this.lblRequester.AutoSize = true;
            this.lblRequester.Location = new System.Drawing.Point(15, 55);
            this.lblRequester.Text = "Người y/c:";

            this.txtRequester.Location = new System.Drawing.Point(90, 52);
            this.txtRequester.Size = new System.Drawing.Size(150, 23);
            this.txtRequester.TabIndex = 2;

            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(260, 25);
            this.lblDate.Text = "Ngày ghi nhận:";

            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(360, 22);
            this.dtpDate.Size = new System.Drawing.Size(150, 23);
            this.dtpDate.TabIndex = 3;

            // --- Group: Mức độ ưu tiên ---
            this.grpPriority.Controls.Add(this.radHigh);
            this.grpPriority.Controls.Add(this.radMedium);
            this.grpPriority.Controls.Add(this.radLow);
            this.grpPriority.Location = new System.Drawing.Point(20, 150);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(530, 60);
            this.grpPriority.TabIndex = 4;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Mức độ ưu tiên";

            this.radLow.AutoSize = true;
            this.radLow.Location = new System.Drawing.Point(60, 25);
            this.radLow.Text = "Thấp";

            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(210, 25);
            this.radMedium.Text = "Trung bình";

            this.radHigh.AutoSize = true;
            this.radHigh.Location = new System.Drawing.Point(370, 25);
            this.radHigh.Text = "Khẩn cấp";

            // --- Group: Phân loại & Chi tiết ---
            this.grpDetails.Controls.Add(this.btnUpload);
            this.grpDetails.Controls.Add(this.picErrorImage);
            this.grpDetails.Controls.Add(this.chkPhone);
            this.grpDetails.Controls.Add(this.chkPrinter);
            this.grpDetails.Controls.Add(this.chkLaptop);
            this.grpDetails.Controls.Add(this.chkDesktop);
            this.grpDetails.Controls.Add(this.lblDevices);
            this.grpDetails.Controls.Add(this.cboCategory);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Location = new System.Drawing.Point(20, 220);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(530, 160);
            this.grpDetails.TabIndex = 5;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Phân loại & Chi tiết";

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 30);
            this.lblCategory.Text = "Loại sự cố:";

            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(140, 27);
            this.cboCategory.Size = new System.Drawing.Size(150, 23);
            this.cboCategory.TabIndex = 6;

            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(15, 65);
            this.lblDevices.Text = "Thiết bị ảnh hưởng:";

            this.chkDesktop.AutoSize = true;
            this.chkDesktop.Location = new System.Drawing.Point(140, 64);
            this.chkDesktop.Text = "Máy tính bàn";

            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(240, 64);
            this.chkLaptop.Text = "Laptop";

            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Location = new System.Drawing.Point(140, 94);
            this.chkPrinter.Text = "Máy in";

            this.chkPhone.AutoSize = true;
            this.chkPhone.Location = new System.Drawing.Point(240, 94);
            this.chkPhone.Text = "Điện thoại";

            this.picErrorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picErrorImage.Location = new System.Drawing.Point(340, 27);
            this.picErrorImage.Name = "picErrorImage";
            this.picErrorImage.Size = new System.Drawing.Size(170, 90);
            this.picErrorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErrorImage.TabIndex = 7;
            this.picErrorImage.TabStop = false;

            this.btnUpload.Location = new System.Drawing.Point(380, 125);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(90, 28);
            this.btnUpload.Text = "Tải ảnh lỗi";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // Nút Chức năng
            this.btnSubmit.Location = new System.Drawing.Point(150, 400);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Gửi yêu cầu";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnReset.Location = new System.Drawing.Point(290, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Cấu hình Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 460);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT Support Ticket Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpPriority.ResumeLayout(false);
            this.grpPriority.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lblRequester;
        private System.Windows.Forms.TextBox txtRequester;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton radLow;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radHigh;

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.CheckBox chkDesktop;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.PictureBox picErrorImage;
        private System.Windows.Forms.Button btnUpload;

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
    }
}