using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {

        string metin = "";
        string anahtar = "";
        string sifrelimetin = "";
        string cözülenmetin = "";
        int anahtar_uzunluk;
        int[] anahtarRakamlari;
        string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
        char Karakter = 'a';


        public Form1()
        {
            InitializeComponent();
        }

        void anahtarOlustur()
        {
            anahtar = txtAnahtar.Text.ToLower();
            anahtar_uzunluk = anahtar.Length;
            anahtarRakamlari = new int[anahtar_uzunluk];


            for (int j = 0; j < anahtar_uzunluk; j++)
            {
                for (int i = 0; i < 29; i++)
                {
                    if (anahtar[j] == alfabe[i])
                    {
                        anahtarRakamlari[j] = i;
                    }
                }
            }
        }

        void Karakterler()
        {
            int fark = metin.Length % anahtar_uzunluk;
            if (fark != 0)
            {
                int fark1 = anahtar_uzunluk - fark;
                for (int i = 0; i < fark1; i++)
                {
                    metin += Karakter;
                }
            }
        }


        private void btnSifrele_Click(object sender, EventArgs e)
        {
            metin= txtMetin.Text.ToLower();
            sifrelimetin = "";
            anahtarOlustur();
            Karakterler();
            int sayi = 0;

            while (sayi < metin.Length)
            {
                for (int j = 0; j < anahtar_uzunluk; j++)
                {
                    bool sonuc = false;

                    for (int k = 0; k < 29; k++)
                    {
                        if (metin[sayi+j] == alfabe[k] )
                        {
                            sonuc = true;
                            int Number = k + anahtarRakamlari[j];

                            Number = Number % 29;
                            sifrelimetin += alfabe[Number];
                        }
                    }

                       if (!sonuc)
                        sifrelimetin += metin[sayi + j];
                
                }
                sayi += anahtar_uzunluk;
            }

            txtSifreli.Text = sifrelimetin;   

        }

        private void btnCöz_Click(object sender, EventArgs e)
        {
            sifrelimetin = txtSifreli.Text.ToLower();
            cözülenmetin = "";
            anahtarOlustur();
            Karakterler();
            int sayi = 0;

            while (sayi < sifrelimetin.Length)
            {
                for (int j = 0; j < anahtar_uzunluk; j++)
                {
                    bool sonuc = false;

                    for (int k = 0; k < 29; k++)
                    {
                        if (sifrelimetin[sayi + j] == alfabe[k])
                        {
                            sonuc = true;
                            int Number = k - anahtarRakamlari[j];

                            if (Number < 0)
                                Number += 29;

                            Number = Number % 29;
                            cözülenmetin += alfabe[Number];
                        }
                    }

                    if (!sonuc)
                        cözülenmetin += sifrelimetin[sayi + j];

                }
                sayi += anahtar_uzunluk;
            }

            txtCözülen.Text = cözülenmetin;
        }
    }
}
