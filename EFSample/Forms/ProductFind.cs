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
    public partial class ProductFind : Form
    {
        public ProductFind()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            AlohaECommerceContext db = new AlohaECommerceContext();

            // id ye gore product bulsun ve ozelliklerini labellarda yazsin
            int productID = Convert.ToInt32(txtId.Text);

            //Product product = db.Products.Find(productID);
            Product product = db.Products.FirstOrDefault(q => q.Id == productID);

            if (product != null)
            {
                lblName.Text = product.Name;
                lblPrice.Text = product.UnitPrice.ToString();
            }
            else
            {
                MessageBox.Show("Urun bulunamadi");
            }


        }
    }
}
