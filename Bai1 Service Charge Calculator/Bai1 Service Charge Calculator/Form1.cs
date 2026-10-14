using System;
using System.Windows.Forms;

namespace Bai1_Service_Charge_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Kiểm tra và ép kiểu dữ liệu
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ hợp lệ (số dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng khách hợp lệ (số nguyên dương).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Nếu người dùng không nhập % giảm, mặc định là 0
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                txtDiscount.Text = "0";
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Vui lòng nhập % giảm giá hợp lệ (từ 0 đến 100).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            // Tính toán tổng tiền
            decimal total = (price * quantity) * (100 - discount) / 100;

            // Hiển thị kết quả
            lblTotal.Text = $"Tổng tiền thanh toán: {total:N0} VNĐ";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Làm mới các ô nhập liệu
            txtPrice.Clear();
            txtQuantity.Clear();
            txtDiscount.Clear();
            lblTotal.Text = "Tổng tiền thanh toán: 0 VNĐ";

            // Đưa con trỏ chuột về ô đầu tiên
            txtPrice.Focus();
        }
    }
}