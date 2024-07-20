using BLL;
using DAL;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM2
{
    public partial class FormOrder : Form
    {
        QLYBanHangContext QLYBanHangContext = new QLYBanHangContext();
        OderBLL oderBLL = new OderBLL();
        DataTable dt = new DataTable();
        public FormOrder()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy đơn hàng được chọn từ DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                Order selectedOrder = new Order()
                {
                    Id = Convert.ToInt32(selectedRow.Cells["OderId"].Value),
                    OrderDate = Convert.ToDateTime(selectedRow.Cells["OrderDate"].Value),
                    OrderNumber = selectedRow.Cells["OrderNumber"].Value.ToString(), // Sử dụng tên cột chính xác
                    CustomerId = Convert.ToInt32(selectedRow.Cells["OderCustomerID"].Value), // Sử dụng tên cột chính xác
                    TotalAmount = Convert.ToDecimal(selectedRow.Cells["OderTotalAmount"].Value) // Sử dụng tên cột chính xác và chuyển đổi kiểu dữ liệu nếu cần
                };


                // Hiển thị form chi tiết đơn hàng và gán thông tin đơn hàng vào form
                FormDetail detailForm = new FormDetail();
                detailForm.DisplayOrderDetails(selectedOrder);

                // Tìm kiếm và hiển thị các mặt hàng của đơn hàng trên form chi tiết
                var orderItems = GetOrderItemsByOrderId(selectedOrder.Id);
                detailForm.DisplayOrderItems(orderItems);

                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an Order first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {

            List<OrderItem> orderItems = new List<OrderItem>();

            var allOrderItems = QLYBanHangContext.OrderItems.ToList();
            foreach (OrderItem orderItem in allOrderItems)
            {
                if (orderItem.OrderId == orderId)
                {
                    orderItems.Add(orderItem);
                }
            }

            return orderItems;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("OderID", typeof(int));
            dt.Columns.Add("OrderDate", typeof(DateTime));
            dt.Columns.Add("OrderNumber", typeof(string));
            dt.Columns.Add("OderCustomerId", typeof(int));
            dt.Columns.Add("OderTotalAmount", typeof(decimal));

            var orders = oderBLL.GetALLOder();
            foreach (var order in orders)
            {
                DataRow dr = dt.NewRow();
                dr["OderID"] = order.Id;
                dr["OrderDate"] = order.OrderDate;
                dr["OrderNumber"] = order.OrderNumber;
                dr["OderCustomerId"] = order.CustomerId;
                dr["OderTotalAmount"] = order.TotalAmount;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order or = new Order()
            {
                OrderDate = DateTime.ParseExact(dateTimePicker1.Text.Trim(), "M/d/yyyy", CultureInfo.InvariantCulture),
                CustomerId = int.Parse(txtCustomID.Text),
                TotalAmount = decimal.Parse(txtTotalAmount.Text)
            };

            var orders = oderBLL.AddOrders(or);
            foreach (var order in orders)
            {
                DataRow dr = dt.NewRow();
                dr["OderID"] = order.Id;
                dr["OrderDate"] = order.OrderDate;
                dr["OrderNumber"] = order.OrderNumber;
                dr["OderCustomerId"] = order.CustomerId;
                dr["OderTotalAmount"] = order.TotalAmount;
                dt.Rows.Add(dr);

            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtID.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[d].Cells[1].Value.ToString());
            txtOrderNumber.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            txtCustomID.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txtTotalAmount.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            int ID = int.Parse(txtID.Text);
            Order orderSua = oderBLL.TimID(ID);
            if (orderSua != null)
            {
                orderSua.OrderDate = DateTime.ParseExact(dateTimePicker1.Text.Trim(), "M/d/yyyy", CultureInfo.InvariantCulture);
                orderSua.CustomerId = int.Parse(txtCustomID.Text);
                orderSua.TotalAmount = decimal.Parse(txtTotalAmount.Text);
                var orders = oderBLL.AddOrders(orderSua);
                foreach (var order in orders)
                {
                    DataRow dr = dt.NewRow();
                    dr["OderID"] = order.Id;
                    dr["OrderDate"] = order.OrderDate;
                    dr["OrderNumber"] = order.OrderNumber;
                    dr["OderCustomerId"] = order.CustomerId;
                    dr["OderTotalAmount"] = order.TotalAmount;
                    dt.Rows.Add(dr);

                }
                dataGridView1.DataSource = dt;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            Order orderXoa = oderBLL.TimID(ID);

            if (orderXoa != null)
            {
                DialogResult re = MessageBox.Show("Bạn chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (re == DialogResult.OK)
                {
                    txtID.Clear();
                    dateTimePicker1.ResetText();
                    txtOrderNumber.Clear();
                    txtCustomID.Clear();
                    txtTotalAmount.Clear();
                    oderBLL.DeleteOrder(ID);
                    var orders = oderBLL.GetALLOder();
                    foreach (var order in orders)
                    {
                        DataRow dr = dt.NewRow();
                        dr["OderID"] = order.Id;
                        dr["OrderDate"] = order.OrderDate;
                        dr["OrderNumber"] = order.OrderNumber;
                        dr["OderCustomerId"] = order.CustomerId;
                        dr["OderTotalAmount"] = order.TotalAmount;
                        dt.Rows.Add(dr);

                    }
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }
    }
}
