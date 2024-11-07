using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lstViewSV.Columns.Add("Mã sinh viên", 150);
            lstViewSV.Columns.Add("Họ tên", 200);
            lstViewSV.Columns.Add("Địa chỉ", 150);
            lstViewSV.Columns.Add("Ngày sinh", 150);
            lstViewSV.Columns.Add("Lớp", 80);

            this.cbLop.Items.Add("A");
            this.cbLop.Items.Add("B");
            this.cbLop.Items.Add("C");
            this.cbLop.Items.Add("D");
            this.cbLop.Items.Add("E");
            this.cbLop.Items.Add("F");
            this.cbLop.Items.Add("G");
            //this.cbLop.SelectedItem = "Chọn lớp";

        }
        public void Clear()
        {
            txtMaSV.Text = " ";
            txtHoTen.Text = " ";
            txtDiachi.Text = " ";
            dateTimeNS.Value = DateTime.Now;
            cbLop.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            ListViewItem item = new ListViewItem(txtMaSV.Text);
            item.SubItems.Add(txtHoTen.Text);
            item.SubItems.Add(txtDiachi.Text);
            item.SubItems.Add(dateTimeNS.Value.ToShortDateString());
            item.SubItems.Add(cbLop.SelectedItem.ToString());
            lstViewSV.Items.Add(item);
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstViewSV.SelectedItems.Count > 0)
            {

                DialogResult result = MessageBox.Show("Bạn muốn sửa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    lstViewSV.SelectedItems[0].SubItems[0].Text = txtMaSV.Text;
                    lstViewSV.SelectedItems[0].SubItems[1].Text = txtHoTen.Text;
                    lstViewSV.SelectedItems[0].SubItems[2].Text = txtDiachi.Text;
                    lstViewSV.SelectedItems[0].SubItems[3].Text = dateTimeNS.Value.ToShortDateString();
                    lstViewSV.SelectedItems[0].SubItems[4].Text = cbLop.Items.ToString();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstViewSV.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                    lstViewSV.Items.Remove(lstViewSV.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
