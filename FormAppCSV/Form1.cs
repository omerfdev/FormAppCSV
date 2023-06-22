using System.Data;
using System;
using System.Text;
using System.Linq;


namespace FormAppCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UrunYonetici urunYonet;
        private void Form1_Load(object sender, EventArgs e)
        {
            urunYonet = new UrunYonetici("urunler.csv");
            urunYonet.Yukle();
            dataGridViewUrun.DataSource = urunYonet.Listele();
            lblLastWrite.Text = $"Create Date:{Directory.GetCreationTime(Directory.GetCurrentDirectory()).ToString()} \nLast Write:{Directory.GetLastWriteTime("urunler.csv")} ";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            urunYonet.Ekle(UruneCevir());
            GridYenile();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GridYenile();
        }

        private void GridYenile()
        {
            dataGridViewUrun.DataSource = "";
            dataGridViewUrun.DataSource = urunYonet.Listele();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtBoxUrunID.Text != "")
            {
                int id = int.Parse(txtBoxUrunID.Text);
                Urun urun = urunYonet.Bul(id);

                txtBoxUrunAdi.Text = urun.UrunAdi;
                txtBoxUrunFiyat.Text = urun.Fiyat.ToString();
                txtBoxKategori.Text = urun.Kategori;
                pcBoxProductImage.Image = urun.Image;
            }
            else
                MessageBox.Show("Lütfen ID giriniz...");
        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            urunYonet.Kaydet();
            GridYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urunYonet.Guncelle(UruneCevir());
            GridYenile();
        }

        private Urun UruneCevir()
        {
            Urun urun = new Urun();
            urun.UrunID = int.Parse(txtBoxUrunID.Text);
            urun.UrunAdi = txtBoxUrunAdi.Text;
            urun.Fiyat = double.Parse(txtBoxUrunFiyat.Text);
            urun.Kategori = txtBoxKategori.Text;
            urun.Image = pcBoxProductImage.Image;
            return urun;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            urunYonet.Sil(int.Parse(txtBoxUrunID.Text));
            GridYenile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            urunYonet.Kaydet();
            DialogResult dr = MessageBox.Show("Dosyayi kaydettiniz mi?", "UYARI", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;


        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Employee Image (png,jpg,gif)|*.png;*.jpg;*.gif)";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pcBoxProductImage.Image = Image.FromFile(ofd.FileName);
                pcBoxProductImage.Tag = Path.GetExtension(ofd.FileName);
                pcBoxProductImage.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else { }
        }
    }
}