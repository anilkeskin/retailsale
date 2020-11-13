using RetailSaleApp.Entity;
using RetailSaleApp.Enums;
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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        ComboBox comboRenk1 = new ComboBox();
        ComboBox comboRenk2 = new ComboBox();
        ComboBox comboRenk3 = new ComboBox();

        TextBox stok1 = new TextBox();
        TextBox stok2 = new TextBox();
        TextBox stok3 = new TextBox();
        private void button1_Click(object sender, EventArgs e)
        {
            int yenikonum = 0;
            for (int i = 0; i < Convert.ToInt16(comboBox3.Text); i++)
            {
                //Combolar combo
                ComboBox combo = new ComboBox();
                Point konum = new Point(9, yenikonum + 68);
                combo.Location = konum;
                combo.Height = 21;
                combo.Width = 97;
                
                if (i == 0) comboRenk1 = combo;
                else if (i == 1) comboRenk2 = combo;
                else comboRenk3 = combo;
                combo.DataSource = Enum.GetValues(typeof(AppEnums.Colors));
                groupBox1.Controls.Add(combo);


                //Stoklar txt
                TextBox txt = new TextBox();
                Point txtkonum = new Point(112, yenikonum + 68);
                txt.Location = txtkonum;
                txt.Height = 20;
                txt.Width = 82;
                if (i == 0) stok1 = txt;
                else if (i == 1) stok2 = txt;
                else stok3 = txt;
                //txt.Name = "txtStok" + (i + 1);
                groupBox1.Controls.Add(txt);

                yenikonum += 30;


            }


        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            using (var c = new MyContext())
            {
                comboKategori.DataSource = c.Categories.ToList();
                comboKategori.ValueMember = "Id";
                comboKategori.DisplayMember = "CategoryName";


                comboTedarik.DataSource = c.Supplies.ToList();
                comboTedarik.ValueMember = "Id";
                comboTedarik.DisplayMember = "SupplierName";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyContext())
                {
                    Product pr = new Product
                    {
                        ProductName = textBox1.Text,
                        ProductBarcode = textBox3.Text,
                        SellPrice = Convert.ToDouble(textBox2.Text),
                        UnitPrice = Convert.ToDouble(textBox4.Text),
                        CategoryId = (Guid)comboKategori.SelectedValue,
                        SupplierId = (Guid)comboTedarik.SelectedValue
                    };
                    context.ProductTables.Add(pr);
                    context.SaveChanges();

                    ComboBox newColorCombo = new ComboBox();
                    TextBox newStokTxt = new TextBox();
                    for (int i = 0; i < Convert.ToInt16(comboBox3.Text); i++)
                    {
                        if (i == 0)
                        {
                            newColorCombo = comboRenk1;
                            newStokTxt = stok1;

                        }
                        else if (i == 1)
                        {
                            newColorCombo = comboRenk2;
                            newStokTxt = stok2;
                        }
                        else
                        {
                            newColorCombo = comboRenk3;
                            newStokTxt = stok3;
                        }
                        Stock st = new Stock
                        {
                            Color = (AppEnums.Colors)newColorCombo.SelectedValue,
                            Quantity = Convert.ToInt16(newStokTxt.Text),
                            ProductId = pr.Id
                        };
                        context.Stocks.Add(st);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Ürün ve Renkleri Stoklarıyla Beraber Sisteme Başarıyla Kayıt Edildi !");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı Giriş " + ex.ToString()) ;

                throw;
            }
            
        }
    }
}
