using BLL;
using DTO.Models;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace QLThuCungDAM
{

    public partial class Form1 : Form
    {
        ProductBLL productBLL = new ProductBLL();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Loài", typeof(string));
            dt.Columns.Add("Màu lông", typeof(string));
            dt.Columns.Add("Tuổi", typeof(int));

            var dsThuCungs = productBLL.GetAllDSThuCung();
            foreach (var dsThuCung in dsThuCungs)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = dsThuCung.Stt;
                dr["Tên"] = dsThuCung.Ten;
                dr["Loài"] = dsThuCung.Loai;
                dr["Màu lông"] = dsThuCung.Maulong;
                dr["Tuổi"] = dsThuCung.Tuoi;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtSTT.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtLoai.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtMau.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txtTuoi.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Dsthucung dsThucung = new Dsthucung()
            {
                Stt = int.Parse(txtSTT.Text),
                Ten = txtTen.Text,
                Loai = txtLoai.Text,
                Maulong = txtMau.Text,
                Tuoi = int.Parse(txtTuoi.Text)
            };
            var dsThuCungs = productBLL.AddThuCung(dsThucung);

            dataGridView1.DataSource = dsThuCungs;
            txtSTT.Clear();
            txtTen.Clear();
            txtLoai.Clear();
            txtMau.Clear();
            txtTuoi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int STT = int.Parse(txtSTT.Text);
            Dsthucung thucungxoa = productBLL.TimSTT(STT);
            if (thucungxoa != null)
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.OK)
                {
                    productBLL.DeleteThuCung(STT);
                    var dsthucungs = productBLL.GetAllDSThuCung();
                    dataGridView1.DataSource = dsthucungs;
                    txtSTT.Clear();
                    txtTen.Clear();
                    txtLoai.Clear();
                    txtMau.Clear();
                    txtTuoi.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Dsthucung dsThucung = new Dsthucung()
            {
                Stt = int.Parse(txtSTT.Text),
                Ten = txtTen.Text,
                Loai = txtLoai.Text,
                Maulong = txtMau.Text,
                Tuoi = int.Parse(txtTuoi.Text)
            };

            productBLL.UpdateThuCung(dsThucung);
            var dsThuCungs = productBLL.GetAllDSThuCung();
            dt.Clear();
            foreach (var thuCung in dsThuCungs)
            {
                DataRow dr = dt.NewRow();
                dr["STT"] = thuCung.Stt;
                dr["Tên"] = thuCung.Ten;
                dr["Loài"] = thuCung.Loai;
                dr["Màu lông"] = thuCung.Maulong;
                dr["Tuổi"] = thuCung.Tuoi;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
            txtSTT.Clear();
            txtTen.Clear();
            txtLoai.Clear();
            txtMau.Clear();
            txtTuoi.Clear();
        }
    }
}
