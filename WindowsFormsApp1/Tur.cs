using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tur : Form
    {
        private TextBox [] Harfler;
        private LinkedList<Sozcuk> sozcukler;
        private int soru = 0;
        private int sure = 0;
        private LinkedList<LinkedList<string>> tahminler = new LinkedList<LinkedList<string>>();
        private int[] sureler; // soruda harcanan sureyi tutar.
        private bool[] bilindiMi; // sorularin bilindigini tutar.
        private int[] denemeSayisi;//deneme sayisini tutar.
        int kalanSoru;

        public Tur(String zorluk, LinkedList<Sozcuk> sozcukler)
        {
            InitializeComponent();

            zorlukLabel.Text = zorluk;
            this.sozcukler = sozcukler;
            //sureyi baslatir.
            timer1.Start();
            //tahminlerin tutulacagi bagli listeyi yaratir.
            for(int i = 0; i < sozcukler.Count; i++)
            {
                tahminler.AddLast(new LinkedList<string>());
            }
            //loglar icin gerekli verileri tutar.
            bilindiMi = new bool[sozcukler.Count];
            denemeSayisi = new int[sozcukler.Count];
            sureler = new int[sozcukler.Count];
            kalanSoru = sozcukler.Count;
            panelGuncelle();
        }

        public Tur()
        {
            InitializeComponent();
        }

        private void panelGuncelle()
        {
            soruLabel.Text = soru + 1 + "";
            cozulmeyenLabel.Text = "" + kalanSoru;
            int harfSayisi = sozcukler.ElementAt(soru).getKelimeUzunlugu();
            Harfler = new TextBox[harfSayisi];
            //tahmin icin gerekli textboxlar yaratilir.
            harfPanel.Controls.Clear();
            Size genel = new Size(35, 35);
            Font font = new Font("Times New Roman", 20f);
            
            for(int i = 0; i < harfSayisi; i++)
            {
                Harfler[i] = new TextBox();
                Harfler[i].Size = genel;
                Harfler[i].Font = font;
                Harfler[i].MaxLength = 1;
                Harfler[i].TextAlign = HorizontalAlignment.Center;
                //metin degistiginde cagirilir.
                Harfler[i].TextChanged += tahminKontrolu;
                
                harfPanel.Controls.Add(Harfler[i]);
            }
            //son tahmin var ise textboxlar doldurulur.
            if (tahminler.ElementAt(soru).Count > 1)
            {
                for(int i = 0; i < harfSayisi; i++)
                {
                    Harfler[i].Text = tahminler.ElementAt(soru).Last()[i] + "";
                }
            }

        }


        private void tahminKontrolu(object sender, EventArgs e)
        {
            int j;
            String tahmin = "";
            //tahmin edilen string birlestirilir.
            for (j = 0; j < Harfler.Length; j++)
            {
                if (Harfler[j].Text == "") return;
                tahmin += Harfler[j].Text;
            }
            //tum harfler kucuk harf yapilir.
            tahmin.ToLower();
            denemeSayisi[soru]++;
            if (!bilindiMi[soru])
            {
                tahminler.ElementAt(soru).AddLast(tahmin);
            }
            yerAlanLabel.Text = "";
            eslesenLabel.Text = "";

            int sonuc = sozcukler.ElementAt(soru).karsilastir(tahmin);
            int sonuc2 = sonuc;
            //konsolda kelime gosterilir.
            sozcukler.ElementAt(soru).goster();
            //dogru yerdeki harfler yesil yapilir.
            for(int i = 0; i < Harfler.Length; i++)
            {
                if (sozcukler.ElementAt(soru).varMi(tahmin[i].ToString()))
                {
                    yerAlanLabel.Text += "\"" + tahmin[i] + "\""; 
                }
                if (sonuc % 2 == 1)
                {
                    Harfler[i].BackColor = Color.Green;
                    eslesenLabel.Text += "\"" + tahmin[i] + "\"";
                }
                else Harfler[i].BackColor = Color.Red;
                sonuc /= 2;
            }
            //tahmin dogru ise sornaki soruya gecer.
            if(sonuc2 == Math.Pow(2,sozcukler.ElementAt(soru).getKelime().Length) -1)
            {
                bilindiMi[soru] = true;
                kalanSoru--;
                if (soru < sozcukler.Count - 1)
                {
                    soru++;
                    panelGuncelle();
                }
            }
            //tum kelimeler bilidi ise oyun biter.
            for(int i = 0; i < sozcukler.Count; i++)
            {
                if (!bilindiMi[i]) return;
            }
            timer1.Stop();
            //kazanilan oyun icin form gosterilir.
            Kazandi k = new Kazandi(sozcukler, sure);
            k.ShowDialog();
            string isim = k.SendIsim;
            //log yazdirilir.
            LogYazdir.yazdir(sozcukler, bilindiMi, tahminler, sureler, denemeSayisi, isim);
            this.Close();

        }

        private void Tur_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sureler[soru]++;
            if(sure < 240)
            {
                sure++;
                sureLabel.Text = sure / 60 + " : " + sure % 60;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Sure bitti, kaybettiniz:((");
                LogYazdir.yazdir(sozcukler, bilindiMi, tahminler, sureler, denemeSayisi, "yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sonraki soru
            if (soru < sozcukler.Count -1)
            {
                soru++;
                panelGuncelle();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //onceki soru
            if(soru > 0)
            {
                soru--;
                panelGuncelle();
            }
        }
    }
}
