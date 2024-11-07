using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDisplay.ScrollBars = ScrollBars.Horizontal;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                txtDisplay.Font = fontDialog1.Font;
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
           
            if(colorDialog1.ShowDialog() == DialogResult.OK)
                txtDisplay.ForeColor = colorDialog1.Color;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(stream);
                txtDisplay.Text = reader.ReadToEnd();
                reader.Close();
                stream.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter(stream);
                writer.Write(txtDisplay.Text);
                MessageBox.Show("Lưu thành công!", "Thông báo");
                txtDisplay.Clear();
                writer.Close();
                stream.Close();
            }
        }
    }
}
