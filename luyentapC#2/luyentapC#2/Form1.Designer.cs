namespace luyentapC_2
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtThongDiep = new TextBox();
            label1 = new Label();
            btnLoad1 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            txtGhi = new Button();
            txtDoc = new Button();
            groupBox3 = new GroupBox();
            dgvCau3 = new DataGridView();
            rdbNu = new RadioButton();
            rdbNam = new RadioButton();
            label5 = new Label();
            txtNganh = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            label4 = new Label();
            btnLoad3 = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtThongDiep);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLoad1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 220);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cau 1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 29);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 136);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 4;
            label2.Text = "Lua Chon";
            // 
            // txtThongDiep
            // 
            txtThongDiep.Location = new Point(27, 94);
            txtThongDiep.Name = "txtThongDiep";
            txtThongDiep.Size = new Size(292, 29);
            txtThongDiep.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 66);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 2;
            label1.Text = "Thong diep";
            // 
            // btnLoad1
            // 
            btnLoad1.Location = new Point(192, 28);
            btnLoad1.Name = "btnLoad1";
            btnLoad1.Size = new Size(109, 35);
            btnLoad1.TabIndex = 1;
            btnLoad1.Text = "Load";
            btnLoad1.UseVisualStyleBackColor = true;
            btnLoad1.Click += btnLoad1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(50, 28);
            button1.Name = "button1";
            button1.Size = new Size(109, 35);
            button1.TabIndex = 0;
            button1.Text = "Thong Bao";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(txtGhi);
            groupBox2.Controls.Add(txtDoc);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 239);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cau 2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 94);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 120);
            textBox2.TabIndex = 3;
            // 
            // txtGhi
            // 
            txtGhi.Location = new Point(192, 38);
            txtGhi.Name = "txtGhi";
            txtGhi.Size = new Size(109, 35);
            txtGhi.TabIndex = 1;
            txtGhi.Text = "Ghi";
            txtGhi.UseVisualStyleBackColor = true;
            txtGhi.Click += txtGhi_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(50, 38);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(109, 35);
            txtDoc.TabIndex = 0;
            txtDoc.Text = "Doc";
            txtDoc.UseVisualStyleBackColor = true;
            txtDoc.Click += txtDoc_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCau3);
            groupBox3.Controls.Add(rdbNu);
            groupBox3.Controls.Add(rdbNam);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtNganh);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnLoad3);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(361, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 474);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cau 3";
            // 
            // dgvCau3
            // 
            dgvCau3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCau3.Location = new Point(31, 245);
            dgvCau3.Name = "dgvCau3";
            dgvCau3.RowTemplate.Height = 25;
            dgvCau3.Size = new Size(288, 204);
            dgvCau3.TabIndex = 9;
            dgvCau3.CellClick += dgvCau3_CellClick;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.Location = new Point(235, 199);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(49, 25);
            rdbNu.TabIndex = 8;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nu";
            rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.Location = new Point(128, 199);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(62, 25);
            rdbNam.TabIndex = 7;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 199);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 6;
            label5.Text = "Gioi tinh";
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(27, 160);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(292, 29);
            txtNganh.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 136);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 4;
            label3.Text = "Nganh";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(27, 94);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(292, 29);
            txtTen.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 66);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 2;
            label4.Text = "Ten";
            // 
            // btnLoad3
            // 
            btnLoad3.Location = new Point(49, 28);
            btnLoad3.Name = "btnLoad3";
            btnLoad3.Size = new Size(109, 35);
            btnLoad3.TabIndex = 1;
            btnLoad3.Text = "Load";
            btnLoad3.UseVisualStyleBackColor = true;
            btnLoad3.Click += btnLoad3_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(193, 28);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 35);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 502);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtThongDiep;
        private Label label1;
        private Button btnLoad1;
        private Button button1;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Button txtGhi;
        private Button txtDoc;
        private GroupBox groupBox3;
        private TextBox txtNganh;
        private Label label3;
        private TextBox txtTen;
        private Label label4;
        private Button btnLoad3;
        private Button btnClear;
        private DataGridView dgvCau3;
        private RadioButton rdbNu;
        private RadioButton rdbNam;
        private Label label5;
        private ComboBox comboBox1;
    }
}