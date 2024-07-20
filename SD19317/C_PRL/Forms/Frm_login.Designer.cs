namespace C_PRL.Forms
{
    partial class Frm_login
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
            label1 = new Label();
            label2 = new Label();
            txtUse = new TextBox();
            txtPass = new TextBox();
            ckkRobot = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 40);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtUse
            // 
            txtUse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUse.Location = new Point(183, 41);
            txtUse.Name = "txtUse";
            txtUse.Size = new Size(218, 29);
            txtUse.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPass.Location = new Point(183, 76);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(218, 29);
            txtPass.TabIndex = 2;
            // 
            // ckkRobot
            // 
            ckkRobot.AutoSize = true;
            ckkRobot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckkRobot.Location = new Point(65, 118);
            ckkRobot.Name = "ckkRobot";
            ckkRobot.Size = new Size(157, 25);
            ckkRobot.TabIndex = 3;
            ckkRobot.Text = "Tôi là người máy";
            ckkRobot.UseVisualStyleBackColor = true;
            ckkRobot.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(65, 166);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            btnLogin.MouseHover += DiChuotVaoNut;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 266);
            Controls.Add(btnLogin);
            Controls.Add(ckkRobot);
            Controls.Add(txtPass);
            Controls.Add(txtUse);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Frm_login";
            Text = "Frm_login";
            Load += Frm_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUse;
        private TextBox txtPass;
        private CheckBox ckkRobot;
        private Button btnLogin;
    }
}