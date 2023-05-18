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
            textBoxUrunID = new TextBox();
            textBoxUrunAdi = new TextBox();
            textBoxUrunFiyat = new TextBox();
            textBoxKategori = new TextBox();
            buttonAra = new Button();
            buttonUrunEkle = new Button();
            buttonUrunSil = new Button();
            buttonDosyayaKaydet = new Button();
            dataGridView1 = new DataGridView();
            lblLastWrite = new Label();
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
            // buttonAra
            // 
            buttonAra.Location = new Point(200, 53);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(94, 29);
            buttonAra.TabIndex = 4;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonUrunEkle
            // 
            buttonUrunEkle.Location = new Point(200, 152);
            buttonUrunEkle.Name = "buttonUrunEkle";
            buttonUrunEkle.Size = new Size(94, 29);
            buttonUrunEkle.TabIndex = 5;
            buttonUrunEkle.Text = "Ürün Ekle";
            buttonUrunEkle.UseVisualStyleBackColor = true;
            buttonUrunEkle.Click += buttonUrunEkle_Click;
            // 
            // buttonUrunSil
            // 
            buttonUrunSil.Location = new Point(316, 152);
            buttonUrunSil.Name = "buttonUrunSil";
            buttonUrunSil.Size = new Size(94, 29);
            buttonUrunSil.TabIndex = 6;
            buttonUrunSil.Text = "Ürün Sil";
            buttonUrunSil.UseVisualStyleBackColor = true;
            buttonUrunSil.Click += buttonUrunSil_Click;
            // 
            // buttonDosyayaKaydet
            // 
            buttonDosyayaKaydet.Location = new Point(556, 114);
            buttonDosyayaKaydet.Name = "buttonDosyayaKaydet";
            buttonDosyayaKaydet.Size = new Size(94, 67);
            buttonDosyayaKaydet.TabIndex = 7;
            buttonDosyayaKaydet.Text = "Dosyaya Kaydet";
            buttonDosyayaKaydet.UseVisualStyleBackColor = true;
            buttonDosyayaKaydet.Click += buttonDosyayaKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(605, 233);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(lblLastWrite);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDosyayaKaydet);
            Controls.Add(buttonUrunSil);
            Controls.Add(buttonUrunEkle);
            Controls.Add(buttonAra);
            Controls.Add(textBoxKategori);
            Controls.Add(textBoxUrunFiyat);
            Controls.Add(textBoxUrunAdi);
            Controls.Add(textBoxUrunID);
            MaximumSize = new Size(729, 497);
            MinimumSize = new Size(729, 497);
            Name = "Form1";
            Text = "Form1";
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
        private Button buttonAra;
        private Button buttonUrunEkle;
        private Button buttonUrunSil;
        private Button buttonDosyayaKaydet;
        private DataGridView dataGridView1;
        private Label lblLastWrite;
    }
}