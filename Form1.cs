using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mshtml;

namespace AirportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowser1.Document.CreateElement("script"); 
            IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = "var mymarker; function addPoints(){my marker = new L.marker([36.104743, -106.629925]); " +
                "mapp.addLayer(mymarker);mymarker.bindPopup('Point 1');}";
            head.AppendChild(scriptEl);
            webBrowser1.Document.InvokeScript("addPoints");
        }
    }
}
