namespace LEDUCANH_PH54751_DAM
{
    partial class GUI
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
            txtTen = new TextBox();
            txtNganh = new TextBox();
            txtTuoi = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            btnShow = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(656, 239);
            dataGridView1.TabIndex = 0;
            // 
            // txtMa
            // 
            txtMa.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMa.Location = new Point(100, 29);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(325, 27);
            txtMa.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(100, 69);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(325, 27);
            txtTen.TabIndex = 2;
            // 
            // txtNganh
            // 
            txtNganh.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNganh.Location = new Point(100, 109);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(325, 27);
            txtNganh.TabIndex = 3;
            // 
            // txtTuoi
            // 
            txtTuoi.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTuoi.Location = new Point(100, 148);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(325, 27);
            txtTuoi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 29);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 69);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 109);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Ngành";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 148);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 5;
            label5.Text = "Tuổi";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(100, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(325, 23);
            textBox5.TabIndex = 6;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnShow.Location = new Point(530, 29);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(125, 42);
            btnShow.TabIndex = 7;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(530, 82);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 42);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(530, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 42);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(530, 193);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 42);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 518);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnShow);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTuoi);
            Controls.Add(txtNganh);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(dataGridView1);
            Name = "GUI";
            Text = "Form1";
            Load += GUI_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtNganh;
        private TextBox txtTuoi;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Button btnShow;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}