using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodbkitap
{
    public class Users
    {
        public ObjectId Id { get; set; }
        public string KisiAdi { get; set; }
        public DateTime UyelikTarih { get; set; }


    }
}
