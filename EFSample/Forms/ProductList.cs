using EFSample.Dtos;
using EFSample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSample.Forms
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            AlohaECommerceContext db = new AlohaECommerceContext();
            List<Product> products = db.Products.ToList();

            List<ProductGridDto> data = new List<ProductGridDto>();



            foreach (var product in products) {
                ProductGridDto model = new ProductGridDto();
                model.Name = product.Name.ToUpper();
                model.UnitsInStock= product.UnitsInStock;
                model.UnitPrice = product.UnitPrice;
                model.TaxPrice = product.UnitPrice * 1.18;

                data.Add(model);

            }

            //data = products.Select(x => new ProductGridDto()
            //{
            //    Name= x.Name.ToUpper(),
            //    TaxPrice = x.UnitPrice * 1.18,
            //    UnitsInStock = x.UnitsInStock,
            //}).ToList();


            dataGridView1.DataSource= data;


        }
    }
}
