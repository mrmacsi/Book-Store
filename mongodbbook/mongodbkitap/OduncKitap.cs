using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace mongodbkitap
{
    class OduncKitap
    {
        public ObjectId Id { get; set; }
        public ObjectId KitapID { get; set; }
        public string KitapAdi { get; set; }
        public ObjectId UserID { get; set; }
        public string KisiAdi { get; set; }
        public DateTime AldigiTarih { get; set; }
        public DateTime GetirmeTarih { get; set; }
        public bool getirdimi { get; set; }
    }
}
