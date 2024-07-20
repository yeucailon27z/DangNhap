using Microsoft.EntityFrameworkCore;
using System.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        private BikeStoresContext bikeStoresContext = new BikeStoresContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("BrandId", typeof(int));
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("ModelYear", typeof(short));
            dt.Columns.Add("ListPrice", typeof(decimal));
            var listProduct = bikeStoresContext.Products.ToList().Where(p => p.ListPrice > 1500);
            foreach (var product in listProduct)
            {
                DataRow dr = dt.NewRow();
                dr["ProductId"] = product.ProductId;
                dr["ProductName"] = product.ProductName;
                dr["BrandID"] = product.BrandId;
                dr["CategoryID"] = product.CategoryId;
                dr["ModelYear"] = product.ModelYear;
                dr["ListPrice"] = product.ListPrice;
                dt.Rows.Add(dr);
            }
            dvgDanhSach.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("BrandName", typeof(string));
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("ModelYear", typeof(short));
            dt.Columns.Add("ListPrice", typeof(decimal));

            var listProduct2 = bikeStoresContext.Products.ToList()
                .Join(bikeStoresContext.Brands.ToList(),
                p => p.BrandId,
                b => b.BrandId,
                (p, b) => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.BrandId,
                    p.CategoryId,
                    p.ModelYear,
                    p.ListPrice,
                    b.BrandName
                }).Where(c => c.BrandName == "Trek");
            foreach (var product in listProduct2)
            {
                DataRow dr = dt.NewRow();
                dr["ProductId"] = product.ProductId;
                dr["ProductName"] = product.ProductName;
                dr["BrandName"] = product.BrandName;
                dr["CategoryId"] = product.CategoryId;
                dr["ModelYear"] = product.ModelYear;
                dr["ListPrice"] = product.ListPrice;
                dt.Rows.Add(dr);
            }

            dvgDanhSach.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("ModelYear", typeof(short));
            dt.Columns.Add("ListPrice", typeof(decimal));
            var listProduct3 = bikeStoresContext.Products.ToList()
                .Join(bikeStoresContext.OrderItems.ToList(),
                p => p.ProductId,
                o => o.ProductId,
                (p, o) => new
                {
                    p.ProductId,
                    p.ProductName,
                    p.CategoryId,
                    p.ModelYear,
                    p.ListPrice,
                }).Where(o => o.ModelYear == 2017)
                .GroupBy(o => new { o.ProductId, o.ProductName, o.CategoryId, o.ModelYear, o.ListPrice })
                .Select(g => new
                {
                    g.Key.ProductId,
                    g.Key.ProductName,
                    g.Key.CategoryId,
                    g.Key.ModelYear,
                    g.Key.ListPrice,
                    TotalOrders = g.Sum(x => x.ListPrice) // Assuming ListPrice is the relevant field to sum
                })
                .OrderByDescending(x => x.TotalOrders)
                .FirstOrDefault();
            if (listProduct3 != null)
            {
                DataRow dr = dt.NewRow();
                dr["ProductId"] = listProduct3.ProductId;
                dr["ProductName"] = listProduct3.ProductName;
                dr["CategoryId"] = listProduct3.CategoryId;
                dr["ModelYear"] = listProduct3.ModelYear;
                dr["ListPrice"] = listProduct3.ListPrice;
                dt.Rows.Add(dr);
            }

            dvgDanhSach.DataSource = dt;
        }

    }
}