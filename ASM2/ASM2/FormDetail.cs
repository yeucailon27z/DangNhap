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

namespace ASM2
{
    public partial class FormDetail : Form
    {
        QLYBanHangContext qLY = new QLYBanHangContext();
        public FormDetail()
        {
            InitializeComponent();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {

        }
        public void DisplayOrderDetails(Order selectedOrder)
        {
            // Gán thông tin của đơn hàng vào các điều khiển trên FormDetail
            textBox1.Text = selectedOrder.Id.ToString();
            textBox2.Text = selectedOrder.OrderDate.ToString();
            textBox3.Text = selectedOrder.OrderNumber;
            textBox4.Text = selectedOrder.CustomerId.ToString();
            textBox5.Text = selectedOrder.TotalAmount.ToString();

            // Ví dụ: Hiển thị danh sách sản phẩm trong đơn hàng


            // Các bước tiếp theo: Gán thông tin chi tiết sản phẩm, tổng giá trị, v.v.
        }


        public void DisplayOrderItems(List<OrderItem> orderItems)
        {
            // Xóa tất cả các dòng hiện có trong DataGridView
            dataGridView1.Rows.Clear();

            // Xóa tất cả các cột hiện có trong DataGridView
            dataGridView1.Columns.Clear();

            // Thêm các cột cho DataGridView
            dataGridView1.Columns.Add("OrderIdColumn", "Order ID");
            dataGridView1.Columns.Add("QuantityColumn", "Quantity");
            dataGridView1.Columns.Add("UnitPriceColumn", "Unit Price");
            dataGridView1.Columns.Add("ProductIDColumn", "Product ID");

            // Hiển thị danh sách các mặt hàng trên DataGridView
            foreach (OrderItem orderItem in orderItems)
            {
                dataGridView1.Rows.Add(orderItem.OrderId, orderItem.Quantity, orderItem.UnitPrice, orderItem.ProductId);
            }
        }



    }

}
