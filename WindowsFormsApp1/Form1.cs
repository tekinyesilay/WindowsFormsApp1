using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("C:\\Users\\ceng10\\Downloads\\urunler.txt");
            string okunan=read.ReadLine();
            string urunkodu=read.ReadLine();
            while (!read.EndOfStream)
            {
                okunan=read.ReadLine();
                string[] satır = okunan.Split('-');
                if (satır[1] == textBox1.Text)
                {
                    urunkodu=satır[0];
                }
            }
            StreamReader readsatıs= new StreamReader("C:\\Users\\ceng10\\Downloads\\adet.txt");
            string okunansatıs = read.ReadLine();
            string[] liste = new string[1];
            int i = 0;
            while (!readsatıs.EndOfStream)
            {
                okunansatıs = readsatıs.ReadLine();
                string[] satır = okunansatıs.Split('-');
                if (satır[1] == urunkodu)
                {
                    liste[i] = satır[2] + " " + satır[4];
                    i++;
                    Array.Resize(ref liste, liste.Length+1);

                }
                for(int j = 0; j < liste.Length-1; j++)
                {
                    listBox1.Items.Add(liste[j]);
                }
            }

            StreamReader readhastane = new StreamReader("C:\\Users\\ceng10\\Downloads\\hastane.txt");
            string okunanhastane = read.ReadLine();
            while (!readhastane.EndOfStream)
            {
                okunanhastane = readsatıs.ReadLine();
                string[] satır = okunanhastane.Split('-');
                if (satır[1] == urunkodu)
                {
                    liste[i] = satır[2] + " " + satır[4];
                    i++;
                    Array.Resize(ref liste, liste.Length + 1);
                }
                for (int k = 0; k < liste.Length - 1; k++)
                {
                    listBox1.Items.Add(liste[k]);
                }

            }
        }
}
