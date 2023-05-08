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

namespace EFSample
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }


        private void btnName_Click(object sender, EventArgs e)
        {
            AlohaECommerceContext db = new AlohaECommerceContext();


            string name = txtName.Text;
            string description = txtDescription.Text;

            Category category = new Category();
            category.Name = name;
            category.Description = description;

            db.Categories.Add(category);
            db.SaveChanges();

            MessageBox.Show("Kategori basariyla eklendi");


        }
    }
}
