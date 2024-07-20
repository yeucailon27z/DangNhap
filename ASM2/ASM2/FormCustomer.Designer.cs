namespace ASM2
{
    partial class FormCustomer
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
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtID = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(751, 290);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(361, 112);
            label6.Name = "label6";
            label6.Size = new Size(70, 24);
            label6.TabIndex = 30;
            label6.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(345, 63);
            label5.Name = "label5";
            label5.Size = new Size(86, 24);
            label5.TabIndex = 29;
            label5.Text = "Country :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(377, 15);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 28;
            label4.Text = "City :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 109);
            label3.Name = "label3";
            label3.Size = new Size(101, 24);
            label3.TabIndex = 27;
            label3.Text = "LastName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 26;
            label2.Text = "FirstName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 25;
            label1.Text = "ID :";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(451, 109);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 27);
            txtPhone.TabIndex = 24;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.Location = new Point(451, 12);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(148, 27);
            txtCity.TabIndex = 23;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(451, 60);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(148, 27);
            txtCountry.TabIndex = 22;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(133, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(148, 27);
            txtFirstName.TabIndex = 21;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(133, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(148, 27);
            txtLastName.TabIndex = 20;
            // 
            // txtID
            // 
            txtID.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(133, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(148, 27);
            txtID.TabIndex = 19;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(638, 106);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 36);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(638, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 36);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Yellow;
            btnThem.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(638, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 36);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(784, 461);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtID);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCustomer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtID;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
    }
}