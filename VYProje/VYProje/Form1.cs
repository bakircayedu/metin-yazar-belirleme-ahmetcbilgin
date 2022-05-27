using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VYProje
{
    //https://docs.microsoft.com/tr-tr/dotnet/api/system.text.regularexpressions.regex?view=net-6.0 internet sitesinden yararlanılmıştır.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnMetinGoster_Click(object sender, EventArgs e)
        {
            ofd.Title = "Metin Seç";
            ofd.Filter = "Text (*.txt) |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
            }
        }

        private void btnStackeOku_Click(object sender, EventArgs e)
        {
            StreamReader stream = new StreamReader(ofd.FileName);
            string input = stream.ReadToEnd();

            Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            string[] sentences = Regex.Split(input, @"(?<=[\.!\?])\s+");
            string[] words = Regex.Split(input, " ");

            StackIslemler stack = new StackIslemler();
            for (int i = 0; i < sentences.Length; i++)
            {
                stack.Push(sentences[i]);
            }

            //MessageBox.Show(stack.print());

            int cumleSayisi = sentences.Length;
            txtBilgi.Text = "Cümle sayısı =  " + cumleSayisi + Environment.NewLine;
            float allword=0;
            for (int i = 0; i < sentences.Length; i++)
            {
                
                string[] word = Regex.Split(sentences[i], " ");

                txtBilgi.Text+= (i+1) + ". Cümledeki kelime sayısı = " + word.Length + Environment.NewLine ;
                allword+=word.Length;
            }
            txtBilgi.Text +="Ortalama kelime sayısı = " + allword/sentences.Length;
            
        }

        private void btnAgacaAktar_Click(object sender, EventArgs e)
        {
            BinaryHeap<string> heap = new BinaryHeap<string>(SortDirection.Descending);

        }
    }
}
