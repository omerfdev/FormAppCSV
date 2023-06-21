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
            txtBoxUrunID = new TextBox();
            txtBoxUrunAdi = new TextBox();
            txtBoxUrunFiyat = new TextBox();
            txtBoxKategori = new TextBox();
            btnAra = new Button();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            btnDosyayaKaydet = new Button();
            dataGridViewUrun = new DataGridView();
            lblLastWrite = new Label();
            btnGuncelle = new Button();
            btnListele = new Button();
            pcBoxProductImage = new PictureBox();
            btnResimYukle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxProductImage).BeginInit();
            SuspendLayout();
            // 
            // txtBoxUrunID
            // 
            txtBoxUrunID.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxUrunID.Location = new Point(45, 22);
            txtBoxUrunID.MaxLength = 100;
            txtBoxUrunID.Name = "txtBoxUrunID";
            txtBoxUrunID.PlaceholderText = "Urun ID";
            txtBoxUrunID.Size = new Size(125, 27);
            txtBoxUrunID.TabIndex = 0;
            // 
            // txtBoxUrunAdi
            // 
            txtBoxUrunAdi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxUrunAdi.Location = new Point(45, 55);
            txtBoxUrunAdi.MaxLength = 100;
            txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            txtBoxUrunAdi.PlaceholderText = "Ürün Adı";
            txtBoxUrunAdi.Size = new Size(125, 27);
            txtBoxUrunAdi.TabIndex = 1;
            // 
            // txtBoxUrunFiyat
            // 
            txtBoxUrunFiyat.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxUrunFiyat.Location = new Point(45, 88);
            txtBoxUrunFiyat.MaxLength = 100;
            txtBoxUrunFiyat.Name = "txtBoxUrunFiyat";
            txtBoxUrunFiyat.PlaceholderText = "Ürün Fiyat";
            txtBoxUrunFiyat.Size = new Size(125, 27);
            txtBoxUrunFiyat.TabIndex = 2;
            // 
            // txtBoxKategori
            // 
            txtBoxKategori.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtBoxKategori.Location = new Point(45, 121);
            txtBoxKategori.MaxLength = 100;
            txtBoxKategori.Name = "txtBoxKategori";
            txtBoxKategori.PlaceholderText = "Kategori";
            txtBoxKategori.Size = new Size(125, 27);
            txtBoxKategori.TabIndex = 3;
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
            // dataGridViewUrun
            // 
            dataGridViewUrun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrun.Location = new Point(45, 219);
            dataGridViewUrun.Name = "dataGridViewUrun";
            dataGridViewUrun.RowHeadersWidth = 51;
            dataGridViewUrun.RowTemplate.Height = 29;
            dataGridViewUrun.Size = new Size(837, 325);
            dataGridViewUrun.TabIndex = 8;
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
            Controls.Add(dataGridViewUrun);
            Controls.Add(btnDosyayaKaydet);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunEkle);
            Controls.Add(btnAra);
            Controls.Add(txtBoxKategori);
            Controls.Add(txtBoxUrunFiyat);
            Controls.Add(txtBoxUrunAdi);
            Controls.Add(txtBoxUrunID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(935, 687);
            MinimumSize = new Size(935, 687);
            Name = "Form1";
            Text = "FormAppCSV";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxProductImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxUrunID;
        private TextBox txtBoxUrunAdi;
        private TextBox txtBoxUrunFiyat;
        private TextBox txtBoxKategori;
        private Button btnAra;
        private Button btnUrunEkle;
        private Button btnUrunSil;
        private Button btnDosyayaKaydet;
        private DataGridView dataGridViewUrun;
        private Label lblLastWrite;
        private Button btnGuncelle;
        private Button btnListele;
        private PictureBox pcBoxProductImage;
        private Button btnResimYukle;
    }
}