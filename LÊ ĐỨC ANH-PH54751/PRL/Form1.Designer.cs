namespace PRL
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
            txtMa = new TextBox();
            txtLoai = new TextBox();
            txtMota = new TextBox();
            txtNgay = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(622, 204);
            dataGridView1.TabIndex = 0;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(157, 30);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(385, 27);
            txtMa.TabIndex = 1;
            // 
            // txtLoai
            // 
            txtLoai.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoai.Location = new Point(157, 62);
            txtLoai.Name = "txtLoai";
            txtLoai.Size = new Size(385, 27);
            txtLoai.TabIndex = 2;
            // 
            // txtMota
            // 
            txtMota.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMota.Location = new Point(157, 91);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(385, 27);
            txtMota.TabIndex = 3;
            // 
            // txtNgay
            // 
            txtNgay.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgay.Location = new Point(157, 120);
            txtNgay.Name = "txtNgay";
            txtNgay.Size = new Size(385, 27);
            txtNgay.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(157, 164);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(385, 27);
            txtSearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 6;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 61);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Loại Hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 90);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Mô tả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 123);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày đăng ký";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 177);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Search";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(564, 30);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 32);
            btnThem.TabIndex = 11;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(564, 78);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(108, 32);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(564, 116);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(108, 32);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.Location = new Point(564, 164);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(108, 32);
            btnShow.TabIndex = 14;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(btnShow);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(txtNgay);
            Controls.Add(txtMota);
            Controls.Add(txtLoai);
            Controls.Add(txtMa);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtMa;
        private TextBox txtLoai;
        private TextBox txtMota;
        private TextBox txtNgay;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnShow;
    }
}