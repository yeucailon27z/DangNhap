namespace ASM2
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
            menuStrip1 = new MenuStrip();
            traCứuToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            customesToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { traCứuToolStripMenuItem, bánHàngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(607, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // traCứuToolStripMenuItem
            // 
            traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            traCứuToolStripMenuItem.Size = new Size(302, 29);
            traCứuToolStripMenuItem.Text = "                    Bán Hàng                  ";
            traCứuToolStripMenuItem.Click += traCứuToolStripMenuItem_Click;
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productToolStripMenuItem, customesToolStripMenuItem, orderToolStripMenuItem });
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(274, 29);
            bánHàngToolStripMenuItem.Text = "                 Tra Cứu                   ";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(190, 30);
            productToolStripMenuItem.Text = "     Product";
            productToolStripMenuItem.Click += productToolStripMenuItem_Click;
            // 
            // customesToolStripMenuItem
            // 
            customesToolStripMenuItem.Name = "customesToolStripMenuItem";
            customesToolStripMenuItem.Size = new Size(190, 30);
            customesToolStripMenuItem.Text = "    Customer";
            customesToolStripMenuItem.Click += customesToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(190, 30);
            orderToolStripMenuItem.Text = "       Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Sitka Small", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(59, 115);
            label1.Name = "label1";
            label1.Size = new Size(475, 48);
            label1.TabIndex = 1;
            label1.Text = "Dịch Vụ Quản Lý Bán Hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(607, 338);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan Ly Ban Hang";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem traCứuToolStripMenuItem;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem customesToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Label label1;
    }
}