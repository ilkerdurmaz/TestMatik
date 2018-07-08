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

namespace TestMatikProje
{
    public partial class Fakulteler : Form
    {
        public Fakulteler()
        {
            InitializeComponent();
            baglan = sunucu.server();
        }
        Baglanti sunucu = new Baglanti();
        SqlConnection baglan = new SqlConnection();
        SqlCommand komut;//Bir çok yerde kullanılacak sql
        SqlDataAdapter da;//nesnelerinin global olarak tanımlanması
        DataSet ds;
        private void Fakulteler_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
       
        void griddoldur() //ekleme, silme, düzenleme gibi tablonun aslını değiştirien işlemlerden 
        {                   //sonra gridview'in otomatik olarak güncellenmesi için tabloyu tekrar okuyan metod
            da = new SqlDataAdapter("Select *From FAKULTELER", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "FAKULTELER");
            dataGridView1.DataSource = ds.Tables["FAKULTELER"];
            baglan.Close();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tFakulteAdi.TextLength > 0)
            {
                try
                {
                    string kayit = "insert into FAKULTELER(FakulteAdi) values (@FakulteAdi)";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@FakulteAdi", tFakulteAdi.Text);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    griddoldur();
                }
                catch
                {
                    MessageBox.Show("EKLEME İŞLEMİ BAŞARISIZ");
                    baglan.Close();
                }
            }
            else
                MessageBox.Show("FAKÜLTE ADI BOŞ BIRAKILAMAZ!");
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tFakulteAdi.Clear();
            tFakulteAdiAra.Clear();
            tFakulteNoAra.Clear();
        }

        private void bTemizle2_Click(object sender, EventArgs e)
        {
            tFakulteAdi2.Clear();
            tFakulteAdiAra.Clear();
            tFakulteNoAra.Clear();
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index;

                if (tFakulteAdi2.TextLength > 0)
                {
                    try
                    {
                        string kayit = "update FAKULTELER set FakulteAdi=@FakulteAdi where FakulteNo=@FakulteNo";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@FakulteNo", dataGridView1.Rows[secilen].Cells[0].Value);
                        komut.Parameters.AddWithValue("@FakulteAdi",tFakulteAdi2.Text);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        griddoldur();

                    }
                    catch
                    {
                        MessageBox.Show("DÜZENLEME İŞLEMİ BAŞARISIZ");
                        baglan.Close();
                    }
                }
                else
                    MessageBox.Show("FAKULTE ADI BOŞ BIRAKILAMAZ!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index;
            tFakulteAdi2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void tFakulteNoAra_TextChanged(object sender, EventArgs e)
        {
            int fakulteNo;
            bool k = Int32.TryParse(tFakulteNoAra.Text, out fakulteNo);

            if (k && fakulteNo > 0)
            {
                da = new SqlDataAdapter("Select *From FAKULTELER where FakulteNo=@FakulteNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@FakulteNo", fakulteNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "FAKULTELER");
                dataGridView1.DataSource = ds.Tables["FAKULTELER"];
                baglan.Close();
            }
            else
                griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fakulteAdi = tFakulteAdiAra.Text;
            if (tFakulteAdiAra.TextLength > 0)
            {
                da = new SqlDataAdapter("Select *From FAKULTELER where FakulteAdi=@FakulteAdi", baglan);
                da.SelectCommand.Parameters.AddWithValue("@FakulteAdi", fakulteAdi);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "FAKULTELER");
                dataGridView1.DataSource = ds.Tables["FAKULTELER"];
                baglan.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN ARANACAK FAKULTEYİ GİRİNİZ");
                griddoldur();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Fakülteyi Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView1.SelectedRows[0].Index;
                    string kayit = "delete from FAKULTELER where FakulteNo=@FakulteNo";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@FakulteNo", dataGridView1.Rows[secilen].Cells[0].Value);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    griddoldur();

                }
                catch
                {
                    MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                    baglan.Close();
                }
            }
        }
    }
}
