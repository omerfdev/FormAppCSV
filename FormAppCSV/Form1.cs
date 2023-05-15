using System.Data;
using System;
using System.Text;

namespace FormAppCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        string filePath = @"C:\Data.csv";
        private void Form1_Load(object sender, EventArgs e)
        {
            buttonUrunSil.Enabled = false;
           
            using (StreamReader sr = new StreamReader(@"C:\Users\omerf\source\repos\FormAppCSV\FormAppCSV\bin\Debug\net6.0-windows\Data.csv"))
            {
                DataTable dt = new DataTable();
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
            }


        }
        List<Urun> urunler = new List<Urun>();
        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {

            int id = int.Parse(textBoxUrunID.Text);
            string ad = textBoxUrunAdi.Text;
            double fiyat = Double.Parse(textBoxUrunFiyat.Text);
            string kategori = textBoxKategori.Text;

            urunler.Add(new Urun { UrunID = id, UrunAd = ad, UrunFiyat = fiyat, UrunKategori = kategori });
            dataGridView1.Refresh();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = urunler;
            using (StreamWriter writer = new StreamWriter("Data.csv"))
            {
                writer.WriteLine("UrunID,UrunAd,UrunFiyat,UrunKategori");
                foreach (Urun urun in urunler)
                {
                    writer.WriteLine($"{urun.UrunID},{urun.UrunAd},{urun.UrunFiyat},{urun.UrunKategori}");
                }
                writer.Close();
            }

            textBoxUrunID.Text = "";
            textBoxUrunAdi.Text = "";
            textBoxUrunFiyat.Text = "";
            textBoxKategori.Text = "";

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxUrunID.Text);
            var satır = from urun in urunler
                            where urun.UrunID == id
                            select urun;
           

        }
    }
}