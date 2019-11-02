using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

using Logic;
using SharedModels;
using Timer = System.Windows.Forms.Timer;

namespace GUI
{
    public partial class Form1 : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNy1_Click(object sender, EventArgs e)
        {
            var list = RSSreader.GetPodcastFeed(txtURL.Text);
            foreach (PodcastShow item in list)
            {
                listBox3.Items.Add(item.Title);
            }
            listBox3.Items.Add(RSSreader.GetPodcastFeed(txtURL.Text));
            



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

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                var list = RSSreader.GetPodcastFeed(txtURL.Text);
                foreach (PodcastShow item in list)
                {
                    if (item.Title == listBox3.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(item.Description);
                    }


                }
            }

        }

        private void btnSpara1_Click(object sender, EventArgs e)
        {
            
            string x = cboUppdateringsfrekverns.Text;
            int result = Int32.Parse(x);

          Timer t = new Timer();


            t.Interval = result * (60000); // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            {
                var list = RSSreader.GetPodcastFeed(txtURL.Text);
                listBox3.Items.Clear();
                foreach (PodcastShow item in list)
                {
                    listBox3.Items.Add(item.Title);
                }
               
                //Call method
            }

        }

        private void btnSpara2_Click(object sender, EventArgs e)
           {
           
            var list = RSSreader.GetPodcastFeed(txtURL.Text);
            PodcastShow.ReadPodcastsFromFile(Path.Combine(Environment.CurrentDirectory));



        }
    }
}
