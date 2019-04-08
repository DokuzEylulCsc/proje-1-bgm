using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class LogYazdir
    {
        public static void yazdir(LinkedList<Sozcuk> sozcukler,bool[]bildiMi, LinkedList<LinkedList<string>> tahminler, int[] sureler,int[] denemeSayisi, string oyuncuAdi)
        {
            
            StreamWriter writer = new StreamWriter("log.csv", append:true);
            writer.WriteLine("oyuncu Adi,tahmin edilecek kelime,bilinme durumu,deneme sayısı,harcanan sure, denenen kelimeler");

            for(int i = 0; i < sozcukler.Count; i++)
            {
                writer.Write(oyuncuAdi + "," + sozcukler.ElementAt(i).getKelime() + "," + bildiMi[i] +","+ denemeSayisi[i] + "," + sureler[i] + ",");
                foreach(string str in tahminler.ElementAt(i))
                {
                    writer.Write("-" + str);
                }
                writer.WriteLine("");
            }
            writer.Close();
        }
        
    }
}
