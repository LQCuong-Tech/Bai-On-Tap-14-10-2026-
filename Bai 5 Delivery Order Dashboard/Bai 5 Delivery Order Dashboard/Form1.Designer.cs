namespace Bai_5_Delivery_Order_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();

            // Left Panel Controls
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblShippingType = new System.Windows.Forms.Label();
            this.cboShippingType = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();

            // Right Panel Controls
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Status Strip & Utils
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusWeight = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";

            // SplitContainer Panel 1 (Left)
            this.splitContainer1.Panel1.Controls.Add(this.grpCustomerInfo);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);

            // SplitContainer Panel 2 (Right)
            this.splitContainer1.Panel2.Controls.Add(this.grpDetails);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 30);
            this.splitContainer1.Size = new System.Drawing.Size(950, 500);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;

            // 
            // grpCustomerInfo (Trái)
            // 
            this.grpCustomerInfo.Controls.Add(this.lblNote);
            this.grpCustomerInfo.Controls.Add(this.cboShippingType);
            this.grpCustomerInfo.Controls.Add(this.lblShippingType);
            this.grpCustomerInfo.Controls.Add(this.txtPhone);
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCustomerInfo.Location = new System.Drawing.Point(10, 10);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(230, 480);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin Đơn hàng";

            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 30);
            this.lblCustomerName.Text = "Tên khách hàng:";
            this.txtCustomerName.Location = new System.Drawing.Point(18, 50);
            this.txtCustomerName.Size = new System.Drawing.Size(190, 23);

            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 90);
            this.lblPhone.Text = "Số điện thoại:";
            this.txtPhone.Location = new System.Drawing.Point(18, 110);
            this.txtPhone.Size = new System.Drawing.Size(190, 23);

            this.lblShippingType.AutoSize = true;
            this.lblShippingType.Location = new System.Drawing.Point(15, 150);
            this.lblShippingType.Text = "Loại vận chuyển:";
            this.cboShippingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippingType.Location = new System.Drawing.Point(18, 170);
            this.cboShippingType.Size = new System.Drawing.Size(190, 23);

            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.DimGray;
            this.lblNote.Location = new System.Drawing.Point(15, 250);
            this.lblNote.Size = new System.Drawing.Size(180, 45);
            this.lblNote.Text = "Phím tắt:\r\n- F2: Thêm dòng mới\r\n- Delete: Xóa dòng đang chọn";

            // 
            // grpDetails (Phải)
            // 
            this.grpDetails.Controls.Add(this.dgvItems);
            this.grpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetails.Location = new System.Drawing.Point(10, 10);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(676, 460);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Chi tiết Danh mục Hàng hóa";

            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false; // Tắt tự động thêm để dùng phím F2
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName, this.colQty, this.colWeight, this.colPrice, this.colTotal});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 19);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(670, 438);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellEndEdit);
            this.dgvItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvItems_CellValidating);

            this.colName.HeaderText = "Tên hàng";
            this.colQty.HeaderText = "Số lượng";
            this.colWeight.HeaderText = "Trọng lượng (kg)";
            this.colPrice.HeaderText = "Đơn giá";
            this.colTotal.HeaderText = "Thành tiền";
            this.colTotal.ReadOnly = true; // Chỉ đọc vì được tính tự động

            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusTime, this.lblStatusQty, this.lblStatusWeight, this.lblStatusTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(950, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblStatusTime.Name = "lblStatusTime";
            this.lblStatusTime.Size = new System.Drawing.Size(120, 17);
            this.lblStatusTime.Text = "Thời gian: --:--:--";

            this.lblStatusQty.Name = "lblStatusQty";
            this.lblStatusQty.Size = new System.Drawing.Size(120, 17);
            this.lblStatusQty.Text = "|  Tổng số lượng: 0";

            this.lblStatusWeight.Name = "lblStatusWeight";
            this.lblStatusWeight.Size = new System.Drawing.Size(130, 17);
            this.lblStatusWeight.Text = "|  Tổng trọng lượng: 0 kg";

            this.lblStatusTotal.Name = "lblStatusTotal";
            this.lblStatusTotal.Size = new System.Drawing.Size(120, 17);
            this.lblStatusTotal.Text = "|  Tổng tiền: 0 VNĐ";
            this.lblStatusTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusTotal.ForeColor = System.Drawing.Color.Red;

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Order Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblShippingType;
        private System.Windows.Forms.ComboBox cboShippingType;
        private System.Windows.Forms.Label lblNote;

        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusQty;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusWeight;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}