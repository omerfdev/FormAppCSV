namespace FormAppCSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxUrunID = new TextBox();
            textBoxUrunAdi = new TextBox();
            textBoxUrunFiyat = new TextBox();
            textBoxKategori = new TextBox();
            btnAra = new Button();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            btnDosyayaKaydet = new Button();
            dataGridView1 = new DataGridView();
            lblLastWrite = new Label();
            btnGuncelle = new Button();
            btnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUrunID
            // 
            textBoxUrunID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunID.Location = new Point(45, 55);
            textBoxUrunID.MaxLength = 100;
            textBoxUrunID.Name = "textBoxUrunID";
            textBoxUrunID.PlaceholderText = "Urun ID";
            textBoxUrunID.Size = new Size(125, 27);
            textBoxUrunID.TabIndex = 0;
            // 
            // textBoxUrunAdi
            // 
            textBoxUrunAdi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunAdi.Location = new Point(45, 88);
            textBoxUrunAdi.MaxLength = 100;
            textBoxUrunAdi.Name = "textBoxUrunAdi";
            textBoxUrunAdi.PlaceholderText = "Ürün Adı";
            textBoxUrunAdi.Size = new Size(125, 27);
            textBoxUrunAdi.TabIndex = 1;
            // 
            // textBoxUrunFiyat
            // 
            textBoxUrunFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunFiyat.Location = new Point(45, 121);
            textBoxUrunFiyat.MaxLength = 100;
            textBoxUrunFiyat.Name = "textBoxUrunFiyat";
            textBoxUrunFiyat.PlaceholderText = "Ürün Fiyat";
            textBoxUrunFiyat.Size = new Size(125, 27);
            textBoxUrunFiyat.TabIndex = 2;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxKategori.Location = new Point(45, 154);
            textBoxKategori.MaxLength = 100;
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.PlaceholderText = "Kategori";
            textBoxKategori.Size = new Size(125, 27);
            textBoxKategori.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(200, 53);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(200, 152);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(94, 29);
            btnUrunEkle.TabIndex = 5;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(300, 152);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(94, 29);
            btnUrunSil.TabIndex = 6;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnSil_Click;
            // 
            // btnDosyayaKaydet
            // 
            btnDosyayaKaydet.Location = new Point(590, 15);
            btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            btnDosyayaKaydet.Size = new Size(94, 67);
            btnDosyayaKaydet.TabIndex = 7;
            btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            btnDosyayaKaydet.UseVisualStyleBackColor = true;
            btnDosyayaKaydet.Click += btnDosyaKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(639, 233);
            dataGridView1.TabIndex = 8;
            // 
            // lblLastWrite
            // 
            lblLastWrite.AutoSize = true;
            lblLastWrite.Location = new Point(12, 5);
            lblLastWrite.Name = "lblLastWrite";
            lblLastWrite.Size = new Size(0, 20);
            lblLastWrite.TabIndex = 9;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(400, 152);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(500, 152);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(lblLastWrite);
            Controls.Add(dataGridView1);
            Controls.Add(btnDosyayaKaydet);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnAra);
            Controls.Add(textBoxKategori);
            Controls.Add(textBoxUrunFiyat);
            Controls.Add(textBoxUrunAdi);
            Controls.Add(textBoxUrunID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(729, 497);
            MinimumSize = new Size(729, 497);
            Name = "Form1";
            Text = "FormAppCSV";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUrunID;
        private TextBox textBoxUrunAdi;
        private TextBox textBoxUrunFiyat;
        private TextBox textBoxKategori;
        private Button btnAra;
        private Button btnUrunEkle;
        private Button btnUrunSil;
        private Button btnDosyayaKaydet;
        private DataGridView dataGridView1;
        private Label lblLastWrite;
        private Button btnGuncelle;
        private Button btnListele;
    }
}