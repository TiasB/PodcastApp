using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml;
using Data;
using DocumentFormat.OpenXml.Bibliography;
using Logic;
using Newtonsoft.Json;
using SharedModels;
using Timer = System.Windows.Forms.Timer;

namespace GUI
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        Timer timer3 = new Timer();

        public SerializedReaderWriter SerDeser { get; set; }
        public Logik logik { get; set; }

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            SerDeser = new SerializedReaderWriter();
            logik = new Logik();


            WebClient client = new WebClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNy1_Click(object sender, EventArgs e)
        {
            string namn = txtURL.Text;
            var list = SerializedReaderWriter.GetPodcastFeed(namn);
            foreach (PodcastShow item in list)
            {
                listBox3.Items.Add(item.Title);


            }
            listBox3.Items.Add(SerializedReaderWriter.GetPodcastFeed(namn));
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                var list = SerializedReaderWriter.GetPodcastFeed(txtURL.Text);
                foreach (PodcastShow item in list)
                {
                    if (item.Title == listBox3.SelectedItem.ToString())
                    {
                        listBox4.Items.Add(item.Description);
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
                var list = SerializedReaderWriter.GetPodcastFeed(txtURL.Text);
                listBox3.Items.Clear();
                foreach (PodcastShow item in list)
                {
                    listBox3.Items.Add(item.Title);
                }


            }

        }

        private async void btnSpara2_Click(object sender, EventArgs e)
        {
            
            try
            {
                await
                  SerDeser.sparaPodd(txtURL.Text);
                MessageBox.Show(" Du har sparat " + txtURL.Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            

        }

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (string Podcast in Directory.GetFiles(Directory.GetCurrentDirectory()))
            //{
            //    if (Podcast.Contains(listBox1.SelectedItem.ToString()))
            //    {
            //        string podSpara = Path.GetFileName(Podcast);
            //        listBox2.Items.Add(podSpara);
            //    }
            //}
        }

        private void btnNy2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = SerDeser.läsPod(txtURL.Text);
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerDeser.läsPod(txtURL.Text);
        }

        private void btnTaBort2_Click(object sender, EventArgs e)
        {
           
            foreach (string Podcast in Directory.GetFiles(Directory.GetCurrentDirectory()))
                if (Podcast.Contains(".xml"))
                {
                    string podSpara = Path.GetFileName(Podcast);
                    listBox1.Items.Add(podSpara);
                }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         {
                //string namn = listBox1.SelectedItem.ToString();


                //  foreach (string Podcast in Directory.GetFiles(Directory.GetCurrentDirectory()))
                //    if (Podcast.Contains(".xml"))
                //    {
                //        string podSpara = Path.GetFileName(Podcast);
                //        listBox2.Items.Add(podSpara);
                //    }


            }
        }

            private void button2_Click(object sender, EventArgs e)
            {
            var category = txtKategori.Text;
            logik.nyKategori(category);
            logik.saveCategoryList();
            listBox2.Items.Add(category);
            cboKategori.Items.Add(txtKategori.Text);

            }

        private void btnTaBort1_Click(object sender, EventArgs e)
        {

        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvPodcastShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                //string namn = listBox1.SelectedItem.ToString();


                //  foreach (string Podcast in Directory.GetFiles(Directory.GetCurrentDirectory()))
                //    if (Podcast.Contains(".xml"))
                //    {
                //        string podSpara = Path.GetFileName(Podcast);
                //        listBox2.Items.Add(podSpara);
                //    }


            }
        }
    }
    }

