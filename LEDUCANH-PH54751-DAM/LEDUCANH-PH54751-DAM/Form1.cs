using BUS.Service;
using DAL.Models;
using System.Data;

namespace LEDUCANH_PH54751_DAM
{
    public partial class GUI : Form
    {
        HocSinhServices sevices;
        public GUI()
        {
            sevices = new HocSinhServices();   
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<HocSinh> hs = sevices.GetALLHS();
            ShowHS(hs);
        }
        public void ShowHS(List<HocSinh> hs)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;
            int stt = 1;
            foreach (var item in hs)
            {
                dataGridView1.Rows.Add(stt++, item.Ma, item.Ten, item.Nganh, item.Tuoi);
            }
        }
    }
}