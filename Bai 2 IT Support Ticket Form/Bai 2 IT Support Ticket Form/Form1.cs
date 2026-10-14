using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_2_IT_Support_Ticket_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu cho ComboBox khi form vừa load
            cboCategory.Items.AddRange(new string[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboCategory.SelectedIndex = 0; // Chọn mặc định mục đầu tiên
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh lỗi";
            openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh lên PictureBox
                picErrorImage.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtTicketID.Text) || string.IsNullOrWhiteSpace(txtRequester.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu và Người yêu cầu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Lấy thông tin cơ bản
            string ticketID = txtTicketID.Text;
            string requester = txtRequester.Text;
            string date = dtpDate.Value.ToString("dd/MM/yyyy");

            // 2. Lấy mức độ ưu tiên (RadioButton)
            string priority = "Chưa xác định";
            if (radLow.Checked) priority = radLow.Text;
            if (radMedium.Checked) priority = radMedium.Text;
            if (radHigh.Checked) priority = radHigh.Text;

            // 3. Lấy loại sự cố (ComboBox)
            string category = cboCategory.SelectedItem?.ToString() ?? "Chưa xác định";

            // 4. Lấy thiết bị ảnh hưởng (CheckBox)
            List<string> devices = new List<string>();
            if (chkDesktop.Checked) devices.Add(chkDesktop.Text);
            if (chkLaptop.Checked) devices.Add(chkLaptop.Text);
            if (chkPrinter.Checked) devices.Add(chkPrinter.Text);
            if (chkPhone.Checked) devices.Add(chkPhone.Text);
            string affectedDevices = devices.Count > 0 ? string.Join(", ", devices) : "Không có";

            // Có đính kèm ảnh không?
            string hasImage = picErrorImage.Image != null ? "Có" : "Không";

            // Tạo chuỗi tóm tắt
            string summary = "==== TÓM TẮT YÊU CẦU ====\n\n" +
                             $"- Mã phiếu: {ticketID}\n" +
                             $"- Người yêu cầu: {requester}\n" +
                             $"- Ngày ghi nhận: {date}\n" +
                             $"- Mức độ ưu tiên: {priority}\n" +
                             $"- Loại sự cố: {category}\n" +
                             $"- Thiết bị ảnh hưởng: {affectedDevices}\n" +
                             $"- Có ảnh chụp đính kèm: {hasImage}";

            // Hiển thị kết quả bằng MessageBox
            MessageBox.Show(summary, "Thông tin Sự cố IT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Làm mới các ô nhập liệu
            txtTicketID.Clear();
            txtRequester.Clear();
            dtpDate.Value = DateTime.Now;

            // Xóa chọn RadioButton
            radLow.Checked = false;
            radMedium.Checked = false;
            radHigh.Checked = false;

            // Đặt lại ComboBox
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // Xóa chọn CheckBox
            chkDesktop.Checked = false;
            chkLaptop.Checked = false;
            chkPrinter.Checked = false;
            chkPhone.Checked = false;

            // Xóa ảnh
            picErrorImage.Image = null;

            txtTicketID.Focus();
        }
    }
}