namespace RetailSaleApp
{
    partial class ListSearchSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSearchSupplier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTdkGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtTedarikciAdres = new System.Windows.Forms.RichTextBox();
            this.txtTedarikciTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama ";
            // 
            // btnAllList
            // 
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllList.Image = ((System.Drawing.Image)(resources.GetObject("btnAllList.Image")));
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(280, 16);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(145, 34);
            this.btnAllList.TabIndex = 3;
            this.btnAllList.Text = "Tümünü Listele";
            this.btnAllList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnAllList, "Tüm Tedarikçileri Listelemek İçin Tıklayın.");
            this.btnAllList.UseVisualStyleBackColor = true;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tedarikçi Adı :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox1, "İçine yazdığınız gibi sonuçlar aşağıda listelenecektir.");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 175);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(276, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seçili Tedarikciyi Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.button1, "Yukarıdaki seçili Tedarikçiyi Sistemden Silmek İçin Tıklayınız.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTdkGuncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rtxtTedarikciAdres);
            this.groupBox2.Controls.Add(this.txtTedarikciTelefon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTedarikciAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tedarikçi Güncelleme";
            // 
            // btnTdkGuncelle
            // 
            this.btnTdkGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTdkGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnTdkGuncelle.Image")));
            this.btnTdkGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTdkGuncelle.Location = new System.Drawing.Point(324, 85);
            this.btnTdkGuncelle.Name = "btnTdkGuncelle";
            this.btnTdkGuncelle.Size = new System.Drawing.Size(101, 37);
            this.btnTdkGuncelle.TabIndex = 13;
            this.btnTdkGuncelle.Text = "Güncelle";
            this.btnTdkGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTdkGuncelle, "Yukarıda seçmiş olduğunuz tedarikçinin bilgilerini altta yazdığınız gibi güncelle" +
        "nmesi için tıklayınız. ");
            this.btnTdkGuncelle.UseVisualStyleBackColor = true;
            this.btnTdkGuncelle.Click += new System.EventHandler(this.btnTdkGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tedarikçi Adı        : ";
            // 
            // rtxtTedarikciAdres
            // 
            this.rtxtTedarikciAdres.Location = new System.Drawing.Point(243, 32);
            this.rtxtTedarikciAdres.Name = "rtxtTedarikciAdres";
            this.rtxtTedarikciAdres.Size = new System.Drawing.Size(182, 47);
            this.rtxtTedarikciAdres.TabIndex = 10;
            this.rtxtTedarikciAdres.Text = "";
            // 
            // txtTedarikciTelefon
            // 
            this.txtTedarikciTelefon.Location = new System.Drawing.Point(108, 59);
            this.txtTedarikciTelefon.Name = "txtTedarikciTelefon";
            this.txtTedarikciTelefon.Size = new System.Drawing.Size(129, 20);
            this.txtTedarikciTelefon.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tedarikçi Adresi   : ";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(108, 32);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(129, 20);
            this.txtTedarikciAdi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tedarikçi Telefon :";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ListSearchSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListSearchSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi İşlemleri Listeleme / Arama / Güncelleme";
            this.Load += new System.EventHandler(this.ListSearchSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTdkGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtTedarikciAdres;
        private System.Windows.Forms.TextBox txtTedarikciTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}