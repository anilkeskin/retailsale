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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier newMDIChild = new AddSupplier();      
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListSearchSupplier newMDIChild = new ListSearchSupplier();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryProcess newMDIChild = new CategoryProcess();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct newMDIChild = new AddProduct();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stokİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockProcess newMDIChild = new StockProcess();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report newMDIChild = new Report();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
