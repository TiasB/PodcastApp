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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnTaBort2 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podcasts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 108);
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
            this.listBox2.Location = new System.Drawing.Point(532, 17);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(286, 121);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(12, 237);
            this.listBox3.Margin = new System.Windows.Forms.Padding(2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(360, 134);
            this.listBox3.TabIndex = 13;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(532, 142);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(286, 20);
            this.txtKategori.TabIndex = 14;
            this.txtKategori.TextChanged += new System.EventHandler(this.txtKategori_TextChanged);
            // 
            // btnNy2
            // 
            this.btnNy2.Location = new System.Drawing.Point(556, 164);
            this.btnNy2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNy2.Name = "btnNy2";
            this.btnNy2.Size = new System.Drawing.Size(83, 25);
            this.btnNy2.TabIndex = 15;
            this.btnNy2.Text = "Spara kategori";
            this.btnNy2.UseVisualStyleBackColor = true;
            this.btnNy2.Click += new System.EventHandler(this.btnNy2_Click);
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(155, 212);
            this.btnSpara2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(50, 25);
            this.btnSpara2.TabIndex = 16;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            this.btnSpara2.Click += new System.EventHandler(this.btnSpara2_Click);
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(355, 30);
            this.btnTaBort2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(130, 25);
            this.btnTaBort2.TabIndex = 17;
            this.btnTaBort2.Text = "Show pocast feeds";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            this.btnTaBort2.Click += new System.EventHandler(this.btnTaBort2_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(532, 237);
            this.listBox4.Margin = new System.Windows.Forms.Padding(2);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(273, 147);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Skapa kategori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(875, 428);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnTaBort2);
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
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnTaBort2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

