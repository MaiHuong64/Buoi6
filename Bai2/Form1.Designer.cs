namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTongSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listB = new System.Windows.Forms.ListBox();
            this.btnAllTrai = new System.Windows.Forms.Button();
            this.btnAllPhai = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnPhai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listA = new System.Windows.Forms.ListBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radA = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTongSV
            // 
            this.btnTongSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongSV.Location = new System.Drawing.Point(108, 385);
            this.btnTongSV.Name = "btnTongSV";
            this.btnTongSV.Size = new System.Drawing.Size(173, 44);
            this.btnTongSV.TabIndex = 20;
            this.btnTongSV.Text = "Tổng số sinh viên";
            this.btnTongSV.UseVisualStyleBackColor = true;
            this.btnTongSV.Click += new System.EventHandler(this.btnTongSV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(334, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 44);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listB);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(350, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 260);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // listB
            // 
            this.listB.FormattingEnabled = true;
            this.listB.ItemHeight = 22;
            this.listB.Items.AddRange(new object[] {
            "Huỳnh Lê An",
            "Nguyễn Văn Thành"});
            this.listB.Location = new System.Drawing.Point(6, 26);
            this.listB.Name = "listB";
            this.listB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listB.Size = new System.Drawing.Size(195, 224);
            this.listB.TabIndex = 2;
            // 
            // btnAllTrai
            // 
            this.btnAllTrai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTrai.Location = new System.Drawing.Point(259, 325);
            this.btnAllTrai.Name = "btnAllTrai";
            this.btnAllTrai.Size = new System.Drawing.Size(85, 54);
            this.btnAllTrai.TabIndex = 15;
            this.btnAllTrai.Text = "<<";
            this.btnAllTrai.UseVisualStyleBackColor = true;
            this.btnAllTrai.Click += new System.EventHandler(this.btnAllTrai_Click);
            // 
            // btnAllPhai
            // 
            this.btnAllPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllPhai.Location = new System.Drawing.Point(258, 259);
            this.btnAllPhai.Name = "btnAllPhai";
            this.btnAllPhai.Size = new System.Drawing.Size(85, 60);
            this.btnAllPhai.TabIndex = 16;
            this.btnAllPhai.Text = ">>";
            this.btnAllPhai.UseVisualStyleBackColor = true;
            this.btnAllPhai.Click += new System.EventHandler(this.btnAllPhai_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrai.Location = new System.Drawing.Point(259, 201);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(85, 52);
            this.btnTrai.TabIndex = 17;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnPhai
            // 
            this.btnPhai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhai.Location = new System.Drawing.Point(259, 148);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(85, 47);
            this.btnPhai.TabIndex = 18;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listA);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 260);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // listA
            // 
            this.listA.FormattingEnabled = true;
            this.listA.ItemHeight = 22;
            this.listA.Items.AddRange(new object[] {
            "Trần Thanh Tính",
            "Phan Thanh Hồ",
            "Nguyễn Thanh Hà"});
            this.listA.Location = new System.Drawing.Point(6, 26);
            this.listA.Name = "listA";
            this.listA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listA.Size = new System.Drawing.Size(195, 224);
            this.listA.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(406, 24);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 33);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(119, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(268, 30);
            this.txtName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radA);
            this.groupBox1.Controls.Add(this.radB);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(187, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Location = new System.Drawing.Point(6, 21);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(81, 26);
            this.radA.TabIndex = 1;
            this.radA.Text = "Lớp A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(113, 21);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(81, 26);
            this.radB.TabIndex = 2;
            this.radB.Text = "Lớp B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Họ tên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 453);
            this.Controls.Add(this.btnTongSV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAllTrai);
            this.Controls.Add(this.btnAllPhai);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTongSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listB;
        private System.Windows.Forms.Button btnAllTrai;
        private System.Windows.Forms.Button btnAllPhai;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listA;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radA;
        private System.Windows.Forms.RadioButton radB;
        private System.Windows.Forms.Label label1;
    }
}

