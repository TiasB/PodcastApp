using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Logic;
using SharedModels;

namespace GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNy1_Click(object sender, EventArgs e)
        {
            var list = RSSreader.GetPodcastFeed(txtURL.Text, cboKategori.Text);
            foreach (PodcastShow item in list)
            {
                listBox3.Items.Add(item.Title);
            }
            listBox3.Items.Add(RSSreader.GetPodcastFeed(txtURL.Text, cboKategori.Text));
        }
        private void listBox3_MouseClick(object sender, MouseEventArgs e)
        {
            var list = RSSreader.GetPodcastFeed(txtURL.Text, cboKategori.Text);
            foreach (PodcastShow item in list)
            {
                if (item == listBox3.SelectedItem)
                {
                    listBox3.Items.Add(item);
                }
            }
        }

        private void cboUppdateringsfrekverns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //private void listBox1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    var list = RSSreader.rssRead(tbxURL.Text);
        //    foreach (Tuple<string, string> item in list)
        //    {
        //        if (item == listBox2.SelectedItem) // Notice the equality operator
        //        {
        //            richTextBox1.Text = item.Item2.ToString();
        //        }
        //    }
        //}
    }
}
