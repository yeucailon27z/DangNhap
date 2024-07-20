namespace QLThuCungDAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtSTT = new TextBox();
            txtTen = new TextBox();
            txtMau = new TextBox();
            txtLoai = new TextBox();
            txtTuoi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(654, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(102, 38);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(525, 77);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(102, 38);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(654, 77);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(102, 38);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtSTT
            // 
            txtSTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSTT.Location = new Point(61, 21);
            txtSTT.Name = "txtSTT";
            txtSTT.Size = new Size(145, 29);
            txtSTT.TabIndex = 2;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(264, 21);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(145, 29);
            txtTen.TabIndex = 2;
            // 
            // txtMau
            // 
            txtMau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMau.Location = new Point(111, 83);
            txtMau.Name = "txtMau";
            txtMau.Size = new Size(145, 29);
            txtMau.TabIndex = 2;
            // 
            // txtLoai
            // 
            txtLoai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoai.Location = new Point(482, 20);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(145, 29);
            txtLoai.TabIndex = 2;
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuoi.Location = new Point(331, 83);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(145, 29);
            txtTuoi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 3;
            label1.Text = "STT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(218, 25);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 3;
            label2.Text = "Tên :";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(430, 23);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 3;
            label3.Text = "Loài :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 86);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 3;
            label4.Text = "Màu lông :";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(278, 88);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 3;
            label5.Text = "Tuổi :";
            label5.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLoai);
            Controls.Add(txtTuoi);
            Controls.Add(txtMau);
            Controls.Add(txtTen);
            Controls.Add(txtSTT);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLThuCung";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private TextBox txtSTT;
        private TextBox txtTen;
        private TextBox txtMau;
        private TextBox txtLoai;
        private TextBox txtTuoi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}