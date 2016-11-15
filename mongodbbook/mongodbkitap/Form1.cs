using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace mongodbkitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                /*
                BookStore bookStore = new BookStore
                {
                    KitapAdi = "Kitap1",
                    ISBN = 123,
                    BasimYili = DateTime.Now,
                    Editoru = "deneme editor",
                    BaskiNo = 12,
                    YayinEvi = "Yayinci",
                    KitabinDili = "turkce",
                    CevirilenDil = "",
                    KitabinOzgunAdi = "",
                    Adedi = 2
                };                
                Functions.InsertBook(bookStore);
                var sonuc =Functions.find("KitapAdi", "Kitap1");
                var sonuc = Functions.find("KitapAdi", "Kitap1");
                       
                Functions.remove(sonuc);
                Functions.userInsert("macit");
                Functions.oduncVer("macit", "Kitap1");
                Functions.KitapGeriVer("macit", "Kitap1");
                

                Functions.oduncVer("macit", "Kitap1");*/
                var barrowed = Functions.findAllOdunc();
                foreach (var item in barrowed)
                {
                    oduncView.Rows.Add(
                        item.KitapAdi,
                        item.KisiAdi,
                        Functions.TimeAgo(item.AldigiTarih),
                        item.GetirmeTarih,
                        item.getirdimi ? "Getirildi" : "Getirilmedi");
                }

                var barrowedGecmisler = Functions.findAllOdunc();
                foreach (var item in barrowed)
                {
                    if ((DateTime.Now - item.AldigiTarih).Days > 30)
                    {
                        suresiGecen.Rows.Add(
                            item.KitapAdi,
                            item.KisiAdi,
                            Functions.TimeAgo(item.AldigiTarih),
                            item.GetirmeTarih,
                            item.getirdimi?"Getirildi":"Getirilmedi");
                    }
                }

                var users = Functions.findAllUsers();
                foreach (var item in users)
                {
                    usersView.Rows.Add(
                        item.KisiAdi,
                        item.UyelikTarih);
                }

                var books = Functions.findAllBooks();
                foreach (var item in books)
                {
                    KitapView.Rows.Add(
                        item.KitapAdi,
                        item.ISBN,
                        item.Yazar,
                        item.BasimYili,
                        item.Editoru,
                        item.BaskiNo,
                        item.YayinEvi,
                        item.KitabinDili,
                        item.CevirilenDil,
                        item.KitabinOzgunAdi,
                        item.Adedi);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add ad = new add();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search src = new search();
            src.Show();
        }
    }
}
