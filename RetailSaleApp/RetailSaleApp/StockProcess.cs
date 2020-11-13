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
    public partial class StockProcess : Form
    {
        public StockProcess()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = context.ProductTables.Where(s => s.ProductBarcode.Contains(textBox1.Text));
            dataGridView1.DataSource = query.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var query = context.ProductTables.Where(s => s.ProductName.Contains(textBox2.Text));
            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Guid qu =(Guid) dataGridView1.SelectedRows[0].Cells[8].Value;
                var query = context.Stocks.Where(s => s.ProductId==qu);
                dataGridView2.DataSource = query.ToList();
            }
        }
        void LoadGrid()
        {
            var query = from c in context.ProductTables select c;
            dataGridView1.DataSource = query.ToList();
        }
        private void StockProcess_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stock updateSt = context.Stocks.Find(dataGridView2.SelectedRows[0].Cells[4].Value);
            var categ = context.Stocks.FirstOrDefault(c => c.Id == updateSt.Id);
            categ.Quantity = categ.Quantity - 1;
            context.SaveChanges();
            MessageBox.Show("Stok Azaltıldı");
            this.Close();
        }
    }
}
