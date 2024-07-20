using DemoDbFirst.Models;
using System.Security.Policy;

namespace DemoDbFirst
{
    public partial class Form1 : Form
    {
        QLNhanVienContext db = new QLNhanVienContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadPB();
        }
        public void LoadNV()
        {
            var result = from nv in db.NhanViens
                         join pb in db.PhongBans on nv.MaPb equals pb.MaPb
                         select new
                         {
                             ID = nv.MaNv,
                             nv.HoTen,
                             nv.GioiTinh,
                             nv.NgaySinh,
                             pb.TenPb
                         };
            dataGridView1.DataSource = result.ToList();
            dataGridView1.Columns[0].HeaderText = "Ma Nhan Vien";
            dataGridView1.Columns[3].HeaderText = "Ngay Sinh";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        public void LoadPB()
        {
            comboBox1.DataSource = db.PhongBans.ToList();
            comboBox1.DisplayMember = "TenPB";
            comboBox1.ValueMember = "MaPB";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtNhanVien.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[d].Cells[4].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[d].Cells[3].Value.ToString());
            if (dataGridView1.Rows[d].Cells[2].Value.ToString().Equals("Nam"))
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radioButton1.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            NhanVien nv = new NhanVien()
            {
                MaNv = txtNhanVien.Text,
                HoTen = textBox2.Text,
                GioiTinh = gt,
                MaPb = comboBox1.SelectedValue.ToString(),
                NgaySinh = DateTime.ParseExact(dateTimePicker1.Text.Trim(), "dd-MM-yyyy", null)
            };
            db.NhanViens.Add(nv);
            db.SaveChanges();
            LoadNV();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string idSua = txtNhanVien.Text;
            NhanVien nhanVienSua = db.NhanViens.Find(idSua);//tim kiem id sua
            if (nhanVienSua != null)
            {
                nhanVienSua.HoTen = textBox2.Text;
                nhanVienSua.MaPb = comboBox1.SelectedValue.ToString();
                if (radioButton1.Checked == true)
                {
                    nhanVienSua.GioiTinh = "Nam";
                }
                else
                    nhanVienSua.GioiTinh = "Nữ";
                nhanVienSua.NgaySinh = DateTime.ParseExact(dateTimePicker1.Text.Trim(), "dd-MM-yyyy", null);
                db.SaveChanges();
            }
            else
                MessageBox.Show("Khong Tim Thay ID");
            LoadNV();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string idXoa = txtNhanVien.Text;
            NhanVien nhanVienXoa = db.NhanViens.Find(idXoa);
            if (nhanVienXoa != null)
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn xóa ko", "Cảnh báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    if (re == DialogResult.OK)
                {
                    db.NhanViens.Remove(nhanVienXoa);
                    db.SaveChanges();
                }
            }
            LoadNV();
        }
    }
}