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
    public partial class CategoryGrid : Form
    {
        public CategoryGrid()
        {
            InitializeComponent();
        }

        private void CategoryGrid_Load(object sender, EventArgs e)
        {
            AlohaECommerceContext db = new AlohaECommerceContext();

          
            //List<Category> categories = db.Categories.ToList();
           // List<Category> categories = db.Categories.Take(10).ToList();
            List<Category> categories = db.Categories.Where(q => q.Name.StartsWith("a")).ToList();


            dataGridView1.DataSource= categories;





            //id si 3 olan category i databaseden bul ve bana ver

            Category category = db.Categories.FirstOrDefault(q => q.Id == 3);
            //Category category2 = db.Categories.First(q => q.Id == 4);


            Category category3 = db.Categories.Find(4);



            // id si 8 olan categorinin adini Phone olarak degistir
            // update Categories set Name = 'Phone' where Id = 8

            //Category category4 = db.Categories.FirstOrDefault(q => q.Id == 3);
            //category4.Name = "Phone";
            //category4.Description = "Test";

            //db.SaveChanges();


            // id si 5 olan kategoriyi sil
            Category category5 = db.Categories.FirstOrDefault(q => q.Id == 5);

            db.Categories.Remove(category5);
            db.SaveChanges();


        }
    }
}
