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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Sorular sorular = new Sorular();    //Sorular formunu showdialog şeklinde açan bölüm
            sorular.ShowDialog();
        }

        private void bders_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();     //Dersler formunu showdialog şeklinde açan bölüm
            dersler.ShowDialog();
        }

        private void bSinavOlustur_Click(object sender, EventArgs e)
        {
            SinavHazirla sinav = new SinavHazirla();    //SinavHazirla formunu showdialog şeklinde açan bölüm
            sinav.ShowDialog();
        }

        private void bhoca_Click(object sender, EventArgs e)
        {
            Hoca hoca = new Hoca();  //Hoca formunu showdialog şeklinde açan bölüm
            hoca.ShowDialog();
        }

        private void bFakulte_Click(object sender, EventArgs e)
        {
            Fakulteler fakulte = new Fakulteler();   //Fakulteler formunu showdialog şeklinde açan bölüm
            fakulte.ShowDialog();
        }

        private void bHakkinda_Click(object sender, EventArgs e) //Hakkında butonuna basıldığında gerekli bilgileri gösterme
        {
            MessageBox.Show("TESTMATİK V1.0\nİSKENDERUN TEKNİK ÜNİVERSİTESİ\nVERİTABANI DESTEKLİ GÖRSEL PROGRAMLAMA PROJESİ\nİLKER DURMAZ (No:151103017)\nilker.prime@gmail.com");
        }

        private void bSinavYazdir_Click(object sender, EventArgs e)
        {
            SinavYazdir yazdir = new SinavYazdir();  //SinavHazirla formunu showdialog şeklinde açan bölüm
            yazdir.ShowDialog();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
