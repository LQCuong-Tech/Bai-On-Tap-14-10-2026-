using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_4_Interactive_Slot_Booking
{
    public partial class Form1 : Form
    {
        private int selectedCount = 0; // Bộ đếm số ghế đang chọn
        private decimal pricePerSlot = 100000; // Giá mặc định (Sáng)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình ComboBox chọn khung giờ
            cboTimeSlot.Items.Add("Sáng (100.000đ)");
            cboTimeSlot.Items.Add("Tối (150.000đ)");
            cboTimeSlot.SelectedIndex = 0; // Mặc định chọn ca Sáng

            // 2. Dùng vòng lặp sinh tự động 20 nút vị trí
            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Text = "Bàn " + i;
                btn.Size = new Size(70, 70); // Đặt kích thước vuông vắn
                btn.BackColor = Color.White; // Mặc định là Trống
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;

                // Gán CHUNG 1 hàm xử lý sự kiện Click cho cả 20 nút (Event Aggregation)
                btn.Click += new EventHandler(btnSlot_Click);

                // Thêm nút vừa sinh vào FlowLayoutPanel
                flpSeats.Controls.Add(btn);
            }
        }

        // Hàm được gọi khi người dùng bấm vào BẤT KỲ vị trí (Button) nào trong sơ đồ
        private void btnSlot_Click(object sender, EventArgs e)
        {
            // Ép kiểu object gửi đến thành Button để xử lý
            Button clickedBtn = sender as Button;

            // Trường hợp 1: Bàn đã có người đặt (Đỏ) -> Không cho thao tác
            if (clickedBtn.BackColor == Color.Red)
            {
                MessageBox.Show("Vị trí này đã có người đặt. Vui lòng chọn bàn khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trường hợp 2: Bàn đang trống (Trắng) -> Click để chọn (Xanh lá)
            if (clickedBtn.BackColor == Color.White)
            {
                clickedBtn.BackColor = Color.LightGreen;
                selectedCount++;
            }
            // Trường hợp 3: Bàn đang được chọn (Xanh lá) -> Click lần nữa để hủy chọn (Trắng)
            else if (clickedBtn.BackColor == Color.LightGreen)
            {
                clickedBtn.BackColor = Color.White;
                selectedCount--;
            }

            // Cập nhật lại số lượng và tiền
            UpdateStats();
        }

        private void cboTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật giá tiền theo khung giờ được chọn
            if (cboTimeSlot.SelectedIndex == 0)
                pricePerSlot = 100000;
            else
                pricePerSlot = 150000;

            // Tính lại tổng tiền nếu người dùng thay đổi khung giờ khi đang chọn dở bàn
            UpdateStats();
        }

        private void UpdateStats()
        {
            lblSelectedCount.Text = $"Số vị trí đang chọn: {selectedCount}";
            lblTotal.Text = $"Tạm tính tiền: {(selectedCount * pricePerSlot):N0} VNĐ";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (selectedCount == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí trước khi xác nhận đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Duyệt qua tất cả các nút trong FlowLayoutPanel, nút nào đang Xanh lá thì khóa lại (Đỏ)
            foreach (Control ctrl in flpSeats.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.Red; // Chuyển sang trạng thái Đã đặt
                }
            }

            MessageBox.Show($"Xác nhận đặt bàn thành công!\nTổng thanh toán: {(selectedCount * pricePerSlot):N0} VNĐ", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đặt xong thì reset bộ đếm
            selectedCount = 0;
            UpdateStats();
        }

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            // Duyệt để Hủy tất cả các bàn ĐANG CHỌN (Xanh lá) về Trống (Trắng). Không ảnh hưởng tới bàn Đỏ.
            foreach (Control ctrl in flpSeats.Controls)
            {
                if (ctrl is Button btn && btn.BackColor == Color.LightGreen)
                {
                    btn.BackColor = Color.White;
                }
            }

            selectedCount = 0;
            UpdateStats();
        }
    }
}