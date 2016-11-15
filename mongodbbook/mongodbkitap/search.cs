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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sutun = comboBox1.Text;
                var search = textBox1.Text;
                var sonuc = Functions.findBook(sutun, search);
                KitapView.Rows[0].Cells[0].Value = sonuc.KitapAdi;
                KitapView.Rows[0].Cells[1].Value = sonuc.ISBN;
                KitapView.Rows[0].Cells[2].Value = sonuc.Yazar;
                KitapView.Rows[0].Cells[3].Value = sonuc.BasimYili;
                KitapView.Rows[0].Cells[4].Value = sonuc.Editoru;
                KitapView.Rows[0].Cells[5].Value = sonuc.BaskiNo;
                KitapView.Rows[0].Cells[6].Value = sonuc.YayinEvi;
                KitapView.Rows[0].Cells[7].Value = sonuc.KitabinDili;
                KitapView.Rows[0].Cells[8].Value = sonuc.CevirilenDil;
                KitapView.Rows[0].Cells[9].Value = sonuc.KitabinOzgunAdi;
                KitapView.Rows[0].Cells[10].Value = sonuc.Adedi;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarıyla Güncellendi");
        }
    }
}
