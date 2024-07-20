using luyentapC_2.Models;
using System.Data;
using System.Windows.Forms;

namespace luyentapC_2
{
    public partial class Form1 : Form
    {
        private NET1021_Final2Context context = new NET1021_Final2Context();
        private DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("Nganh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string thongDiep = txtThongDiep.Text;
            MessageBox.Show(thongDiep + " " + comboBox1.Text, "Thông Điệp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoad1_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Con Ga");
            comboBox1.Items.Add("Con Vit");
            comboBox1.Items.Add("Con Heo");
            comboBox1.Items.Add("Con Cho");
            comboBox1.Items.Add("Con Meo");
        }

        private void txtDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\Admin\\Desktop\\data.txt";
                StreamReader sr = new StreamReader(path);
                string noiDung = sr.ReadToEnd();
                textBox2.Text = noiDung;
                sr.Close();
                MessageBox.Show("Đọc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Đọc thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtGhi_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\Users\\Admin\\Desktop\\data.txt";
                StreamWriter sw = new StreamWriter(path);
                sw.Write(textBox2.Text);
                sw.Close();
                MessageBox.Show("Ghi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ghi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad3_Click(object sender, EventArgs e)
        {
            int stt = 0;
            var ld = context.NguoiLds.ToList();
            foreach (var nguoiLd in ld)
            {
                stt++;
                DataRow dr = dt.NewRow();
                dr["STT"] = stt;
                dr["Ten"] = nguoiLd.Ten;
                dr["Nganh"] = nguoiLd.Nganh;
                dr["GioiTinh"] = nguoiLd.Gioitinh;
                dt.Rows.Add(dr);
            }
            dgvCau3.DataSource = dt;
        }

        private void dgvCau3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dongHienTai = dgvCau3.Rows[e.RowIndex];
            var ten = dongHienTai.Cells[1].Value;
            var nganh = dongHienTai.Cells[2].Value;
            var gioitinh = (bool)dongHienTai.Cells[3].Value;

            txtTen.Text = ten.ToString();
            txtNganh.Text = nganh.ToString();
            if (gioitinh == true)
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chac chan muon Clear khong?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtTen.Text = "";
                txtNganh.Text = "";
                rdbNu.Checked = true;
                rdbNam.Checked = false;
            }
            else
            {
                MessageBox.Show("Chuc nang Clear khong duoc thuc hien!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}