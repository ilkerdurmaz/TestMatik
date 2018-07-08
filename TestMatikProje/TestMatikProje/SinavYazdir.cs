using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;

namespace TestMatikProje
{
    public partial class SinavYazdir : Form
    {
        public SinavYazdir()
        {
            InitializeComponent();
            baglan = sunucu.server();
        }
        Baglanti sunucu = new Baglanti();
        SqlConnection baglan = new SqlConnection();
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        private void sinavDoldur()
        {
            da = new SqlDataAdapter("Select *From SINAVLAR", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "SINAVLAR");
            dataGridView1.DataSource = ds.Tables["SINAVLAR"];
            baglan.Close();
        }

        private void SinavYazdir_Load(object sender, EventArgs e)
        {
            sinavDoldur();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)//dateTimePicker'dan alınan tarih değerine göre gridview'de bilgilerin listelenmesi
        {
            da = new SqlDataAdapter("Select *From SINAVLAR where OlusturmaTarihi=@Tarih", baglan);
            da.SelectCommand.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value.Date);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "SINAVLAR");
            dataGridView1.DataSource = ds.Tables["SINAVLAR"];
            baglan.Close();
        }

        private void bListele_Click(object sender, EventArgs e)//sinavAdi textBox'ındaki değere göre gridview'de bilgilerin listelenmesi
        {
            string sinavAdi = tSinavAdiAra.Text;
            if (tSinavAdiAra.TextLength > 0)
            {
                da = new SqlDataAdapter("Select *From SINAVLAR where SinavAdi=@SinavAdi", baglan);
                da.SelectCommand.Parameters.AddWithValue("@SinavAdi", sinavAdi);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SINAVLAR");
                dataGridView1.DataSource = ds.Tables["SINAVLAR"];
                baglan.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN ARANACAK FAKULTEYİ GİRİNİZ");
                sinavDoldur();
            }
        }

        private void bSil_Click(object sender, EventArgs e)//gridview'de seçili olan satırdaki bilgilerin silinmesi işlemi
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Sınavı Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView1.SelectedRows[0].Index;
                    string kayit = "delete from ARSIV where SinavAdi=@SinavAdi\n delete from SINAVLAR where SinavAdi=@SinavAdi";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@SinavAdi", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    sinavDoldur();

                }
                catch
                {
                    MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                    baglan.Close();
                }
            }
        }

        private void bYazdir_Click(object sender, EventArgs e)//TEMP (geçici) tablonun silinmesi ve identity bilgilerinin sıfırlanması, gridview'de seçili olan
        {                                                     //SinavAdi'na göre ARSIV tablosundan gerekli bilgilerin seçilmesi ve yazdırılmak üzere TEMP tablosuna
                                                              //yazılması. Ardından bu tablonun CrystalReport ile raporlanabilmesi için Raporlama forumun açılması.
            
                int secilen = dataGridView1.SelectedRows[0].Index;
                string kayit = "delete TEMP\nDBCC CHECKIDENT ('TEMP', RESEED,0)\nINSERT INTO TEMP (SinavAdi,Soru,A,B,C,D,E) SELECT SinavAdi, Soru, A, B, C, D, E FROM ARSIV WHERE SinavAdi =@SinavAdi";

                komut = new SqlCommand(kayit, baglan);
                baglan.Open();
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@SinavAdi", dataGridView1.Rows[secilen].Cells[1].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();


                Raporlama rapor = new Raporlama();
                rapor.ShowDialog();
           
        }

        private void bAnahtarYaz_Click(object sender, EventArgs e)//cevap anahtarinin bulunduğu listbox'dan bilgilerin çekilip text dosyasına kayıt etmek üzere
        {                                                         //bir showDialog açması.

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                int secilen = dataGridView1.SelectedRows[0].Index;
                StreamWriter Kayit = new StreamWriter(save.FileName);
                
                Kayit.WriteLine(dataGridView1.Rows[secilen].Cells[1].Value.ToString() + " CEVAP ANAHTARI");
                for (int i = 0; i < lbCevapAnahtari.Items.Count; i++)
                {
                    Kayit.WriteLine(lbCevapAnahtari.Items[i]);
                }
                
                Kayit.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//gridview'de seçili olan SinavAdi'na göre ilgili soruların cevaplarının 
        {                                                                               //listBox'a sıralanması
            try
            {
                lbCevapAnahtari.Items.Clear();
                int secilen = dataGridView1.SelectedRows[0].Index;
                string sinavAdi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

                baglan.Open();
                komut = new SqlCommand("select * from ARSIV where SinavAdi=" + "'" + sinavAdi + "'", baglan);
                SqlDataReader veriOku = komut.ExecuteReader();
                int sayac = 1;
                while (veriOku.Read())
                {

                    lbCevapAnahtari.Items.Add(sayac + " - " + veriOku["DogruCevap"]);
                    sayac++;
                }
                veriOku.Close();
                baglan.Close();
            }
            catch
            {
                MessageBox.Show("CEVAP ANAHTARI GÖRÜNTÜLEME BAŞARISIZ!");
            }
        }
    }
}
