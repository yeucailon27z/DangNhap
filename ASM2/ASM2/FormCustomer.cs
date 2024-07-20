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
using System.Xml.Linq;

namespace ASM2
{
    public partial class FormCustomer : Form
    {
        CustomerBLL customerBLL = new CustomerBLL();
        DataTable dt = new DataTable();
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("CustomerFirstName", typeof(string));
            dt.Columns.Add("CustomerLastName", typeof(string));
            dt.Columns.Add("CustomerCity", typeof(string));
            dt.Columns.Add("CustomerCountry", typeof(string));
            dt.Columns.Add("CusotmerPhone", typeof(string));
            var customers = customerBLL.GetALLCustomer();
            foreach (var customer in customers)
            {
                DataRow dr = dt.NewRow();
                dr["CustomerID"] = customer.Id;
                dr["CustomerFirstName"] = customer.FirstName;
                dr["CustomerLastName"] = customer.LastName;
                dr["CustomerCity"] = customer.City;
                dr["CustomerCountry"] = customer.Country;
                dr["CusotmerPhone"] = customer.Phone;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                Phone = txtPhone.Text
            };
            var customers = customerBLL.AddCustomers(cus);
            foreach (var customer in customers)
            {
                DataRow dr = dt.NewRow();
                dr["CustomerID"] = customer.Id;
                dr["CustomerFirstName"] = customer.FirstName;
                dr["CustomerLastName"] = customer.LastName;
                dr["CustomerCity"] = customer.City;
                dr["CustomerCountry"] = customer.Country;
                dr["CusotmerPhone"] = customer.Phone;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtID.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txtCountry.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[d].Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int ID = int.Parse(txtID.Text);
            Customer customerSua = customerBLL.TimID(ID);
            if (customerSua != null)
            {
                customerSua.FirstName = txtFirstName.Text;
                customerSua.LastName = txtLastName.Text;
                customerSua.City = txtCity.Text;
                customerSua.Country = txtCountry.Text;
                customerSua.Phone = txtPhone.Text;
            }
            var customers = customerBLL.GetALLCustomer();
            foreach (var customer in customers)
            {
                DataRow dr = dt.NewRow();
                dr["CustomerID"] = customer.Id;
                dr["CustomerFirstName"] = customer.FirstName;
                dr["CustomerLastName"] = customer.LastName;
                dr["CustomerCity"] = customer.City;
                dr["CustomerCountry"] = customer.Country;
                dr["CusotmerPhone"] = customer.Phone;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            Customer customerXoa = customerBLL.TimID(ID);

            if (customerXoa != null)
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.OK)
                {
                    txtID.Clear();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtCity.Clear();
                    txtCountry.Clear();
                    txtPhone.Clear();
                    customerBLL.DeleteCustomer(ID);
                    var customers = customerBLL.GetALLCustomer();
                    foreach (var customer in customers)
                    {
                        DataRow dr = dt.NewRow();
                        dr["CustomerID"] = customer.Id;
                        dr["CustomerFirstName"] = customer.FirstName;
                        dr["CustomerLastName"] = customer.LastName;
                        dr["CustomerCity"] = customer.City;
                        dr["CustomerCountry"] = customer.Country;
                        dr["CusotmerPhone"] = customer.Phone;
                        dt.Rows.Add(dr);
                    }
                    dataGridView1.DataSource = dt;
                }
            }

        }
    }
}
