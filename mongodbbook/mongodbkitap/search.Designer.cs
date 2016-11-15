namespace mongodbkitap
{
    partial class search
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KitapAdi",
            "ISBN",
            "Yazar",
            "BasimYili",
            "Editoru",
            "BaskiNo",
            "YayinEvi",
            "KitabinDili",
            "CevirilenDil",
            "KitabinOzgunAdi",
            "Adedi"});
            this.comboBox1.Location = new System.Drawing.Point(6, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hangi Sutüna Göre Aransın";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Arama Terimi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Arama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.KitapView.Location = new System.Drawing.Point(12, 117);
            this.KitapView.Name = "KitapView";
            this.KitapView.Size = new System.Drawing.Size(1127, 137);
            this.KitapView.TabIndex = 5;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 272);
            this.Controls.Add(this.KitapView);
            this.Controls.Add(this.groupBox1);
            this.Name = "search";
            this.Text = "search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KitapView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView KitapView;
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
        private System.Windows.Forms.Button button2;
    }
}