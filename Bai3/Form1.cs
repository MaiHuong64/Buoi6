using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String[] arr_tinh = {"An Giang",
                            "Bà Rịa – Vũng Tàu",
                            "Bạc Liêu",
                            "Bắc Giang",
                            "Bắc Kạn",
                            "Bắc Ninh",
                            "Bến Tre",
                            "Bình Dương",
                            "Bình Định",
                            "Bình Phước",
                            "Bình Thuận",
                            "Cà Mau",
                            "Cao Bằng",
                            "Cần Thơ",
                            "Đà Nẵng",
                            "Đắk Lắk",
                            "Đắk Nông",
                            "Điện Biên",
                            "Đồng Nai",
                            "Đồng Tháp",
                            "Gia Lai",
                            "Hà Giang",
                            "Hà Nam",
                            "Hà Nội",
                            "Hà Tĩnh",
                            "Hải Dương",
                            "Hải Phòng",
                            "Hậu Giang",
                            "Hòa Bình",
                            "Thành phố Hồ Chí Minh",
                            "Hưng Yên",
                            "Khánh Hòa",
                            "Kiên Giang",
                            "Kon Tum",
                            "Lai Châu",
                            "Lạng Sơn",
                            "Lào Cai",
                            "Lâm Đồng",
                            "Long An",
                            "Nam Định",
                            "Nghệ An",
                            "Ninh Bình",
                            "Ninh Thuận",
                            "Phú Thọ",
                            "Phú Yên",
                            "Quảng Bình",
                            "Quảng Nam",
                            "Quảng Ngãi",
                            "Quảng Ninh",
                            "Quảng Trị",
                            "Sóc Trăng",
                            "Sơn La",
                            "Tây Ninh",
                            "Thái Bình",
                            "Thái Nguyên",
                            "Thanh Hóa",
                            "Thừa Thiên Huế",
                            "Tiền Giang",
                            "Trà Vinh",
                            "Tuyên Quang",
                            "Vĩnh Long",
                            "Vĩnh Phúc",
                            "Yên Bái"};
            cbQueQuan.DataSource = arr_tinh;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listSV.Columns.Add("Mã sinh viên", 150);
            listSV.Columns.Add("Tên sinh viên", 200);
            listSV.Columns.Add("Ngay sinh", 150);
            listSV.Columns.Add("Gioi tinh", 100);
            listSV.Columns.Add("Dien thoai", 200);
            listSV.Columns.Add("Que quan", 200);
        }
        public void IsSinhVien(string masv)
        {

        }
        private void Clear()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            dateTimeNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            txtDT.Clear();
            cbQueQuan.SelectedIndex = -1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (string.IsNullOrEmpty(txtMasv.Text) || string.IsNullOrEmpty(txtTensv.Text) || string.IsNullOrEmpty(txtDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            foreach(ListViewItem list in listSV.Items)
            {
                if (list.SubItems[0].Text == txtMasv.Text)
                {
                    check = true;
                    break;
                }
                  
            }
            if(check)
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo");
            else
            {
                ListViewItem item = new ListViewItem(txtMasv.Text);
                item.SubItems.Add(txtTensv.Text);
                item.SubItems.Add(dateTimeNgaySinh.Value.ToShortDateString());
                item.SubItems.Add(radNam.Checked ? "Nam" : "Nữ");
                item.SubItems.Add(txtDT.Text);
                item.SubItems.Add(cbQueQuan.Text);
                listSV.Items.Add(item);
                Clear();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listSV.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    listSV.Items.Remove(listSV.SelectedItems[0]);
                    Clear();
                    MessageBox.Show("Đã xóa thành công!","Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa");
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(listSV.SelectedItems.Count > 0)
            {

                DialogResult result = MessageBox.Show("Bạn muốn sửa",  "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    listSV.SelectedItems[0].SubItems[0].Text = txtMasv.Text;
                    listSV.SelectedItems[0].SubItems[1].Text = txtTensv.Text;
                    listSV.SelectedItems[0].SubItems[2].Text = dateTimeNgaySinh.Value.ToShortDateString();
                    listSV.SelectedItems[0].SubItems[3].Text = radNam.Checked ? "Nam" : "Nữ";
                    listSV.SelectedItems[0].SubItems[4].Text = txtDT.Text;
                    listSV.SelectedItems[0].SubItems[5].Text = cbQueQuan.Text;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để sửa", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void listSV_Click(object sender, EventArgs e)
        {
            if (listSV.SelectedItems.Count > 0)
            {
                txtMasv.Text = listSV.SelectedItems[0].SubItems[0].Text;
                txtTensv.Text = listSV.SelectedItems[0].SubItems[1].Text;
                dateTimeNgaySinh.Text = listSV.SelectedItems[0].SubItems[2].Text;
                if (listSV.SelectedItems[0].SubItems[3].Text == "Nam")
                    radNam.Checked = true;
                else
                {
                    radNu.Checked = true;
                }
                txtDT.Text = listSV.SelectedItems[0].SubItems[4].Text;
                cbQueQuan.Text = listSV.SelectedItems[0].SubItems[5].Text;

            }
        }
    }
}
