using System;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lblHeader = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNy1 = new System.Windows.Forms.Button();
            this.btnSpara1 = new System.Windows.Forms.Button();
            this.btnTaBort1 = new System.Windows.Forms.Button();
            this.cboUppdateringsfrekverns = new System.Windows.Forms.ComboBox();
            this.cboKategori = new System.Windows.Forms.ComboBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUppdateringsfrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnNy2 = new System.Windows.Forms.Button();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.btnShowPodcasts = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvPodcastShow = new System.Windows.Forms.ListView();
            this.PodcastShow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Updatesetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.episodesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(18, 14);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(133, 29);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "AmeriCast";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(583, 230);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 44);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNy1
            // 
            this.btnNy1.Location = new System.Drawing.Point(14, 278);
            this.btnNy1.Name = "btnNy1";
            this.btnNy1.Size = new System.Drawing.Size(189, 35);
            this.btnNy1.TabIndex = 2;
            this.btnNy1.Text = "Add PodcastShow";
            this.btnNy1.UseVisualStyleBackColor = true;
            this.btnNy1.Click += new System.EventHandler(this.btnNy1_Click);
            // 
            // btnSpara1
            // 
            this.btnSpara1.Location = new System.Drawing.Point(256, 285);
            this.btnSpara1.Name = "btnSpara1";
            this.btnSpara1.Size = new System.Drawing.Size(122, 42);
            this.btnSpara1.TabIndex = 3;
            this.btnSpara1.Text = "Spara";
            this.btnSpara1.UseVisualStyleBackColor = true;
            this.btnSpara1.Click += new System.EventHandler(this.btnSpara1_Click);
            // 
            // btnTaBort1
            // 
            this.btnTaBort1.Location = new System.Drawing.Point(404, 291);
            this.btnTaBort1.Name = "btnTaBort1";
            this.btnTaBort1.Size = new System.Drawing.Size(122, 35);
            this.btnTaBort1.TabIndex = 4;
            this.btnTaBort1.Text = "Ta bort";
            this.btnTaBort1.UseVisualStyleBackColor = true;
            this.btnTaBort1.Click += new System.EventHandler(this.btnTaBort1_Click);
            // 
            // cboUppdateringsfrekverns
            // 
            this.cboUppdateringsfrekverns.FormattingEnabled = true;
            this.cboUppdateringsfrekverns.Items.AddRange(new object[] {
            "5",
            "30",
            "60"});
            this.cboUppdateringsfrekverns.Location = new System.Drawing.Point(256, 245);
            this.cboUppdateringsfrekverns.Name = "cboUppdateringsfrekverns";
            this.cboUppdateringsfrekverns.Size = new System.Drawing.Size(121, 28);
            this.cboUppdateringsfrekverns.TabIndex = 6;
            this.cboUppdateringsfrekverns.Text = "(Minuter)";
            // 
            // cboKategori
            // 
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(402, 246);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(121, 28);
            this.cboKategori.TabIndex = 7;
            this.cboKategori.SelectedIndexChanged += new System.EventHandler(this.cboKategori_SelectedIndexChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(14, 246);
            this.txtURL.Name = "txtURL";
            this.txtURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtURL.Size = new System.Drawing.Size(234, 26);
            this.txtURL.TabIndex = 8;
            this.txtURL.Text = "http://tuttobalutto.libsyn.com/rss";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = ":URL";
            // 
            // lblUppdateringsfrekvens
            // 
            this.lblUppdateringsfrekvens.AutoSize = true;
            this.lblUppdateringsfrekvens.Location = new System.Drawing.Point(255, 223);
            this.lblUppdateringsfrekvens.Name = "lblUppdateringsfrekvens";
            this.lblUppdateringsfrekvens.Size = new System.Drawing.Size(169, 20);
            this.lblUppdateringsfrekvens.TabIndex = 10;
            this.lblUppdateringsfrekvens.Text = ":Uppdateringsfrekvens";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(432, 223);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = ":Kategori";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(684, 230);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(86, 44);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(583, 282);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(94, 64);
            this.listBox3.TabIndex = 13;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(798, 218);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(408, 26);
            this.txtKategori.TabIndex = 14;
            this.txtKategori.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // btnNy2
            // 
            this.btnNy2.Location = new System.Drawing.Point(798, 252);
            this.btnNy2.Name = "btnNy2";
            this.btnNy2.Size = new System.Drawing.Size(124, 38);
            this.btnNy2.TabIndex = 15;
            this.btnNy2.Text = "Spara kategori";
            this.btnNy2.UseVisualStyleBackColor = true;
            this.btnNy2.Click += new System.EventHandler(this.btnNy2_Click);
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(191, 327);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(75, 38);
            this.btnSpara2.TabIndex = 16;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            this.btnSpara2.Click += new System.EventHandler(this.btnSpara2_Click);
            // 
            // btnShowPodcasts
            // 
            this.btnShowPodcasts.Location = new System.Drawing.Point(182, 12);
            this.btnShowPodcasts.Name = "btnShowPodcasts";
            this.btnShowPodcasts.Size = new System.Drawing.Size(195, 38);
            this.btnShowPodcasts.TabIndex = 17;
            this.btnShowPodcasts.Text = "Show pocast feeds";
            this.btnShowPodcasts.UseVisualStyleBackColor = true;
            this.btnShowPodcasts.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 20;
            this.listBox4.Location = new System.Drawing.Point(684, 283);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(86, 64);
            this.listBox4.TabIndex = 18;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 35);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delejt\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(958, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "Skapa kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvPodcastShow
            // 
            this.lvPodcastShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PodcastShow,
            this.Episodes,
            this.Updatesetting,
            this.Category});
            this.lvPodcastShow.HideSelection = false;
            this.lvPodcastShow.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvPodcastShow.Location = new System.Drawing.Point(14, 57);
            this.lvPodcastShow.Name = "lvPodcastShow";
            this.lvPodcastShow.Size = new System.Drawing.Size(542, 163);
            this.lvPodcastShow.TabIndex = 21;
            this.lvPodcastShow.UseCompatibleStateImageBehavior = false;
            this.lvPodcastShow.View = System.Windows.Forms.View.Details;
            this.lvPodcastShow.SelectedIndexChanged += new System.EventHandler(this.lvPodcastShow_SelectedIndexChanged);
            // 
            // PodcastShow
            // 
            this.PodcastShow.Text = "PodcastShow";
            this.PodcastShow.Width = 150;
            // 
            // Episodes
            // 
            this.Episodes.Text = "Episodes";
            this.Episodes.Width = 90;
            // 
            // Updatesetting
            // 
            this.Updatesetting.Text = "Update setting";
            this.Updatesetting.Width = 120;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 110;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.episodesColumn});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 466);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 224);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // episodesColumn
            // 
            this.episodesColumn.Text = "Episodes";
            this.episodesColumn.Width = 500;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryColumn});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(798, 57);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(408, 155);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 200;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(798, 466);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(408, 224);
            this.txtDescription.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(798, 432);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(148, 20);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Episode description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1299, 693);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvPodcastShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnShowPodcasts);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnNy2);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblUppdateringsfrekvens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.cboKategori);
            this.Controls.Add(this.cboUppdateringsfrekverns);
            this.Controls.Add(this.btnTaBort1);
            this.Controls.Add(this.btnSpara1);
            this.Controls.Add(this.btnNy1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PodcastApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNy1;
        private System.Windows.Forms.Button btnSpara1;
        private System.Windows.Forms.Button btnTaBort1;
        private System.Windows.Forms.ComboBox cboUppdateringsfrekverns;
        private System.Windows.Forms.ComboBox cboKategori;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUppdateringsfrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Button btnNy2;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.Button btnShowPodcasts;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView lvPodcastShow;
        private System.Windows.Forms.ColumnHeader Updatesetting;
        private System.Windows.Forms.ColumnHeader PodcastShow;
        private System.Windows.Forms.ColumnHeader Episodes;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader episodesColumn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}

