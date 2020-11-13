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
    public partial class ListSearchSupplier : Form
    {
        MyContext context = new MyContext();
        public ListSearchSupplier()
        {
            InitializeComponent();
        }

        private void ListSearchSupplier_Load(object sender, EventArgs e)
        {
            LoadGrid();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                txtTedarikciAdi.Text = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                txtTedarikciTelefon.Text = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                rtxtTedarikciAdres.Text = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;


            }
        }
        void LoadGrid()
        {
            var query = from c in context.Supplies select c;
            dataGridView1.DataSource = query.ToList();
        }

     
        private void btnAllList_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            LoadGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = context.Supplies.Where(s => s.SupplierName.Contains(textBox1.Text));
            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supply delSupply = context.Supplies.Find(dataGridView1.SelectedRows[0].Cells[3].Value);
            context.Supplies.Remove(delSupply);
            context.SaveChanges();
            LoadGrid();
        }
       
        private void btnTdkGuncelle_Click(object sender, EventArgs e)
        {
            Supply updateSupply = context.Supplies.Find(dataGridView1.SelectedRows[0].Cells[3].Value);
            var categ = context.Supplies.FirstOrDefault(c => c.Id == updateSupply.Id);
            categ.SupplierAddress = rtxtTedarikciAdres.Text;
            categ.SupplierName = txtTedarikciAdi.Text;
            categ.SupplierPhone = txtTedarikciTelefon.Text;
            context.SaveChanges();
            LoadGrid();
            
        }
    }
}
