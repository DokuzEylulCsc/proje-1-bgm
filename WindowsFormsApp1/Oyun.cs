using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Oyun : Form
    {
   
        
        public Oyun()
        {
            InitializeComponent();
            Button[] zorluklar;
            //zorluklar klasorden alinir.
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath);
            FileInfo[] Files = d.GetFiles("*.txt");
            string str = "";
            zorluklar = new Button[Files.Length];
            //zorluk butonlari ekrana yerlestirilir.
            for (int i = 0; i < Files.Length; i++)
            {
                zorluklar[i] = new Button();
                zorluklar[i].Size = new Size(100, 40);
                zorluklar[i].Text = Files[i].Name;
                zorluklar[i].Click += zorlukSecimi;
            }
            foreach (Button btn in zorluklar)
            {

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void zorlukSecimi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //dosyadaa kelimeler alinir.
            LinkedList<String> sozcukler = new LinkedList<String>(File.ReadAllLines(btn.Text, UTF8Encoding.Default).ToList());
            foreach(String str in sozcukler)
            {
                Console.WriteLine(str);
            }
            Random rand = new Random();
            LinkedList<Sozcuk> oyununSozcukleri = new LinkedList<Sozcuk>();
            //rastgele kelimeler secilir.
            for(int i = 0; i < 10; i++)
            {
                String sozcuk = sozcukler.ElementAt(rand.Next(sozcukler.Count));
                sozcukler.Remove(sozcuk);
                oyununSozcukleri.AddLast(new Sozcuk(sozcuk));
            }
            //oyun turu baslatilir.
            new Tur(btn.Text, oyununSozcukleri).ShowDialog();

        }

        private void Oyun_Load(object sender, EventArgs e)
        {
 
        }

       
    }
}
