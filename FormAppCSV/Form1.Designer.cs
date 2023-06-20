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
            pcBoxProductImage = new PictureBox();
            btnResimYukle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxProductImage).BeginInit();
            SuspendLayout();
            // 
            // textBoxUrunID
            // 
            textBoxUrunID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunID.Location = new Point(45, 22);
            textBoxUrunID.MaxLength = 100;
            textBoxUrunID.Name = "textBoxUrunID";
            textBoxUrunID.PlaceholderText = "Urun ID";
            textBoxUrunID.Size = new Size(125, 27);
            textBoxUrunID.TabIndex = 0;
            // 
            // textBoxUrunAdi
            // 
            textBoxUrunAdi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunAdi.Location = new Point(45, 55);
            textBoxUrunAdi.MaxLength = 100;
            textBoxUrunAdi.Name = "textBoxUrunAdi";
            textBoxUrunAdi.PlaceholderText = "Ürün Adı";
            textBoxUrunAdi.Size = new Size(125, 27);
            textBoxUrunAdi.TabIndex = 1;
            // 
            // textBoxUrunFiyat
            // 
            textBoxUrunFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxUrunFiyat.Location = new Point(45, 88);
            textBoxUrunFiyat.MaxLength = 100;
            textBoxUrunFiyat.Name = "textBoxUrunFiyat";
            textBoxUrunFiyat.PlaceholderText = "Ürün Fiyat";
            textBoxUrunFiyat.Size = new Size(125, 27);
            textBoxUrunFiyat.TabIndex = 2;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxKategori.Location = new Point(45, 121);
            textBoxKategori.MaxLength = 100;
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.PlaceholderText = "Kategori";
            textBoxKategori.Size = new Size(125, 27);
            textBoxKategori.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(45, 170);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(125, 29);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.Lime;
            btnUrunEkle.Location = new Point(586, 38);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(92, 29);
            btnUrunEkle.TabIndex = 5;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.BackColor = Color.FromArgb(192, 0, 0);
            btnUrunSil.Location = new Point(686, 38);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(92, 29);
            btnUrunSil.TabIndex = 6;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = false;
            btnUrunSil.Click += btnSil_Click;
            // 
            // btnDosyayaKaydet
            // 
            btnDosyayaKaydet.BackColor = SystemColors.ActiveCaption;
            btnDosyayaKaydet.Location = new Point(788, 38);
            btnDosyayaKaydet.Name = "btnDosyayaKaydet";
            btnDosyayaKaydet.Size = new Size(94, 67);
            btnDosyayaKaydet.TabIndex = 7;
            btnDosyayaKaydet.Text = "Dosyaya Kaydet";
            btnDosyayaKaydet.UseVisualStyleBackColor = false;
            btnDosyayaKaydet.Click += btnDosyaKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(837, 325);
            dataGridView1.TabIndex = 8;
            // 
            // lblLastWrite
            // 
            lblLastWrite.AutoSize = true;
            lblLastWrite.Location = new Point(45, 563);
            lblLastWrite.Name = "lblLastWrite";
            lblLastWrite.Size = new Size(0, 20);
            lblLastWrite.TabIndex = 9;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Cyan;
            btnGuncelle.Location = new Point(586, 73);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.AppWorkspace;
            btnListele.Location = new Point(686, 73);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(94, 29);
            btnListele.TabIndex = 11;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            // 
            // pcBoxProductImage
            // 
            pcBoxProductImage.Location = new Point(201, 22);
            pcBoxProductImage.Name = "pcBoxProductImage";
            pcBoxProductImage.Size = new Size(125, 127);
            pcBoxProductImage.TabIndex = 12;
            pcBoxProductImage.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.Location = new Point(201, 170);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(125, 29);
            btnResimYukle.TabIndex = 13;
            btnResimYukle.Text = "Resim Yükle";
            btnResimYukle.UseVisualStyleBackColor = true;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 640);
            Controls.Add(btnResimYukle);
            Controls.Add(pcBoxProductImage);
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
            MaximumSize = new Size(935, 687);
            MinimumSize = new Size(935, 687);
            Name = "Form1";
            Text = "FormAppCSV";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxProductImage).EndInit();
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
        private PictureBox pcBoxProductImage;
        private Button btnResimYukle;
    }
}