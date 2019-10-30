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

namespace GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Antal avsnitt", typeof(int));
            dt.Columns.Add("Namn", typeof(string));
            dt.Columns.Add("Frekens", typeof(DateTime));
            dt.Columns.Add("Kategori", typeof(string));

            dt.Rows.Add(new object[] { 13, "alex o sigge", DateTime.Parse("1/1/2016"), "Komedi" });
           // dt.Rows.Add(new object[] { "Book B", DateTime.Parse("1/2/2016"), "Author B" });
            //dt.Rows.Add(new object[] { "Book C", DateTime.Parse("1/3/2016"), "Author C" });

            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNy1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
