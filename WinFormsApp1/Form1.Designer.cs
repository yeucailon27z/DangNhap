namespace WinFormsApp1
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
            dvgDanhSach = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgDanhSach).BeginInit();
            SuspendLayout();
            // 
            // dvgDanhSach
            // 
            dvgDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgDanhSach.Location = new Point(57, 151);
            dvgDanhSach.Name = "dvgDanhSach";
            dvgDanhSach.RowTemplate.Height = 25;
            dvgDanhSach.Size = new Size(694, 277);
            dvgDanhSach.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(57, 66);
            button1.Name = "button1";
            button1.Size = new Size(136, 41);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(241, 66);
            button2.Name = "button2";
            button2.Size = new Size(136, 41);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(615, 66);
            button3.Name = "button3";
            button3.Size = new Size(136, 41);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(432, 66);
            button4.Name = "button4";
            button4.Size = new Size(136, 41);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dvgDanhSach);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dvgDanhSach;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}