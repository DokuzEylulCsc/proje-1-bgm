using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Sozcuk
    {
        private String kelime;

        public Sozcuk(String kelime)
        {
            this.kelime = kelime;
        }

        public int getKelimeUzunlugu()
        {
            return kelime.Length;
        }
        public void goster()
        {
            Console.WriteLine(kelime);
        }

        public string getKelime()
        {
            return kelime;
        }

        public Boolean varMi(String str)
        {
            return kelime.Contains(str);
        }
        public int karsilastir(String kelime)
        {
            int ret = 0;
            for (int i = 0; i < kelime.Length; i++)
            {           
                if (this.kelime[i].Equals(kelime[i]))
                {
                    ret += (int)Math.Pow(2, i);
                }
            }
            return ret;
        }
        

    }
}
