using BLL;
using DTO.Models;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class FormBanHang : Form
    {
        QLYBanHangContext dbQLY = new QLYBanHangContext();
        BLLProduct bLLProduct = new BLLProduct();
        DataTable dt = new DataTable();
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            dataGridView2.Columns.Add("CustomerNameColumn", "Customer Name");
            dataGridView2.Columns.Add("ProductNameColumn", "Product Name");
            dataGridView2.Columns.Add("UnitPriceColumn", "Unit Price");
            dataGridView2.Columns.Add("QuantityColumn", "Quantity");
            comboBox1.DataSource = dbQLY.Customers.ToList();
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "Id";
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("SupplierId", typeof(int));
            dt.Columns.Add("ProductPrice", typeof(decimal));
            dt.Columns.Add("ProductPackage", typeof(string));
            dt.Columns.Add("IsDiscontinued", typeof(bool));
            var products = bLLProduct.GetALLProducts();
            foreach (var product in products)
            {
                DataRow dr = dt.NewRow();
                dr["ProductID"] = product.Id;
                dr["ProductName"] = product.ProductName;
                dr["SupplierId"] = product.SupplierId;
                dr["ProductPrice"] = product.UnitPrice;
                dr["ProductPackage"] = product.Package;
                dr["IsDiscontinued"] = product.IsDiscontinued;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị từ ô TextBox và chuyển về chữ thường để dễ so sánh
            string filter = textBox1.Text.ToLower();

            // Lọc danh sách sản phẩm dựa trên tên sản phẩm
            List<Product> filteredProducts = dbQLY.Products.Where(p => p.ProductName.ToLower().Contains(filter)).ToList();

            // Hiển thị danh sách sản phẩm đã lọc trong một danh sách hoặc bảng sản phẩm
            DisplayFilteredProducts(filteredProducts);

        }
        private void DisplayFilteredProducts(List<Product> filteredProducts)
        {
            // Xóa tất cả các dòng hiện có trong DataGridView
            dt.Rows.Clear();

            // Thêm các sản phẩm đã lọc vào DataGridView
            foreach (var product in filteredProducts)
            {
                DataRow dr = dt.NewRow();
                dr["ProductID"] = product.Id;
                dr["ProductName"] = product.ProductName;
                dr["SupplierId"] = product.SupplierId;
                dr["ProductPrice"] = product.UnitPrice;
                dr["ProductPackage"] = product.Package;
                dr["IsDiscontinued"] = product.IsDiscontinued;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        private void AddProductToSelectedList(Product product, int quantity, string customerName)
        {
            // Tạo các cột cho DataGridView
            

            object[] row = new object[] { customerName, product.ProductName, product.UnitPrice, quantity };

            // Thêm hàng mới vào DataGridView
            dataGridView2.Rows.Add(row);
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                string str = comboBox1.Text;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string productName = selectedRow.Cells["ProductName"].Value != null ? selectedRow.Cells["ProductName"].Value.ToString() : string.Empty;
                decimal price = Convert.ToDecimal(selectedRow.Cells["ProductPrice"].Value);
                Product selectedProduct = new Product
                {
                    ProductName = productName,
                    UnitPrice = price
                };

                SoLuong quantityForm = new SoLuong();
                if (quantityForm.ShowDialog() == DialogResult.OK)
                {
                    int quantity = quantityForm.Quantity;
                    AddProductToSelectedList(selectedProduct, quantity, str);
                }
            }

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "QuantityColumn")
            {
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toan thanh cong!","Thong Bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
