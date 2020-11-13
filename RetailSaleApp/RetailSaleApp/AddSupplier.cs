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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnTdkKaydet_Click(object sender, EventArgs e)
        {
            if (txtTedarikciAdi.Text=="" || txtTedarikciTelefon.Text=="" || rtxtTedarikciAdres.Text=="")
            {
                MessageBox.Show("Hiçbir Alan Boş Bırakılmamalıdır.");
            }
            else
            {
                using (var context=new MyContext())
                {
                    Supply supply = new Supply
                    {
                        SupplierName = txtTedarikciAdi.Text,
                        SupplierAddress = rtxtTedarikciAdres.Text,
                        SupplierPhone = txtTedarikciTelefon.Text
                    };
                    context.Supplies.Add(supply);
                    context.SaveChanges();
                    MessageBox.Show("Tedarikçi Sisteme Eklendi !");
                }
                this.Close();
            }
        }
    }
}
