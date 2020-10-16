namespace Samet_Pansiyon
{
    partial class MusteriList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriList));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnveriler = new System.Windows.Forms.Button();
            this.btnverisil = new System.Windows.Forms.Button();
            this.btnveriara = new System.Windows.Forms.Button();
            this.MTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtTc = new System.Windows.Forms.TextBox();
            this.TxtOda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TarihCikis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TarihGiris = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(853, 205);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 24;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adi";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadi";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TC";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "OdaNo";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ucret";
            this.columnHeader7.Width = 76;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "GirisTarihi";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CikisTarihi";
            this.columnHeader9.Width = 119;
            // 
            // btnveriler
            // 
            this.btnveriler.Location = new System.Drawing.Point(719, 244);
            this.btnveriler.Name = "btnveriler";
            this.btnveriler.Size = new System.Drawing.Size(115, 40);
            this.btnveriler.TabIndex = 1;
            this.btnveriler.Text = "Verileri Göster";
            this.btnveriler.UseVisualStyleBackColor = true;
            this.btnveriler.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnverisil
            // 
            this.btnverisil.BackColor = System.Drawing.Color.Red;
            this.btnverisil.Location = new System.Drawing.Point(719, 295);
            this.btnverisil.Name = "btnverisil";
            this.btnverisil.Size = new System.Drawing.Size(115, 40);
            this.btnverisil.TabIndex = 3;
            this.btnverisil.Text = "Veri Sil";
            this.btnverisil.UseVisualStyleBackColor = false;
            this.btnverisil.Click += new System.EventHandler(this.btnverisil_Click);
            // 
            // btnveriara
            // 
            this.btnveriara.Location = new System.Drawing.Point(719, 458);
            this.btnveriara.Name = "btnveriara";
            this.btnveriara.Size = new System.Drawing.Size(115, 40);
            this.btnveriara.TabIndex = 4;
            this.btnveriara.Text = "Veri Arama";
            this.btnveriara.UseVisualStyleBackColor = true;
            // 
            // MTxtTelefon
            // 
            this.MTxtTelefon.Location = new System.Drawing.Point(185, 337);
            this.MTxtTelefon.Mask = "(999) 000-0000";
            this.MTxtTelefon.Name = "MTxtTelefon";
            this.MTxtTelefon.Size = new System.Drawing.Size(81, 20);
            this.MTxtTelefon.TabIndex = 39;
            // 
            // TxtTc
            // 
            this.TxtTc.BackColor = System.Drawing.SystemColors.Info;
            this.TxtTc.Location = new System.Drawing.Point(185, 433);
            this.TxtTc.MaxLength = 11;
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Size = new System.Drawing.Size(163, 20);
            this.TxtTc.TabIndex = 38;
            // 
            // TxtOda
            // 
            this.TxtOda.BackColor = System.Drawing.SystemColors.Info;
            this.TxtOda.Location = new System.Drawing.Point(185, 383);
            this.TxtOda.Name = "TxtOda";
            this.TxtOda.Size = new System.Drawing.Size(163, 20);
            this.TxtOda.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Oda Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Kimlik Numarası:";
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtSoyadi.Location = new System.Drawing.Point(185, 295);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(163, 20);
            this.TxtSoyadi.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Müşteri Telefonu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtAdi.Location = new System.Drawing.Point(185, 255);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(163, 20);
            this.TxtAdi.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Müşteri Adı:";
            // 
            // TarihCikis
            // 
            this.TarihCikis.Location = new System.Drawing.Point(407, 336);
            this.TarihCikis.Name = "TarihCikis";
            this.TarihCikis.Size = new System.Drawing.Size(200, 20);
            this.TarihCikis.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(405, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 24);
            this.label7.TabIndex = 40;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // TarihGiris
            // 
            this.TarihGiris.Location = new System.Drawing.Point(407, 277);
            this.TarihGiris.Name = "TarihGiris";
            this.TarihGiris.Size = new System.Drawing.Size(200, 20);
            this.TarihGiris.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(405, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // TxtUcret
            // 
            this.TxtUcret.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUcret.ForeColor = System.Drawing.Color.White;
            this.TxtUcret.Location = new System.Drawing.Point(249, 478);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.ReadOnly = true;
            this.TxtUcret.Size = new System.Drawing.Size(151, 23);
            this.TxtUcret.TabIndex = 45;
            this.TxtUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Müşterinin Ödemesi Gereken Ücret";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(694, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(643, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 46;
            this.label9.Text = "İsim";
            // 
            // MusteriList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtUcret);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TarihGiris);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TarihCikis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MTxtTelefon);
            this.Controls.Add(this.TxtTc);
            this.Controls.Add(this.TxtOda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnveriara);
            this.Controls.Add(this.btnverisil);
            this.Controls.Add(this.btnveriler);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriList";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.MusteriList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnveriler;
        private System.Windows.Forms.Button btnverisil;
        private System.Windows.Forms.Button btnveriara;
        private System.Windows.Forms.MaskedTextBox MTxtTelefon;
        private System.Windows.Forms.TextBox TxtTc;
        private System.Windows.Forms.TextBox TxtOda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TarihCikis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TarihGiris;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}