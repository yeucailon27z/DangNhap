using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DiChuotVaoNut(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Red;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (ckkRobot.Checked)
            {
                MessageBox.Show("Mày là người máy hả?");
            }
            else
            {
                if (txtUse.Text == "admin" && txtPass.Text == "123456")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Frm_main main = new Frm_main();
                    this.Hide();// ẩn đi form login
                    main.Show();
                    //khi tắt formMain đi thì hiển thị lại form login
                    // tạo sự kiện khi form main close=> this.Show thông qua việc trỏ tới sk mới
                    main.FormClosed += FormMainClose;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            ;

            }

        }

        private void FormMainClose(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
