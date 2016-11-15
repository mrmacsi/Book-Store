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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void kitapEkle_Click(object sender, EventArgs e)
        {
            BookStore bookStore = new BookStore
            {
                KitapAdi    = bKitapAdi.Text,
                ISBN        = int.Parse(bISBN.Text),
                BasimYili   = bBasimYili.Value,
                Editoru     = bEditoru.Text,
                BaskiNo     = int.Parse(bBaskiNo.Text),
                Yazar       = bYazar.Text,
                YayinEvi    = bYayinEvi.Text,
                KitabinDili = bKitabinDili.Text,
                CevirilenDil = bCevirilenDil.Text,
                KitabinOzgunAdi = bKitabinOzgunAdi.Text,
                Adedi       = int.Parse(adedi.Text)
            };
            MessageBox.Show(Functions.InsertBook(bookStore));
        }

        private void kisiEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Functions.userInsert(uKisiAdi.Text));;
        }

        private void oduncVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Functions.oduncVer(oduncKisiAdi.Text, oduncKitapAdi.Text, oduncAlisTarihi.Value));
        }

        private void geriAl_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Functions.KitapGeriVer(oduncGeriAlKisiAdi.Text, oduncGeriAlKitapAdi.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = Functions.findBook("KitapAdi", removeBook.Text);
            MessageBox.Show(Functions.removeBook(book));;
        }
    }
}
