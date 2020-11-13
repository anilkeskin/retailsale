using RetailSaleApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailSaleApp
{
    public partial class CategoryProcess : Form
    {
        public CategoryProcess()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        void LoadGrid()
        {
            var query = from c in context.Categories select c;
            dataGridView1.DataSource = query.ToList();
        }
        private void btnTdkKaydet_Click(object sender, EventArgs e)
        {
            Category supply = new Category{CategoryName = txtKategoriAdi.Text};
            context.Categories.Add(supply);
            context.SaveChanges();
            MessageBox.Show("Kategori Sisteme Eklendi !");
            txtKategoriAdi.Text = "";
            LoadGrid();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = context.Categories.Where(s => s.CategoryName.Contains(txtKategoriAdiSearch.Text));
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category delCat = context.Categories.Find(dataGridView1.SelectedRows[0].Cells[1].Value);
            context.Categories.Remove(delCat);
            context.SaveChanges();
            LoadGrid();
        }

        private void btnTdkGuncelle_Click(object sender, EventArgs e)
        {
            Category updateCat = context.Categories.Find(dataGridView1.SelectedRows[0].Cells[1].Value);
            var categ = context.Categories.FirstOrDefault(c => c.Id == updateCat.Id);
            categ.CategoryName = txtTedarikciAdi.Text;
            context.SaveChanges();
            LoadGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtTedarikciAdi.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
            }
        }

        private void CategoryProcess_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
