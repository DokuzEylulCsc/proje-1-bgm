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
    //oyunucu kazanınca yartılır ve sure oyuncu ismi ister
    public partial class Kazandi : Form
    {
        private Kazandi()
        {
            InitializeComponent();
        }
        public Kazandi(LinkedList<Sozcuk> sozcukler, int sure)
        {
            InitializeComponent();
            //oyun suresi label de gosterilir
            label3.Text = "" + sure / 60;
            label3.Text += sure % 60;
            listBox1.Items.Clear();
            //tahmin edilecek kelimeler yazdirilir.
            for(int i = 0; i < sozcukler.Count; i++)
            {
                listBox1.Items.Add(sozcukler.ElementAt(i).getKelime());
            }

        }
        private void Kazandi_Load(object sender, EventArgs e)
        {

        }
        //oyuncu adi tur classina gönderir.
        public string SendIsim
        {
            get
            {
                return textBox1.Text;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
