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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podcasts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(18, 46);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(487, 184);
            this.listBox1.TabIndex = 1;
            // 
            // btnNy1
            // 
            this.btnNy1.Location = new System.Drawing.Point(72, 303);
            this.btnNy1.Name = "btnNy1";
            this.btnNy1.Size = new System.Drawing.Size(131, 35);
            this.btnNy1.TabIndex = 2;
            this.btnNy1.Text = "...Ny";
            this.btnNy1.UseVisualStyleBackColor = true;
            this.btnNy1.Click += new System.EventHandler(this.btnNy1_Click);
            // 
            // btnSpara1
            // 
            this.btnSpara1.Location = new System.Drawing.Point(257, 303);
            this.btnSpara1.Name = "btnSpara1";
            this.btnSpara1.Size = new System.Drawing.Size(121, 35);
            this.btnSpara1.TabIndex = 3;
            this.btnSpara1.Text = "Spara";
            this.btnSpara1.UseVisualStyleBackColor = true;
            // 
            // btnTaBort1
            // 
            this.btnTaBort1.Location = new System.Drawing.Point(404, 303);
            this.btnTaBort1.Name = "btnTaBort1";
            this.btnTaBort1.Size = new System.Drawing.Size(121, 35);
            this.btnTaBort1.TabIndex = 4;
            this.btnTaBort1.Text = "Ta bort";
            this.btnTaBort1.UseVisualStyleBackColor = true;
            // 
            // cboUppdateringsfrekverns
            // 
            this.cboUppdateringsfrekverns.FormattingEnabled = true;
            this.cboUppdateringsfrekverns.Location = new System.Drawing.Point(257, 269);
            this.cboUppdateringsfrekverns.Name = "cboUppdateringsfrekverns";
            this.cboUppdateringsfrekverns.Size = new System.Drawing.Size(121, 28);
            this.cboUppdateringsfrekverns.TabIndex = 6;
            // 
            // cboKategori
            // 
            this.cboKategori.FormattingEnabled = true;
            this.cboKategori.Location = new System.Drawing.Point(404, 269);
            this.cboKategori.Name = "cboKategori";
            this.cboKategori.Size = new System.Drawing.Size(121, 28);
            this.cboKategori.TabIndex = 7;
            this.cboKategori.SelectedIndexChanged += new System.EventHandler(this.cboKategori_SelectedIndexChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(18, 271);
            this.txtURL.Name = "txtURL";
            this.txtURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtURL.Size = new System.Drawing.Size(233, 26);
            this.txtURL.TabIndex = 8;
            this.txtURL.Text = "http://";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = ":URL";
            // 
            // lblUppdateringsfrekvens
            // 
            this.lblUppdateringsfrekvens.AutoSize = true;
            this.lblUppdateringsfrekvens.Location = new System.Drawing.Point(257, 239);
            this.lblUppdateringsfrekvens.Name = "lblUppdateringsfrekvens";
            this.lblUppdateringsfrekvens.Size = new System.Drawing.Size(169, 20);
            this.lblUppdateringsfrekvens.TabIndex = 10;
            this.lblUppdateringsfrekvens.Text = ":Uppdateringsfrekvens";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(432, 239);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(72, 20);
            this.lblKategori.TabIndex = 11;
            this.lblKategori.Text = ":Kategori";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(798, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(299, 164);
            this.listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(18, 384);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(487, 184);
            this.listBox3.TabIndex = 13;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(798, 219);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(299, 26);
            this.txtKategori.TabIndex = 14;
            // 
            // btnNy2
            // 
            this.btnNy2.Location = new System.Drawing.Point(798, 252);
            this.btnNy2.Name = "btnNy2";
            this.btnNy2.Size = new System.Drawing.Size(75, 38);
            this.btnNy2.TabIndex = 15;
            this.btnNy2.Text = "...Ny";
            this.btnNy2.UseVisualStyleBackColor = true;
            // 
            // btnSpara2
            // 
            this.btnSpara2.Location = new System.Drawing.Point(913, 252);
            this.btnSpara2.Name = "btnSpara2";
            this.btnSpara2.Size = new System.Drawing.Size(75, 38);
            this.btnSpara2.TabIndex = 16;
            this.btnSpara2.Text = "Spara";
            this.btnSpara2.UseVisualStyleBackColor = true;
            // 
            // btnTaBort2
            // 
            this.btnTaBort2.Location = new System.Drawing.Point(1022, 252);
            this.btnTaBort2.Name = "btnTaBort2";
            this.btnTaBort2.Size = new System.Drawing.Size(75, 38);
            this.btnTaBort2.TabIndex = 17;
            this.btnTaBort2.Text = "Ta bort";
            this.btnTaBort2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1173, 590);
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
    }
}

