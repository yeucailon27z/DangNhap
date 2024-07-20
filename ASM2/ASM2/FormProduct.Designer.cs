namespace ASM2
{
    partial class FormProduct
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
            txtID = new TextBox();
            txtSupplier = new TextBox();
            txtName = new TextBox();
            txtPackage = new TextBox();
            txtPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            chkIsDisC = new CheckBox();
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
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtID
            // 
            txtID.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(135, 15);
            txtID.Name = "txtID";
            txtID.Size = new Size(148, 27);
            txtID.TabIndex = 4;
            // 
            // txtSupplier
            // 
            txtSupplier.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupplier.Location = new Point(135, 115);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(148, 27);
            txtSupplier.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(135, 63);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 27);
            txtName.TabIndex = 6;
            // 
            // txtPackage
            // 
            txtPackage.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPackage.Location = new Point(453, 63);
            txtPackage.Name = "txtPackage";
            txtPackage.Size = new Size(148, 27);
            txtPackage.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(453, 15);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(148, 27);
            txtPrice.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 24);
            label1.TabIndex = 10;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 24);
            label2.TabIndex = 11;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(107, 24);
            label3.TabIndex = 12;
            label3.Text = "SupplierId :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(379, 18);
            label4.Name = "label4";
            label4.Size = new Size(62, 24);
            label4.TabIndex = 13;
            label4.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(356, 66);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 14;
            label5.Text = "Package :";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 0);
            btnXoa.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(640, 109);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(123, 36);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(128, 128, 255);
            btnSua.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(640, 60);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 36);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Yellow;
            btnThem.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(640, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 36);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // chkIsDisC
            // 
            chkIsDisC.AutoSize = true;
            chkIsDisC.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkIsDisC.Location = new Point(406, 109);
            chkIsDisC.Name = "chkIsDisC";
            chkIsDisC.Size = new Size(153, 28);
            chkIsDisC.TabIndex = 22;
            chkIsDisC.Text = "IsDisContinued";
            chkIsDisC.UseVisualStyleBackColor = true;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(784, 461);
            Controls.Add(chkIsDisC);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtPackage);
            Controls.Add(txtName);
            Controls.Add(txtSupplier);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProduct";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtID;
        private TextBox txtSupplier;
        private TextBox txtName;
        private TextBox txtPackage;
        private TextBox txtPrice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox chkIsDisC;
    }
}