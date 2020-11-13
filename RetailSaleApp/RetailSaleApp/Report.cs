using RetailSaleApp.Enums;
using RetailSaleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using RetailSaleApp.Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace RetailSaleApp
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            var data = (from stock in context.Stocks
                        join product in context.ProductTables on stock.ProductId equals product.Id
                        
                        select new ReportVm
                        {
                            ProductName = product.ProductName,
                            Color = stock.Color,
                            Quantity = stock.Quantity,
                            UnitPrice=product.UnitPrice,
                            SellPrice=product.SellPrice
                        }).ToList();
            dataGridView1.DataSource = data;
            double totalUnitPrice = 0;
            double totalSellPrice = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                totalUnitPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                totalSellPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            label5.Text = totalUnitPrice.ToString() + " ₺";
            label6.Text = totalSellPrice.ToString() + " ₺";
            label7.Text = (totalSellPrice - totalUnitPrice).ToString() + " ₺";



        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
        MyContext context = new MyContext();

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void KritikStok()
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value) <=3)
                {
                    renk.BackColor = Color.Red;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            KritikStok();
        }
        int veri = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            
            int azalanstok = Convert.ToInt16(textBox4.Text);
            if (checkBox1.Checked==true)
            {
                var data = (from stock in context.Stocks
                            join product in context.ProductTables
                            on stock.ProductId equals product.Id
                            where (stock.Quantity <= azalanstok && stock.Quantity != 0)
                            select new ReportVm
                            {
                                ProductName = product.ProductName,
                                Color = stock.Color,
                                Quantity = stock.Quantity,
                                UnitPrice = product.UnitPrice,
                                SellPrice=product.SellPrice
                            }).ToList();

                if (radioButton1.Checked == true) veri = 0;
                else if (radioButton2.Checked == true) veri = 1;
                else veri = 2;

                dataGridView1.DataSource = list(data, veri);
                double totalUnitPrice = 0;
                double totalSellPrice = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    totalUnitPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    totalSellPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                label5.Text = totalUnitPrice.ToString() + " ₺";
                label6.Text = totalSellPrice.ToString() + " ₺";
                label7.Text = (totalSellPrice - totalUnitPrice).ToString() + " ₺";

            }
            else
            {
                var data = (from stock in context.Stocks
                            join product in context.ProductTables
                            on stock.ProductId equals product.Id
                            where stock.Quantity <= azalanstok
                            select new ReportVm
                            {
                                ProductName = product.ProductName,
                                Color = stock.Color,
                                Quantity = stock.Quantity,
                                UnitPrice = product.UnitPrice,
                                SellPrice = product.SellPrice
                            }).ToList();
                if (radioButton1.Checked == true) veri = 0;
                else if (radioButton2.Checked == true) veri = 1;
                else veri = 2;
                dataGridView1.DataSource = list(data, veri);
                double totalUnitPrice = 0;
                double totalSellPrice = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    totalUnitPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)*Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    totalSellPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                label5.Text = totalUnitPrice.ToString() + " ₺";
                label6.Text = totalSellPrice.ToString() + " ₺";
                label7.Text = (totalSellPrice - totalUnitPrice).ToString() + " ₺";
            }
           

            
        }
        List<ReportVm> list (List<ReportVm> data,int sayi)
        {
            switch (sayi)
            {
                case 0:
                    return data.OrderBy(o => o.Quantity).ToList();
                    
                case 1:
                    return data.OrderByDescending(o => o.Quantity).ToList();
                    
                case 2:
                    return data.OrderBy(o => o.ProductName).ToList();
                default:
                    return data; 
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var data = (from stock in context.Stocks
                        join product in context.ProductTables
                        on stock.ProductId equals product.Id
                        where stock.Quantity == 0
                        select new ReportVm
                        {
                            ProductName = product.ProductName,
                            Color = stock.Color,
                            Quantity = stock.Quantity
                        }).ToList();
            dataGridView1.DataSource = data;
            label5.Text = "0 ₺";
            label6.Text = "0 ₺";
            label7.Text = "0 ₺";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var data = (
                from s in context.Stocks
                join p in context.ProductTables on s.ProductId equals p.Id
                join c in context.Categories on p.CategoryId equals c.Id
                join t in context.Supplies on p.SupplierId equals t.Id
                select new ReportGeneral
                {
                    ProductName = p.ProductName,
                    ProductCategory = c.CategoryName,
                    ProductSupplier = t.SupplierName,
                    Color = s.Color,
                    Quantity = s.Quantity,
                    UnitPrice = p.UnitPrice,
                    SellPrice=p.SellPrice

                }
                ).ToList();
             dataGridView1.DataSource = data;
            double totalUnitPrice = 0;
            double totalSellPrice = 0;
            
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                totalUnitPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                totalSellPrice += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
            label5.Text = totalUnitPrice.ToString() + " ₺";
            label6.Text = totalSellPrice.ToString() + " ₺";
            label7.Text = (totalSellPrice - totalUnitPrice).ToString() + " ₺";
        }
        public static void PDF_Disa_Aktar(DataGridView dataGridView1)
        {
            //using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
            SaveFileDialog save = new SaveFileDialog();
            save.OverwritePrompt = false;
            save.Title = "PDF Dosyaları";
            save.DefaultExt = "pdf";
            save.Filter = "PDF Dosyaları (*.pdf)|*.pdf|Tüm Dosyalar(*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                
                pdfTable.DefaultCell.Padding = 3; 
                pdfTable.WidthPercentage = 80; 
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;
                

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240); 
                    pdfTable.AddCell(cell);
                }
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                using (FileStream stream = new FileStream(save.FileName + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PDF_Disa_Aktar(dataGridView1);
        }
    }
}
