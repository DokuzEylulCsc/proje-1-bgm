using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Sozcuk
    {
        private String kelime; //gelen kelimeni tutulmasi icin

        public Sozcuk(String kelime) //constructor olusturumak icin
        {
            this.kelime = kelime; //parametre olarak alınan kelimeyi class da ki kelimeye esitleme
        }

        public int getKelimeUzunlugu()  //girilen kelimenin uzunluguna ulasmak icin
        {
            return kelime.Length;   //hazir lenght fonsiyonu
        }
        public void goster()    //girilen kelimeyi gostermeye yarar
        {
            Console.WriteLine(kelime);  //console basıyor girilen kelimeyi
        }

        public string getKelime()   //girilen kelimeye erisme fonksiyonu
        {
            return kelime;  //kelimeyi geri donduruyor
        }

        public Boolean varMi(String str)    //girilen kelime ile eldeki kelimeleri karsilastirmak icin
        {
            return kelime.Contains(str);    //contains hazir fonksiyonu ile icindeki harfleri var mı bakiyor
        }
        public int karsilastir(String kelime)   //karsilastirma fonksiyonu
        {
            int ret = 0;
            for (int i = 0; i < kelime.Length; i++) //kelime uzunlugu kadar donuyor
            {           
                if (this.kelime[i].Equals(kelime[i]))   //kelimenin int cast edilmis haline göre var mı yok mu bakıyor 
                {
                    ret += (int)Math.Pow(2, i); //harf dogruysa 1 degilse 0 olur
                }
            }
            return ret;
        }
        

    }
}
