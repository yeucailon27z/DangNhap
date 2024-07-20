using BLL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ASM2
{
    public partial class FormProduct : Form
    {
        BLLProduct bLLProduct = new BLLProduct();
        DataTable dt = new DataTable();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            bool str;
            if (chkIsDisC.Checked == true)
            {
                str = true;
            }
            else
            {
                str = false;
            }

            Product pr = new Product()
            {
                ProductName = txtName.Text,
                SupplierId = int.Parse(txtSupplier.Text),
                UnitPrice = decimal.Parse(txtPrice.Text),
                Package = txtPackage.Text,
                IsDiscontinued = str
            };
            var products = bLLProduct.AddProducts(pr);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtID.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtSupplier.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txtPackage.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            if (dataGridView1.Rows[d].Cells[5].Value.Equals(true))
                chkIsDisC.Checked = true;
            else
                chkIsDisC.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int ID = int.Parse(txtID.Text);
            Product nhanVienSua = bLLProduct.TimID(ID);
            if (nhanVienSua != null)
            {
                nhanVienSua.ProductName = txtName.Text;
                nhanVienSua.SupplierId = int.Parse(txtSupplier.Text);
                nhanVienSua.UnitPrice = decimal.Parse(txtPrice.Text);
                nhanVienSua.Package = txtPackage.Text;
                if (chkIsDisC.Checked == true)
                {
                    nhanVienSua.IsDiscontinued = true;
                }
                else
                {
                    nhanVienSua.IsDiscontinued = false;
                }
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            Product nhanVienXoa = bLLProduct.TimID(ID);

            if (nhanVienXoa != null)
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.OK)
                {
                    txtID.Clear();
                    txtName.Clear();
                    txtPackage.Clear();
                    txtPrice.Clear();
                    txtSupplier.Clear();
                    chkIsDisC.Checked = false;
                    dt.Rows.Clear();
                    bLLProduct.DeleteProduct(ID);
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
                    
                }
                dataGridView1.DataSource = dt;
            }

        }
    }
 }


