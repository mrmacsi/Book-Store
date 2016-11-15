using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodbkitap
{
    public class BookStore
    {
        public ObjectId Id { get; set; }
        public string KitapAdi { get; set; }
        public int ISBN { get; set; }
        public string Yazar { get; set; }
        public DateTime BasimYili { get; set; }
        public string Editoru { get; set; }
        public int BaskiNo { get; set; }
        public string YayinEvi { get; set; }
        public string KitabinDili { get; set; }
        public string CevirilenDil { get; set; }
        public string KitabinOzgunAdi { get; set; }
        public int Adedi { get; set; }

    }
}
