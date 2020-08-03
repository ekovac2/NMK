using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography;

namespace Zadaća_NMK
{
    public class Klinika
    {
        Administrator admin;
        List<Pregled> pregledi = new List<Pregled>();
        List<Tehnicar> tehnicari = new List<Tehnicar>();
        List<Pacijent> pacijenti = new List<Pacijent>();
        List<Doktor> doktori = new List<Doktor>();
        List<Karton> kartoni = new List<Karton>();
        List<Ordinacija> ordinacije = new List<Ordinacija>();

        public List<Tehnicar> Tehnicari { get => tehnicari; set => tehnicari = value; }
        public List<Pacijent> Pacijenti { get => pacijenti; set => pacijenti = value; }
        public List<Doktor> Doktori { get => doktori; set => doktori = value; }
        public List<Karton> Kartoni { get => kartoni; set => kartoni = value; }
        public List<Ordinacija> Ordinacije { get => ordinacije; set => ordinacije = value; }
        public List<Pregled> Pregledi { get => pregledi; set => pregledi = value; }
        public Administrator Admin { get => admin; set => admin = value; }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }



        public Klinika()
        {
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash,"mmaus");

            Doktor d = new Doktor("Miki", "Maus", "1212812123432", DateTime.Parse("12.12.1970"), 2,"mmaus",hash);
            doktori.Add(d);
            hash = GetMd5Hash(md5Hash, "pdjetlic");
            Doktor o = new Doktor("Pera", "Djetlic", "1212812123432", DateTime.Parse("12.12.1960"), 2,"pdjetlic",hash);
            doktori.Add(o);
            hash = GetMd5Hash(md5Hash, "mmaus1");
            Doktor k = new Doktor("Mini", "Maus", "1212812123432", DateTime.Parse("12.12.1979"), 2,"mmaus1",hash);
            doktori.Add(k);
            hash = GetMd5Hash(md5Hash, "bten");
            Doktor t = new Doktor("Ben", "Ten", "1212812123432", DateTime.Parse("12.12.1964"), 2,"bten",hash);
            doktori.Add(t);
            hash = GetMd5Hash(md5Hash, "lbolek");
            Doktor a = new Doktor("Lolek", "Bolek", "1212812123432", DateTime.Parse("12.12.1975"), 2,"lbolek",hash);
            doktori.Add(a);

            hash = GetMd5Hash(md5Hash, "fbloom");
            Tehnicari.Add(new Tehnicar("Flora", "Bloom", "1212123456123", DateTime.Parse("12.12.1975"), 2, "fbloom", hash, 1000));
            hash = GetMd5Hash(md5Hash, "hfata");
            Tehnicari.Add(new Tehnicar("Huso", "Fata", "1212123456123", DateTime.Parse("12.12.1975"), 2, "hfata", hash, 1200));
            hash = GetMd5Hash(md5Hash, "smujo");
            Tehnicari.Add(new Tehnicar("Suljo", "Mujo", "1212123456123", DateTime.Parse("12.12.1975"), 2, "smujo", hash, 800));


            Ordinacija or = new Ordinacija("opsta medicina", d);
            ordinacije.Add(or);
            Ordinacija di = new Ordinacija("ortopedija", o);
            ordinacije.Add(di);
            Ordinacija na = new Ordinacija("internisticka", k);
            ordinacije.Add(na);
            Ordinacija ci = new Ordinacija("oftamoloska", t);
            ordinacije.Add(ci);
            Ordinacija ja = new Ordinacija("laboratorijska", a);
            ordinacije.Add(ja);

            string hash1 = GetMd5Hash(md5Hash, "akecap");
            Admin = new Administrator("Ash", "Kečap", "1234567891021", DateTime.Parse("12.12.1975"), 2, "akecap", hash1);
        }
    }
}
