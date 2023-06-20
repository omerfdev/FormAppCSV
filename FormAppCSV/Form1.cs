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
            dataGridView1.DataSource = urunYonet.Listele();
            lblLastWrite.Text = $"Create Date:{Directory.GetCreationTime(Directory.GetCurrentDirectory()).ToString()} \nLast Write:{Directory.GetLastWriteTime("urunler.csv")} ";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            urunYonet.Ekle(UruneCevir());
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GridYenile();
        }

        private void GridYenile()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = urunYonet.Listele();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (textBoxUrunID.Text != "")
            {
                int id = int.Parse(textBoxUrunID.Text);
                Urun urun = urunYonet.Bul(id);

                textBoxUrunAdi.Text = urun.UrunAdi;
                textBoxUrunFiyat.Text = urun.Fiyat.ToString();
                textBoxKategori.Text = urun.Kategori;
            }
            else
                MessageBox.Show("Lutfen ID giriniz...");
        }

        private void btnDosyaKaydet_Click(object sender, EventArgs e)
        {
            urunYonet.Kaydet();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urunYonet.Guncelle(UruneCevir());
            GridYenile();
        }

        private Urun UruneCevir()
        {
            Urun urun = new Urun();
            urun.UrunID = int.Parse(textBoxUrunID.Text);
            urun.UrunAdi = textBoxUrunAdi.Text;
            urun.Fiyat = double.Parse(textBoxUrunFiyat.Text);
            urun.Kategori = textBoxKategori.Text;
            urun.Image = pcBoxProductImage.Image;
            return urun;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            urunYonet.Sil(int.Parse(textBoxUrunID.Text));
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