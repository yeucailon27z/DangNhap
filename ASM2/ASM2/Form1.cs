using DTO.Models;

namespace ASM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }

        private void customesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBanHang formBanHang = new FormBanHang();
            formBanHang.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}