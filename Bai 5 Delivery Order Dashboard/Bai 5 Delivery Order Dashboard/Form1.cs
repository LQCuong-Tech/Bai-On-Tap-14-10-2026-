using System;
using System.Windows.Forms;

namespace Bai_5_Delivery_Order_Dashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Bật tính năng bắt phím tắt ở cấp độ Form
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShippingType.Items.AddRange(new string[] { "Giao hàng tiêu chuẩn", "Giao hàng hỏa tốc", "Giao tiết kiệm" });
            cboShippingType.SelectedIndex = 0;

            // Khởi động đồng hồ cho StatusStrip
            timer1.Start();
        }

        // Bẫy phím tắt F2 và Delete
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Nhấn F2: Thêm dòng mới
            if (e.KeyCode == Keys.F2)
            {
                dgvItems.Rows.Add(); // Thêm 1 dòng trống
                e.Handled = true;
            }
            // Nhấn Delete: Xóa dòng đang chọn
            else if (e.KeyCode == Keys.Delete)
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvItems.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                dgvItems.Rows.Remove(row);
                            }
                        }
                        UpdateTotals(); // Tính lại tổng sau khi xóa
                    }
                    e.Handled = true;
                }
            }
        }

        // Cập nhật đồng hồ realtime
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatusTime.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Bật ErrorProvider cảnh báo đỏ nếu Số lượng hoặc Trọng lượng <= 0
        private void dgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Kiểm tra cột Số lượng (1) và Trọng lượng (2)
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                if (decimal.TryParse(e.FormattedValue.ToString(), out decimal value))
                {
                    if (value <= 0)
                    {
                        // Hiển thị icon cảnh báo đỏ ngay trong ô nhập
                        dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Giá trị phải lớn hơn 0";
                        errorProvider1.SetError(dgvItems, $"Lỗi nhập liệu ở dòng {e.RowIndex + 1}");
                    }
                    else
                    {
                        dgvItems.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
                        errorProvider1.Clear();
                    }
                }
            }
        }

        // Tự động tính Thành tiền từng dòng khi sửa xong một ô
        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvItems.Rows[e.RowIndex];

            // Lấy giá trị, nếu rỗng thì coi là 0
            decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal qty);
            decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal weight);
            decimal.TryParse(row.Cells[3].Value?.ToString(), out decimal price);

            // Tính thành tiền cho dòng
            row.Cells[4].Value = qty * price;

            // Gọi hàm tính lại Tổng đơn hàng ở StatusStrip
            UpdateTotals();
        }

        // Hàm tính toán tổng cộng và hiển thị xuống StatusStrip
        private void UpdateTotals()
        {
            decimal totalQty = 0;
            decimal totalWeight = 0;
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells[1].Value?.ToString(), out decimal qty))
                    totalQty += qty;

                if (decimal.TryParse(row.Cells[2].Value?.ToString(), out decimal weight))
                    totalWeight += weight;

                if (decimal.TryParse(row.Cells[4].Value?.ToString(), out decimal priceRow))
                    totalPrice += priceRow;
            }

            lblStatusQty.Text = $"|  Tổng số lượng: {totalQty:N0}";
            lblStatusWeight.Text = $"|  Tổng trọng lượng: {totalWeight:N2} kg";
            lblStatusTotal.Text = $"|  Tổng tiền: {totalPrice:N0} VNĐ";
        }
    }
}