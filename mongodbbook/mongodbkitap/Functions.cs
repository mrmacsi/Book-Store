using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Core;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace mongodbkitap
{
    public static class Functions
    {
        public static string InsertBook(BookStore bookStore)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            collection.Save(bookStore);
            return "Ekleme Başarılı";
        }

        public static BookStore findBook(string attr,string find)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var personels = db.GetCollection<BookStore>("BookStore");
            var query = Query.EQ(attr, find);
            var bookFound = personels.FindOne(query);
            return bookFound;
        }

        public static Users findUser(string attr, string find)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var personels = db.GetCollection<Users>("Users");
            var query = Query.EQ(attr, find);
            var userFound = personels.FindOne(query);
            return userFound;
        }

        public static string updateBook(BookStore book)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var personels = db.GetCollection<BookStore>("BookStore");
            var query = Query.EQ("_id", book.Id);
            var replacement = Update<BookStore>.Replace(book);
            personels.Update(query, replacement);
            return "Güncelleme Başarılı";
        }

        public static string removeBook(BookStore book)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            var query = Query.EQ("_id", book.Id);
            collection.Remove(query);
            return "Silme Başarılı";
        }

        public static string userInsert(string username)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<Users>("Users");
            Users usr = new Users { KisiAdi = username, UyelikTarih = DateTime.Now };
            collection.Save(usr);
            return "Kayıt Başarılı";
        }

        public static string oduncVer(string username, string kitapadi, DateTime alisTarih)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<OduncKitap>("OduncKitap");
            var kitap = Functions.findBook("KitapAdi", kitapadi);
            var kisi = Functions.findUser("KisiAdi", username);
            if (kitap.Adedi > 0)
            {
                kitap.Adedi--;
                Functions.updateBook(kitap);
            }
            OduncKitap odnc = new OduncKitap(){
                KitapAdi    =   kitap.KitapAdi,
                KitapID     =   kitap.Id,
                KisiAdi     =   kisi.KisiAdi,
                UserID      =   kisi.Id,
                AldigiTarih =   alisTarih,
                GetirmeTarih =  DateTime.Now,
                getirdimi   =   false};

            collection.Save(odnc);
            return "Ödünç Verme Başarılı";
        }

        public static string updateOduncKitap(ObjectId KitapID, ObjectId UserID)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var personels = db.GetCollection<OduncKitap>("OduncKitap");
            var odunc = Functions.findOduncKitap(KitapID, UserID);
            if (!odunc.getirdimi)
            {
                var query = Query.EQ("_id", odunc.Id);
                odunc.GetirmeTarih = DateTime.Now;
                odunc.getirdimi = true;
                var replacement = Update<OduncKitap>.Replace(odunc);
                personels.Update(query, replacement);
                return "Güncelleme Başarılı";
            }
            else
            {
                return "Kitap Zaten Getirilmiş";
            }
        }

        internal static OduncKitap findOduncKitap(ObjectId KitapID, ObjectId UserID)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var personels = db.GetCollection<OduncKitap>("OduncKitap");
            var query = Query.And(
                Query<OduncKitap>.EQ(u => u.KitapID, KitapID),
                Query<OduncKitap>.EQ(u => u.UserID, UserID)
            );
            var oduncFound = personels.FindOne(query);
            return oduncFound;
        }


        public static string KitapGeriVer(string username, string kitapadi)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<OduncKitap>("OduncKitap");
            var kitap = Functions.findBook("KitapAdi", kitapadi);
            var kisi = Functions.findUser("KisiAdi", username);
            kitap.Adedi++;
            Functions.updateBook(kitap);
            Functions.updateOduncKitap(kitap.Id, kisi.Id);
            return "Geri Alma Başarılı";
        }

        public static List<Users> findAllUsers()
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<Users>("Users");
            var users = collection.FindAll().ToList();
            return users;
        }
        public static List<BookStore> findAllBooks()
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");
            var books = collection.FindAll().ToList();
            return books;
        }
        internal static List<OduncKitap> findAllOdunc()
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<OduncKitap>("OduncKitap");
            var odunc = collection.FindAll().ToList();
            return odunc;
        }
        internal static List<OduncKitap> gecikenler()
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<OduncKitap>("OduncKitap");
            var odunc = collection.FindAll().ToList();
            return odunc;
        }
        internal static List<OduncKitap> neZamanOduncVerdik()
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<OduncKitap>("OduncKitap");
            var odunc = collection.FindAll().ToList();
            return odunc;
        }


        public static string TimeAgo(DateTime dt)
        {
            TimeSpan span = DateTime.Now - dt;
            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("yaklaşık {0} {1} Önce",
                years, years == 1 ? "yıl" : "yıl");
            }
            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("yaklaşık {0} {1} önce",
                months, months == 1 ? "ay" : "ay");
            }
            if (span.Days > 0)
                return String.Format("yaklaşık {0} {1} önce",
                span.Days, span.Days == 1 ? "gün" : "gün");
            if (span.Hours > 0)
                return String.Format("yaklaşık {0} {1} önce",
                span.Hours, span.Hours == 1 ? "saat" : "saat");
            if (span.Minutes > 0)
                return String.Format("yaklaşık {0} {1} önce",
                span.Minutes, span.Minutes == 1 ? "dakika" : "dakika");
            if (span.Seconds > 5)
                return String.Format("yaklaşık {0} dakika önce", span.Seconds);
            if (span.Seconds <= 5)
                return "şimdi";
            return string.Empty;
        }
    }

}
