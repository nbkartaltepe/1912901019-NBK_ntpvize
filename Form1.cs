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
using System.IO; // txt yazırdırmak için ıo kütüphanesi eklendi.

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
        }
    }
}
