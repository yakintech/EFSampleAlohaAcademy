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
    public partial class AddProduct : Form
    {

    
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AlohaECommerceContext context = new AlohaECommerceContext();

            Product product = new Product();
            product.Name = txtName.Text;
            product.UnitPrice = Convert.ToDouble(txtPrice.Text);
            product.UnitsInStock = Convert.ToInt32(txtStock.Text);


            context.Products.Add(product);
            context.SaveChanges();

            MessageBox.Show("Success");

            LoadData();



        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        void LoadData()
        {
            dataGridView1.DataSource = null;
            AlohaECommerceContext context = new AlohaECommerceContext();
            dataGridView1.DataSource= context.Products.ToList();

        }

        int selectedProductId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Product SelectedRow = dataGridView1.CurrentRow.DataBoundItem as Product;

            txtName.Text = SelectedRow.Name;
            txtPrice.Text = SelectedRow.UnitPrice.ToString();
            txtStock.Text = SelectedRow.UnitsInStock.ToString();
            selectedProductId = Convert.ToInt32(SelectedRow.Id);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AlohaECommerceContext db = new AlohaECommerceContext();
            Product product = db.Products.Find(selectedProductId);

            product.Name = txtName.Text;
            product.UnitPrice = Convert.ToDouble(txtPrice.Text);
            product.UnitsInStock = Convert.ToInt32(txtStock.Text);

            db.SaveChanges();

            LoadData();
        }
    }
}
