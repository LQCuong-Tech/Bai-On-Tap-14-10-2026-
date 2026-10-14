namespace Bai_3_Item_List_Manager
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

            // Khung nhập liệu (Left Group)
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.lblDVT = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();

            // Các nút chức năng
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();

            // Khung danh sách (Right Group)
            this.grpList = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.ListView();
            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDVT = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();

            this.grpInput.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();

            // Tiêu đề chính
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 30);
            this.lblTitle.Text = "QUẢN LÝ DANH MỤC VẬT TƯ";

            // --- Khung Nhập liệu (Left) ---
            this.grpInput.Controls.Add(this.txtDonGia);
            this.grpInput.Controls.Add(this.lblDonGia);
            this.grpInput.Controls.Add(this.cboDVT);
            this.grpInput.Controls.Add(this.lblDVT);
            this.grpInput.Controls.Add(this.txtTenVT);
            this.grpInput.Controls.Add(this.lblTenVT);
            this.grpInput.Controls.Add(this.txtMaVT);
            this.grpInput.Controls.Add(this.lblMaVT);
            this.grpInput.Location = new System.Drawing.Point(20, 60);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(280, 200);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin Vật tư";

            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(15, 35);
            this.lblMaVT.Text = "Mã vật tư:";

            this.txtMaVT.Location = new System.Drawing.Point(90, 32);
            this.txtMaVT.Size = new System.Drawing.Size(170, 23);
            this.txtMaVT.TabIndex = 1;

            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(15, 75);
            this.lblTenVT.Text = "Tên vật tư:";

            this.txtTenVT.Location = new System.Drawing.Point(90, 72);
            this.txtTenVT.Size = new System.Drawing.Size(170, 23);
            this.txtTenVT.TabIndex = 2;

            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(15, 115);
            this.lblDVT.Text = "Đơn vị tính:";

            this.cboDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVT.Location = new System.Drawing.Point(90, 112);
            this.cboDVT.Size = new System.Drawing.Size(170, 23);
            this.cboDVT.TabIndex = 3;

            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(15, 155);
            this.lblDonGia.Text = "Đơn giá:";

            this.txtDonGia.Location = new System.Drawing.Point(90, 152);
            this.txtDonGia.Size = new System.Drawing.Size(170, 23);
            this.txtDonGia.TabIndex = 4;

            // --- Các Nút chức năng ---
            this.btnAdd.Location = new System.Drawing.Point(20, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(170, 280);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(20, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 35);
            this.btnDelete.Text = "Xóa dòng";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClearAll.Location = new System.Drawing.Point(170, 330);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(130, 35);
            this.btnClearAll.Text = "Xóa toàn bộ";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);

            // --- Khung Danh sách (Right Group) ---
            this.grpList.Controls.Add(this.lstItems);
            this.grpList.Location = new System.Drawing.Point(320, 60);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(440, 305);
            this.grpList.TabIndex = 5;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách Vật tư / Linh kiện";

            // Cấu hình ListView
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.colMaVT, this.colTenVT, this.colDVT, this.colDonGia });
            this.lstItems.Location = new System.Drawing.Point(10, 25);
            this.lstItems.Size = new System.Drawing.Size(420, 270);
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);

            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 80;

            this.colTenVT.Text = "Tên Vật tư";
            this.colTenVT.Width = 160;

            this.colDVT.Text = "ĐVT";
            this.colDVT.Width = 70;

            this.colDonGia.Text = "Đơn giá (VNĐ)";
            this.colDonGia.Width = 100;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 390);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item List Manager";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;

        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDVT;
        private System.Windows.Forms.ColumnHeader colDonGia;
    }
}