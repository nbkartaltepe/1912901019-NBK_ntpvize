using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers; //timer kütüphanesi eklendi.
using System.Xml; // xml kütüphanesi eklendi.
using System.IO; // txt yazırdırmak için IO kütüphanesi eklendi.

namespace _1912901019_NBK_ntpvize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlokuma = new XmlTextReader("https://tr.sputniknews.com/export/rss2/archive/index.xml"); // xmltextreader ile web site üzerinden xml verisini xmlokuma ya çekildi.
            string veri = ""; // veri adında değişken oluşturdum.
            listBox1.Items.Clear(); // listbox a tekrar tekrar xmlokuma dakiler yazılmaması için clear eklendi.
            while (xmlokuma.Read()) // xmlokuma yı while döngüsüne aldım.
            {
                if (xmlokuma.Name == "title" || xmlokuma.Name == "description" || xmlokuma.Name == "pubDate") // if döngüsünde xmlokuma içerisinde title, description, pubdate başlıkları seçildi.
                {
                    listBox1.Items.Add(xmlokuma.ReadString()); // xmlokuma ya çekilen verileri listbox a aktarıldı.
                    veri += listBox1.Items[listBox1.Items.Count - 1].ToString() + Environment.NewLine; // veri değişkeni içerisine listbox a gelen verileri yazdırıldı.
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\MONSTER\source\repos\1912901019-NBK_ntpvize\haberler.txt", veri); // system IO ile veri değişkeni içerisindekileri belirtilen dosya yolundaki txt formatındaki dosya içerisine yazdırıldı.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(); // timer ile güncel tarih ve saati label a yazdırıldı.
        }
    }
}
