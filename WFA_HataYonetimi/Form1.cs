using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            int telefon = Convert.ToInt32(txtGelenDeger.Text);
            MessageBox.Show("Tebrikler Telefon Numarasını Düzgün Girebildin!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int telefon = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Telefon Numarasını Düzgün Girebildin!");
            }
            catch
            {
                MessageBox.Show("hata ile karşılaştık, lütfen tekrar deneyiniz!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int telefon = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Telefon Numarasını Düzgün Girebildin!");
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata ile karşılaştık, lütfen tekrar deneyiniz!");
                MessageBox.Show(hata.Message);
            }
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            try
            {
                int telefon = Convert.ToInt32(txtGelenDeger.Text);
                MessageBox.Show("Tebrikler Telefon Numarasını Düzgün Girebildin!");

                //int sayi = 0;
                //int sonuc = 10 / sayi;
            }
            catch (DivideByZeroException ex)
            {
                // sıfıra bölünme hatası
            }
            catch (FormatException ex)
            {
                // yanlış formatta veri tipi gönderme
            }
            catch (OverflowException ex)
            {
                // bir nesnenin alabileceğinden fazla değer gönderme
            }
            catch (SqlException ex)
            {
                // Sql işlemleri sırasında bir hata ile karşılaşılır ise,  ADO.NET kullanıyorsanız.
            }
            catch (Exception hata)
            {
                // Yukarıda yer alan hatalar haricinde bir durum ile karşılaşılır ise
                MessageBox.Show("hata ile karşılaştık, lütfen tekrar deneyiniz!");
                MessageBox.Show(hata.Message);
            }
        }
    }
}
