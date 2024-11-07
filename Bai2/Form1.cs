using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radA.Checked = true;
        }
        public void buttons()
        {
            if (listA.Items.Count == 0)
            {
                btnAllPhai.Enabled = false;
                btnPhai.Enabled = false;
            }
            else
            {
                btnAllPhai.Enabled = true;
                btnPhai.Enabled = true;
            }
            if (listB.Items.Count == 0)
            {
                btnTrai.Enabled = false;
                btnAllTrai.Enabled = false;
            }
            else
            {
                btnTrai.Enabled = true;
                btnAllTrai.Enabled = true;
            }
        }
        public void RemoveItem(ListBox a, ListBox b)
        {
            if (a.SelectedItems.Count > 0)
            {
                // Lấy các giá trị đã chọn từ list box chuyển sang list
                var items = a.SelectedItems.Cast<object>().ToList();
                foreach (var item in items)
                {
                    b.Items.Add(item);
                    a.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh đẻ chuyển", "Thông báo");
            }
        }
        public void RemoveAllItems(ListBox a, ListBox b)
        {
            if (a.Items.Count > 0)
            {
                foreach (var item in a.Items)
                {
                    b.Items.Add(item.ToString());
                }
                a.Items.Clear();
            }
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo");
                txtName.Focus();
                return;
            }
            else
            {
                if (radA.Checked == true)
                {
                    listA.Items.Add(txtName.Text);
                    txtName.Clear();
                    txtName.Focus();
                }

                else
                {
                    listB.Items.Add(txtName.Text);
                    txtName.Clear();
                    txtName.Focus();
                }
            }  
        }

        private void btnPhai_Click(object sender, EventArgs e)
        {
            RemoveItem(listA, listB);
            buttons();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            RemoveItem(listB, listA); buttons();
        }

        private void btnAllPhai_Click(object sender, EventArgs e)
        {
            RemoveAllItems(listA, listB); buttons();
        }

        private void btnAllTrai_Click(object sender, EventArgs e)
        {

            RemoveAllItems(listB, listA); buttons();
        }

        private void btnTongSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tong sinh vien 2 lop: {(listA.Items.Count) + (listB.Items.Count)}");
        }

        private void listA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
