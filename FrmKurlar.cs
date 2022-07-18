using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Sayac_Proje
{
    public partial class FrmKurlar : Form
    {
        public FrmKurlar()
        {
            InitializeComponent();
        }

        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();
            xml.Load(bugun);
            webBrowser1.Navigate("https://bigpara.hurriyet.com.tr/altin/");
            webBrowser1.ScriptErrorsSuppressed = true;

            string dolaralis = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string dolarsatis = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string euralis = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string eursatis = xml.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            LblDolarAlis.Text = dolaralis;
            LblDolarSatis.Text = dolarsatis;
            LblEuroAlis.Text = euralis;
            LblEuroSatis.Text = eursatis;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HtmlElementCollection htmlElementCollection = webBrowser1.Document.All;
            foreach (HtmlElement altin in htmlElementCollection)
            {
                if (altin.GetAttribute("className")== "box bFirst")
                {
                    LblAltinAlis.Text = altin.InnerText;
                }
                if (altin.GetAttribute("className") == "box")
                {
                    LblAltinSatis.Text = altin.InnerText;
                }
                if (altin.GetAttribute("className") == "tHead")
                {
                    listBox1.Items.Add(altin.InnerText);

                }
                if (altin.GetAttribute("className") == "tBody")
                {
                    listBox1.Items.Add(altin.InnerText);
                    
                }
            }
            
        }
    }
}
