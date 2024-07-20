namespace ASM2
{
    partial class FormOrder
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
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            btnDetail = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtCustomID = new TextBox();
            txtTotalAmount = new TextBox();
            txtID = new TextBox();
            btnXoa = new Button();
            btnSua = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtOrderNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(751, 290);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.FromArgb(64, 64, 64);
            btnDetail.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.White;
            btnDetail.Location = new Point(401, 100);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(176, 37);
            btnDetail.TabIndex = 8;
            btnDetail.Text = "Detail";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(323, 60);
            label5.Name = "label5";
            label5.Size = new Size(126, 24);
            label5.TabIndex = 44;
            label5.Text = "TotalAmount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(331, 15);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 43;
            label4.Text = "CustomerID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 109);
            label3.Name = "label3";
            label3.Size = new Size(133, 24);
            label3.TabIndex = 42;
            label3.Text = "OrderNumber :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 60);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 41;
            label2.Text = "OrderDate :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 40;
            label1.Text = "ID :";
            // 
            // txtCustomID
            // 
            txtCustomID.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustomID.Location = new Point(455, 12);
            txtCustomID.Name = "txtCustomID";
            txtCustomID.Size = new Size(148, 27);
            txtCustomID.TabIndex = 38;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(455, 60);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(148, 27);
            txtTotalAmount.TabIndex = 37;
            // 
            // txtID
            // 
            txtID.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(155, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(148, 27);
            txtID.TabIndex = 34;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(644, 106);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 36);
            btnXoa.TabIndex = 47;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(644, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 36);
            btnSua.TabIndex = 46;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(644, 9);
            button3.Name = "button3";
            button3.Size = new Size(123, 36);
            button3.TabIndex = 45;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(155, 61);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 48;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderNumber.Location = new Point(155, 110);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(148, 27);
            txtOrderNumber.TabIndex = 35;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(784, 461);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomID);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtOrderNumber);
            Controls.Add(txtID);
            Controls.Add(btnDetail);
            Controls.Add(dataGridView1);
            Name = "FormOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrder";
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnDetail;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCustomID;
        private TextBox txtTotalAmount;
        private TextBox txtID;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox txtOrderNumber;
    }
}