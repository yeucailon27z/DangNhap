using BUS.Services;
using DAL.Models;

namespace PRL
{
    public partial class Form1 : Form
    {
        CuaHangServices services;
        public Form1()
        {
            services = new CuaHangServices();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<CuaHang> ch = services.CNShow();
            ShowData(ch);
        }
 
        public void ShowData(List<CuaHang> ch)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            int stt = 1;
            dataGridView1.Columns[0].HeaderText = "Số thứ tự";
            dataGridView1.Columns[1].HeaderText = "Mã hàng";
            dataGridView1.Columns[2].HeaderText = "Loại hàng";
            dataGridView1.Columns[3].HeaderText = "Mô tả";
            dataGridView1.Columns[4].HeaderText = "Ngày đăng ký";
            foreach (var item in ch)
            {
                dataGridView1.Rows.Add(stt++, item.Ma, item.LoaiHang, item.Mota, item.NgayDangKy);
            }
        }
    }
}