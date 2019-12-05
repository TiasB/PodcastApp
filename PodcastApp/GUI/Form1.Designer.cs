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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnModifyCategory = new System.Windows.Forms.Button();
            this.btnSpara2 = new System.Windows.Forms.Button();
            this.btnShowPodcasts = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateCategory = new System.Windows.Forms.Button();
            this.lvPodcastShow = new System.Windows.Forms.ListView();
            this.PodcastShow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Episodes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Updatesetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEpisodes = new System.Windows.Forms.ListView();
            this.episodesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCategory = new System.Windows.Forms.ListView();
            this.categoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(92, 20);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "AmeriCast";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(389, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(64, 30);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnNy1
            // 
            this.btnNy1.Location = new System.Drawing.Point(9, 181);
            this.btnNy1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNy1.Name = "btnNy1";
            this.btnNy1.Size = new System.Drawing.Size(126, 23);
            this.btnNy1.TabIndex = 2;
            this.btnNy1.Text = "Add PodcastShow";
            this.btnNy1.UseVisualStyleBackColor = true;
            this.btnNy1.Click += new System.EventHandler(this.btnNy1_Click);
            // 
            // btnSpara1
            // 
            this.btnSpara1.Location = new System.Drawing.Point(171, 185);
            this.btnSpara1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara1.Name = "btnSpara1";
            this.btnSpara1.Size = new System.Drawing.Size(81, 27);
            this.btnSpara1.TabIndex = 3;
            this.btnSpara1.Text = "Spara";
            this.btnSpara1.UseVisualStyleBackColor = true;
            this.btnSpara1.Click += new System.EventHandler(this.btnSpara1_Click);
            // 
            // btnTaBort1
            // 
            this.btnTaBort1.Location = new System.Drawing.Point(269, 189);
            this.btnTaBort1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort1.Name = "btnTaBort1";
            this.btnTaBort1.Size = new System.Drawing.Size(81, 23);
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
            this.cboUppdateringsfrekverns.Location = new System.Drawing.Point(171, 159);
            this.cboUppdateringsfrekverns.Margin = new System.Windows.Forms.Padding(2);
            this.cboUppdateringsfrekverns.Name = "cboUppdateringsfrekverns";
            this.cboUppdateringsfrekverns.Size = new System.Drawing.Size(82, 21);
            this.cboUppdateringsfrekverns.TabIndex = 6;
            this.cboUppdateringsfrekverns.Text = "(Minuter)";
            // 
            // cboKategori
            // 
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(268, 160);
            this.cboKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(82, 21);
            this.cboKategori.TabIndex = 7;
            this.cboKategori.SelectedIndexChanged += new System.EventHandler(this.cboKategori_SelectedIndexChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(9, 160);
            this.txtURL.Margin = new System.Windows.Forms.Padding(2);
            this.txtURL.Name = "txtURL";
            this.txtURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtURL.Size = new System.Drawing.Size(157, 20);
            this.txtURL.TabIndex = 8;
            this.txtURL.Text = "http://tuttobalutto.libsyn.com/rss";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = ":URL";
            // 
            // lblUppdateringsfrekvens
            // 
            this.lblUppdateringsfrekvens.AutoSize = true;
            this.lblUppdateringsfrekvens.Location = new System.Drawing.Point(170, 145);
            this.lblUppdateringsfrekvens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUppdateringsfrekvens.Name = "lblUppdateringsfrekvens";
            this.lblUppdateringsfrekvens.Size = new System.Drawing.Size(114, 13);
            this.lblUppdateringsfrekvens.TabIndex = 10;
            this.lblUppdateringsfrekvens.Text = ":Uppdateringsfrekvens";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(288, 145);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = ":Kategori";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(456, 149);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(59, 30);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 303);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox3.Size = new System.Drawing.Size(263, 147);
            this.listBox3.TabIndex = 13;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(532, 141);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(273, 20);
            this.txtCategory.TabIndex = 14;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.Location = new System.Drawing.Point(749, 162);
            this.btnModifyCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(80, 25);
            this.btnModifyCategory.TabIndex = 15;
            this.btnModifyCategory.Text = "Modify";
            this.btnModifyCategory.UseVisualStyleBackColor = true;
            this.btnModifyCategory.Click += new System.EventHandler(this.btnNy2_Click);
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(127, 213);
            this.btnSpara2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(50, 25);
            this.btnSpara2.TabIndex = 16;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            this.btnSpara2.Click += new System.EventHandler(this.btnSpara2_Click);
            // 
            // btnShowPodcasts
            // 
            this.btnShowPodcasts.Location = new System.Drawing.Point(121, 8);
            this.btnShowPodcasts.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowPodcasts.Name = "btnShowPodcasts";
            this.btnShowPodcasts.Size = new System.Drawing.Size(130, 25);
            this.btnShowPodcasts.TabIndex = 17;
            this.btnShowPodcasts.Text = "Show pocast feeds";
            this.btnShowPodcasts.UseVisualStyleBackColor = true;
            this.btnShowPodcasts.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.Location = new System.Drawing.Point(533, 303);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2);
            this.listBox4.Name = "listBox4";
            this.listBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox4.Size = new System.Drawing.Size(296, 147);
            this.listBox4.TabIndex = 18;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Delejt\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateCategory
            // 
            this.btnCreateCategory.Location = new System.Drawing.Point(532, 162);
            this.btnCreateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCategory.Name = "btnCreateCategory";
            this.btnCreateCategory.Size = new System.Drawing.Size(60, 24);
            this.btnCreateCategory.TabIndex = 20;
            this.btnCreateCategory.Text = "Create";
            this.btnCreateCategory.UseVisualStyleBackColor = true;
            this.btnCreateCategory.Click += new System.EventHandler(this.button2_Click);
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
            this.lvPodcastShow.Location = new System.Drawing.Point(9, 37);
            this.lvPodcastShow.Margin = new System.Windows.Forms.Padding(2);
            this.lvPodcastShow.Name = "lvPodcastShow";
            this.lvPodcastShow.Size = new System.Drawing.Size(363, 107);
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
            // lvEpisodes
            // 
            this.lvEpisodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.episodesColumn});
            this.lvEpisodes.HideSelection = false;
            this.lvEpisodes.Location = new System.Drawing.Point(389, 181);
            this.lvEpisodes.Margin = new System.Windows.Forms.Padding(2);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvEpisodes.Size = new System.Drawing.Size(57, 52);
            this.lvEpisodes.TabIndex = 22;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            this.lvEpisodes.View = System.Windows.Forms.View.Details;
            this.lvEpisodes.SelectedIndexChanged += new System.EventHandler(this.lvEpisodes_SelectedIndexChanged);
            // 
            // episodesColumn
            // 
            this.episodesColumn.Text = "Episodes";
            this.episodesColumn.Width = 500;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categoryColumn});
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(532, 8);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(2);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(273, 102);
            this.lvCategory.TabIndex = 23;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            this.lvCategory.SelectedIndexChanged += new System.EventHandler(this.lvCategory_SelectedIndexChanged);
            // 
            // categoryColumn
            // 
            this.categoryColumn.Text = "Category";
            this.categoryColumn.Width = 200;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(532, 281);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 13);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Episode description";
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(633, 163);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(74, 23);
            this.btnRemoveCategory.TabIndex = 26;
            this.btnRemoveCategory.Text = "Remove";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lvEpisodes);
            this.Controls.Add(this.lvPodcastShow);
            this.Controls.Add(this.btnCreateCategory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnShowPodcasts);
            this.Controls.Add(this.btnSpara2);
            this.Controls.Add(this.btnModifyCategory);
            this.Controls.Add(this.txtCategory);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnModifyCategory;
        private System.Windows.Forms.Button btnSpara2;
        private System.Windows.Forms.Button btnShowPodcasts;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateCategory;
        private System.Windows.Forms.ListView lvPodcastShow;
        private System.Windows.Forms.ColumnHeader Updatesetting;
        private System.Windows.Forms.ColumnHeader PodcastShow;
        private System.Windows.Forms.ColumnHeader Episodes;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ListView lvEpisodes;
        private System.Windows.Forms.ColumnHeader episodesColumn;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader categoryColumn;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRemoveCategory;
    }
}

