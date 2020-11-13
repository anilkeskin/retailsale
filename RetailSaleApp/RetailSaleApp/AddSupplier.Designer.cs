namespace RetailSaleApp
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtTedarikciAdres = new System.Windows.Forms.RichTextBox();
            this.txtTedarikciAdi = new System.Windows.Forms.TextBox();
            this.txtTedarikciTelefon = new System.Windows.Forms.TextBox();
            this.btnTdkKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi Adı        : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tedarikçi Adresi   : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tedarikçi Telefon :";
            // 
            // rtxtTedarikciAdres
            // 
            this.rtxtTedarikciAdres.Location = new System.Drawing.Point(15, 98);
            this.rtxtTedarikciAdres.Name = "rtxtTedarikciAdres";
            this.rtxtTedarikciAdres.Size = new System.Drawing.Size(230, 87);
            this.rtxtTedarikciAdres.TabIndex = 3;
            this.rtxtTedarikciAdres.Text = "";
            // 
            // txtTedarikciAdi
            // 
            this.txtTedarikciAdi.Location = new System.Drawing.Point(114, 19);
            this.txtTedarikciAdi.Name = "txtTedarikciAdi";
            this.txtTedarikciAdi.Size = new System.Drawing.Size(129, 20);
            this.txtTedarikciAdi.TabIndex = 4;
            // 
            // txtTedarikciTelefon
            // 
            this.txtTedarikciTelefon.Location = new System.Drawing.Point(114, 51);
            this.txtTedarikciTelefon.Name = "txtTedarikciTelefon";
            this.txtTedarikciTelefon.Size = new System.Drawing.Size(129, 20);
            this.txtTedarikciTelefon.TabIndex = 5;
            // 
            // btnTdkKaydet
            // 
            this.btnTdkKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnTdkKaydet.Image")));
            this.btnTdkKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTdkKaydet.Location = new System.Drawing.Point(152, 191);
            this.btnTdkKaydet.Name = "btnTdkKaydet";
            this.btnTdkKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnTdkKaydet.TabIndex = 6;
            this.btnTdkKaydet.Text = "Kaydet";
            this.btnTdkKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTdkKaydet.UseVisualStyleBackColor = true;
            this.btnTdkKaydet.Click += new System.EventHandler(this.btnTdkKaydet_Click);
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 240);
            this.Controls.Add(this.btnTdkKaydet);
            this.Controls.Add(this.txtTedarikciTelefon);
            this.Controls.Add(this.txtTedarikciAdi);
            this.Controls.Add(this.rtxtTedarikciAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tedarikçi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtTedarikciAdres;
        private System.Windows.Forms.TextBox txtTedarikciAdi;
        private System.Windows.Forms.TextBox txtTedarikciTelefon;
        private System.Windows.Forms.Button btnTdkKaydet;
    }
}