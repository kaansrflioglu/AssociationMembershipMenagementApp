using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class BusinessLayer
    {
        public static string[] bloodTypes =
            { "A Rh+", "A Rh-", "B Rh+", "B Rh-", "AB Rh+", "AB Rh-", "0 Rh+", "0 Rh-" };
        public static string[] cities =
        {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan",
            "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu",
            "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ",
            "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır",
            "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri",
            "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa",
            "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya",
            "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon",
            "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
        };
        public static string[] months =
        {
            "Ocak", "Şubat", "Mart", "Nisan", "Mayıs",
            "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"
        };
        public static string[] years =
        {
            "2010", "2011", "2012", "2013", "2014", "2015",
            "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"
        };

        public string CreateUyelerTable()
        {
            string query = "CREATE TABLE Uyeler (" +
                "TCKimlik varchar(11) UNIQUE,  " +
                "Ad varchar(50),  " +
                "Soyad varchar(50),  " +
                "DogumTarihi Date,  " +
                "KanGrubu varchar(10),  " +
                "Cinsiyet varchar(10),  " +
                "Sehir varchar(20),  " +
                "Adres varchar(100),  " +
                "TelefonNumarasi varchar(15),  " +
                "EpostaAdresi varchar(30),  " +
                "UyeDurumu varchar(10),  " +
                "KayitTarihi DateTime,  " +
                "CONSTRAINT PK_Üyeler PRIMARY KEY (TCKimlik)" +
                ");";
            return query;
        }
        public string CreateAidatlarTable()
        {
            string query = "CREATE TABLE Aidatlar (" +
                "AidatID AUTOINCREMENT,  " +
                "TCKimlik varchar(11),  " +
                "AyYil varchar(15),  " +
                "AidatTutari INT,  " +
                "OdemeDurum varchar(10),  " +
                "FOREIGN KEY (TCKimlik) REFERENCES Uyeler(TCKimlik)" +
                ");";
            return query;
        }

        public string AddMember(string tc, string name, string surname, DateTime birthTime, string bloodType,
            string gender, string city, string address, string tel, string email)
        {
            string query =
                $"INSERT INTO Uyeler " +
                $"(TCKimlik, Ad, Soyad, DogumTarihi, KanGrubu, Cinsiyet, Sehir, Adres, TelefonNumarasi, EpostaAdresi, UyeDurumu, KayitTarihi) " +
                $"VALUES('{tc}', '{name}', '{surname}', #{birthTime:yyyy-MM-dd}#, '{bloodType}', '{gender}', '{city}','{address}', '{tel}', '{email}', 'Aktif', '{DateTime.Now}')";
            return query;
        }
        public string UpdateMember(string tc, string name, string surname, DateTime birthTime, string bloodType,
            string city, string address, string tel, string email, string status)
        {
            string query = $"UPDATE Uyeler SET " +
                           $"Ad = '{name}', Soyad = '{surname}', DogumTarihi = #{birthTime:yyyy-MM-dd}#, KanGrubu = '{bloodType}', " +
                           $"Sehir = '{city}', Adres = '{address}', TelefonNumarasi = '{tel}', EpostaAdresi = '{email}', UyeDurumu = '{status}' " +
                           $"WHERE TCKimlik = '{tc}';";
            return query;
        }
        public string LoadMembers()
        {
            string query = "SELECT * FROM Uyeler";
            return query;
        }
        public string DeleteMember(string tc)
        {
            string query = $"DELETE FROM Uyeler WHERE TCKimlik = '{tc}'";
            return query;
        }
        public string DeleteDues(string tc)
        {
            string query = $"DELETE FROM Aidatlar WHERE TCKimlik = '{tc}'";
            return query;
        }
        public string DeleteDuesID(string id)
        {
            string query = $"DELETE FROM Aidatlar WHERE AidatID = {id}";
            return query;
        }
        public string ShowDues(string tc)
        {
            string query = $"SELECT Ad, Soyad, AidatID, AyYil, AidatTutari, OdemeDurum FROM Uyeler " +
                           $"INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik WHERE " +
                           $"Aidatlar.TCKimlik = '{tc}';";
            return query;
        }
        public string ShowPayments()
        {
            string query =
                $"SELECT Aidatlar.TCKimlik, Ad, Soyad, AyYil, AidatTutari, EpostaAdresi, OdemeDurum FROM Uyeler " +
                $"INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik;";
            return query;
        }
        public string ShowDebtMonths()
        {
            string query = "SELECT Uyeler.Ad, Uyeler.Soyad, EpostaAdresi, Aidatlar.AyYil, Aidatlar.AidatTutari, Aidatlar.OdemeDurum " +
                           "FROM Uyeler INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik " +
                           "WHERE Aidatlar.OdemeDurum = 'Ödenmedi' AND Aidatlar.AyYil IN (";

            return query;
        }
        public string ShowPaidMonths()
        {
            string query = "SELECT Uyeler.Ad, Uyeler.Soyad, EpostaAdresi, Aidatlar.AyYil, Aidatlar.AidatTutari, Aidatlar.OdemeDurum " +
                           "FROM Uyeler INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik " +
                           "WHERE Aidatlar.OdemeDurum = 'Ödendi' AND Aidatlar.AyYil IN (";

            return query;
        }
        public string ShowDebt()
        {
            string query =
                $"SELECT Aidatlar.TCKimlik, Ad, Soyad, AyYil, AidatTutari, EpostaAdresi, OdemeDurum FROM Uyeler " +
                $"INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik WHERE " +
                $"OdemeDurum = 'Ödenmedi';";
            return query;
        }
        public string ShowPaid()
        {
            string query =
                $"SELECT Aidatlar.TCKimlik, Ad, Soyad, AyYil, AidatTutari, EpostaAdresi, OdemeDurum FROM Uyeler " +
                $"INNER JOIN Aidatlar ON Uyeler.TCKimlik = Aidatlar.TCKimlik WHERE " +
                $"OdemeDurum = 'Ödendi';";
            return query;
        }
        public string AddDues(string tc, string date, string deposit, string status)
        {
            string query =
                $"INSERT INTO Aidatlar (TCKimlik, AyYil, AidatTutari, OdemeDurum) VALUES ('{tc}', '{date}', {deposit}, '{status}')";
            return query;
        }
        public string UpdateDuesID(string id, string date, string deposit, string status)
        {
            string query = $"UPDATE Aidatlar SET " +
                           $"AyYil = '{date}', AidatTutari = {deposit}, OdemeDurum = '{status}'" +
                           $"WHERE AidatID = {id};";
            return query;
        }
        public string ListMember(string tc, string bloodType = null, string city = null, string status = null,
            string gender = null)
        {
            string query = "SELECT * FROM Uyeler WHERE 1=1";

            if (!string.IsNullOrEmpty(tc))
                query += $" AND TCKimlik = '{tc}'";

            if (!string.IsNullOrEmpty(bloodType))
                query += $" AND KanGrubu = '{bloodType}'";

            if (!string.IsNullOrEmpty(city))
                query += $" AND Sehir = '{city}'";

            if (!string.IsNullOrEmpty(status))
                query += $" AND UyeDurumu = '{status}'";

            if (!string.IsNullOrEmpty(gender))
                query += $" AND Cinsiyet = '{gender}'";

            return query;
        }
        
    }
}

