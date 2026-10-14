using System;
using System.Windows.Forms;

namespace Bai_3_Item_List_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ComboBox khi load form
            cboDVT.Items.AddRange(new string[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDVT.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtMaVT.Text) || string.IsNullOrWhiteSpace(txtTenVT.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra đơn giá phải là số
            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và lớn hơn hoặc bằng 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra Mã VT không được trùng lặp
            foreach (ListViewItem item in lstItems.Items)
            {
                if (item.Text.Equals(txtMaVT.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư này đã tồn tại trong danh sách! Vui lòng nhập mã khác.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaVT.Focus();
                    return;
                }
            }

            // 4. Thêm vào ListView
            ListViewItem lvi = new ListViewItem(txtMaVT.Text.Trim()); // Cột 1: Mã VT
            lvi.SubItems.Add(txtTenVT.Text.Trim());                   // Cột 2: Tên VT
            lvi.SubItems.Add(cboDVT.SelectedItem.ToString());         // Cột 3: ĐVT
            lvi.SubItems.Add(donGia.ToString("N0"));                  // Cột 4: Đơn giá

            lstItems.Items.Add(lvi);
            ResetInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trên danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text) || string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin cho dòng đang được chọn
            ListViewItem selectedItem = lstItems.SelectedItems[0];
            selectedItem.SubItems[1].Text = txtTenVT.Text.Trim();
            selectedItem.SubItems[2].Text = cboDVT.SelectedItem.ToString();
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                // Hiển thị hộp thoại xác nhận Yes/No
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa vật tư này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lstItems.Items.Remove(lstItems.SelectedItems[0]);
                    ResetInputs();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (lstItems.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có CHẮC CHẮN muốn xóa TOÀN BỘ danh sách vật tư không?", "Xóa tất cả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lstItems.Items.Clear();
                    ResetInputs();
                }
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng click chọn 1 dòng, đổ dữ liệu ngược lên Textbox
            if (lstItems.SelectedItems.Count > 0)
            {
                ListViewItem item = lstItems.SelectedItems[0];
                txtMaVT.Text = item.Text; // Cột 1
                txtTenVT.Text = item.SubItems[1].Text; // Cột 2
                cboDVT.SelectedItem = item.SubItems[2].Text; // Cột 3

                // Loại bỏ dấu phẩy/chấm ở đơn giá để nhập liệu không bị lỗi
                txtDonGia.Text = item.SubItems[3].Text.Replace(",", "").Replace(".", "");

                txtMaVT.Enabled = false; // Khóa Mã VT không cho sửa (Primary Key)
            }
            else
            {
                // Nếu bấm ra khoảng trống, reset lại
                ResetInputs();
            }
        }

        private void ResetInputs()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            if (cboDVT.Items.Count > 0) cboDVT.SelectedIndex = 0;

            txtMaVT.Enabled = true; // Mở khóa lại Mã VT
            txtMaVT.Focus();
        }
    }
}