namespace mongodbkitap
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
            this.oduncView = new System.Windows.Forms.DataGridView();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KisiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AldigiTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetirmeTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getirdimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersView = new System.Windows.Forms.DataGridView();
            this.uKisiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyelikTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapView = new System.Windows.Forms.DataGridView();
            this.bKitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasimYili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editoru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaskiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YayinEvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitabinDili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CevirilenDil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitabinOzgunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.suresiGecen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oduncView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suresiGecen)).BeginInit();
            this.SuspendLayout();
            // 
            // oduncView
            // 
            this.oduncView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oduncView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapAdi,
            this.KisiAdi,
            this.AldigiTarih,
            this.GetirmeTarih,
            this.getirdimi});
            this.oduncView.Location = new System.Drawing.Point(22, 213);
            this.oduncView.Name = "oduncView";
            this.oduncView.Size = new System.Drawing.Size(544, 134);
            this.oduncView.TabIndex = 0;
            // 
            // KitapAdi
            // 
            this.KitapAdi.HeaderText = "KitapAdi";
            this.KitapAdi.Name = "KitapAdi";
            // 
            // KisiAdi
            // 
            this.KisiAdi.HeaderText = "KisiAdi";
            this.KisiAdi.Name = "KisiAdi";
            // 
            // AldigiTarih
            // 
            this.AldigiTarih.HeaderText = "AldigiTarih";
            this.AldigiTarih.Name = "AldigiTarih";
            // 
            // GetirmeTarih
            // 
            this.GetirmeTarih.HeaderText = "GetirmeTarih";
            this.GetirmeTarih.Name = "GetirmeTarih";
            // 
            // getirdimi
            // 
            this.getirdimi.HeaderText = "Geriye Getirildimi";
            this.getirdimi.Name = "getirdimi";
            // 
            // usersView
            // 
            this.usersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uKisiAdi,
            this.UyelikTarih});
            this.usersView.Location = new System.Drawing.Point(667, 213);
            this.usersView.Name = "usersView";
            this.usersView.Size = new System.Drawing.Size(245, 296);
            this.usersView.TabIndex = 1;
            // 
            // uKisiAdi
            // 
            this.uKisiAdi.HeaderText = "KisiAdi";
            this.uKisiAdi.Name = "uKisiAdi";
            // 
            // UyelikTarih
            // 
            this.UyelikTarih.HeaderText = "UyelikTarih";
            this.UyelikTarih.Name = "UyelikTarih";
            // 
            // KitapView
            // 
            this.KitapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KitapView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bKitapAdi,
            this.ISBN,
            this.Yazar,
            this.BasimYili,
            this.Editoru,
            this.BaskiNo,
            this.YayinEvi,
            this.KitabinDili,
            this.CevirilenDil,
            this.KitabinOzgunAdi,
            this.Adedi});
            this.KitapView.Location = new System.Drawing.Point(22, 44);
            this.KitapView.Name = "KitapView";
            this.KitapView.Size = new System.Drawing.Size(1127, 137);
            this.KitapView.TabIndex = 2;
            // 
            // bKitapAdi
            // 
            this.bKitapAdi.HeaderText = "KitapAdi";
            this.bKitapAdi.Name = "bKitapAdi";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Yazar
            // 
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.Name = "Yazar";
            // 
            // BasimYili
            // 
            this.BasimYili.HeaderText = "BasimYili";
            this.BasimYili.Name = "BasimYili";
            // 
            // Editoru
            // 
            this.Editoru.HeaderText = "Editoru";
            this.Editoru.Name = "Editoru";
            // 
            // BaskiNo
            // 
            this.BaskiNo.HeaderText = "BaskiNo";
            this.BaskiNo.Name = "BaskiNo";
            // 
            // YayinEvi
            // 
            this.YayinEvi.HeaderText = "YayinEvi";
            this.YayinEvi.Name = "YayinEvi";
            // 
            // KitabinDili
            // 
            this.KitabinDili.HeaderText = "KitabinDili";
            this.KitabinDili.Name = "KitabinDili";
            // 
            // CevirilenDil
            // 
            this.CevirilenDil.HeaderText = "CevirilenDil";
            this.CevirilenDil.Name = "CevirilenDil";
            // 
            // KitabinOzgunAdi
            // 
            this.KitabinOzgunAdi.HeaderText = "KitabinOzgunAdi";
            this.KitabinOzgunAdi.Name = "KitabinOzgunAdi";
            // 
            // Adedi
            // 
            this.Adedi.HeaderText = "Adedi";
            this.Adedi.Name = "Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitaplar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ödünç Verilenler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kişiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Süresi Geçenler";
            // 
            // suresiGecen
            // 
            this.suresiGecen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suresiGecen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.suresiGecen.Location = new System.Drawing.Point(22, 375);
            this.suresiGecen.Name = "suresiGecen";
            this.suresiGecen.Size = new System.Drawing.Size(544, 134);
            this.suresiGecen.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "KitapAdi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "KisiAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "AldigiTarih";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "GetirmeTarih";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Geriye Getirildimi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sisteme Ekleme Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(976, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Özel Arama";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suresiGecen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KitapView);
            this.Controls.Add(this.usersView);
            this.Controls.Add(this.oduncView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oduncView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitapView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suresiGecen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView oduncView;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AldigiTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetirmeTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn getirdimi;
        private System.Windows.Forms.DataGridView usersView;
        private System.Windows.Forms.DataGridView KitapView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uKisiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyelikTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasimYili;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editoru;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaskiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn YayinEvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitabinDili;
        private System.Windows.Forms.DataGridViewTextBoxColumn CevirilenDil;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitabinOzgunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adedi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView suresiGecen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

