using System.Data;
using System;
using System.Text;
using System.Linq;


namespace FormAppCSV
{
    public partial class Form1 : Form, IYonetici
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonUrunSil.Enabled = false;
            lblLastWrite.Text = Convert.ToString("Last Write Time: " + Directory.GetLastWriteTime(@"C:\Users\omerf\source\repos\FormAppCSV\FormAppCSV\bin\Debug\net6.0-windows\Data.csv"));
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

        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunKategori { get; set; }
        Urun urun = new Urun();
        public void Sil() { }
        public void Ekle()
        {
            urunler.Add(new Urun { UrunID = int.Parse(textBoxUrunID.Text), UrunAd = textBoxUrunAdi.Text, UrunFiyat = double.Parse(textBoxUrunFiyat.Text), UrunKategori = textBoxKategori.Text });
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

        public void Kaydet()
        {
            void KaydetCSV(string filePath, DataGridView dataGridView)
            {
                string[] headers = dataGridView.Columns.Cast<DataGridViewColumn>()
                                            .Select(column => column.HeaderText)
                                            .ToArray();
                string[][] data = dataGridView.Rows.Cast<DataGridViewRow>()
                                            .Where(row => !row.IsNewRow)
                                            .Select(row => row.Cells.Cast<DataGridViewCell>()
                                                            .Select(cell => cell.Value?.ToString() ?? "")
                                                            .ToArray())
                                            .ToArray();
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(string.Join(",", headers));
                    foreach (string[] row in data)
                    {
                        sw.WriteLine(string.Join(",", row));
                    }
                }
            }

        }
        int indis;
        public void Ara()
        {
            indis = urunler.FindIndex(x => x.UrunID == int.Parse(textBoxUrunID.Text));
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = urunler;
            buttonUrunSil.Enabled = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[indis].Cells[0];
            string arananUrunID = textBoxUrunID.Text;
            int sayacUrunID = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals(arananUrunID))
                    {
                        int UrunIDCell = Convert.ToInt32(cell.Value.ToString());
                        sayacUrunID++;
                        break;
                    }
                }
            }
            if (sayacUrunID == 0)
            {
                MessageBox.Show("ID Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (sayacUrunID >= 1)
            {
                MessageBox.Show("ID detected", "Already exist ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }
        private void buttonUrunSil_Click(object sender, EventArgs e)
        {
            urun.Sil(indis + 1);
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
        private void buttonAra_Click(object sender, EventArgs e)
        {

            Ara();
        }

        private void buttonDosyayaKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }


    }
}