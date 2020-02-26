using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ServiceModel;
using System.IO;

namespace lystikaServer
{
    class n11Klon
    {
        public static String code(string Url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string klonBaslik(string s)
        {
            string uridata = s;
            string rawData = (code(uridata));

            string Baslik = rawData.Remove(rawData.LastIndexOf("- n11.com"));
            Baslik = ReverseString(Baslik);
            Baslik = Baslik.Remove(Baslik.LastIndexOf(">eltit<"));
            Baslik = ReverseString(Baslik);








            return (Baslik);

        }

        public static string klonAciklama(string s)
        {
            string uridata = s;
            string rawData = (code(uridata));

            string Aciklama = ReverseString(rawData);
            Aciklama = Aciklama.Remove(Aciklama.LastIndexOf(">\"sliated metIlenaPbat\"=ssalc noitces<"));
            Aciklama = Aciklama.Remove(Aciklama.LastIndexOf(">4h/<ralıtnıryA>\"eltit\"=ssalc 4h<"));
            Aciklama = ReverseString(Aciklama);
            Aciklama = Aciklama.Remove(Aciklama.LastIndexOf("<section class=\"tabPanelItem delInfo\">"));









            return (Aciklama);

        }

        /*  public static string klon(string s)
          {
              string uridata = s;
              string rawData = (code(uridata));

              string Aciklama = ReverseString(rawData);
              Aciklama = Aciklama.Remove(Aciklama.LastIndexOf(">\"sliated metIlenaPbat\"=ssalc noitces<"));
              Aciklama = Aciklama.Remove(Aciklama.LastIndexOf(">4h/<ralıtnıryA>\"eltit\"=ssalc 4h<"));
              Aciklama = ReverseString(Aciklama);
              Aciklama = Aciklama.Remove(Aciklama.LastIndexOf("</section>"));









              return (Aciklama);

          }
          */
        public static string klonFiyat(string s)
        {
            string uridata = s;
            string rawData = (code(uridata));



            string Fiyat = rawData.Remove(rawData.LastIndexOf("<input type=\"hidden\" id=\"productSDDPriceDiscount\""));
            Fiyat = ReverseString(Fiyat);
            Fiyat = Fiyat.Remove(Fiyat.LastIndexOf("\"=eulav \"ecirPtcudorp"));
            Fiyat = ReverseString(Fiyat);
            Fiyat = Fiyat.Remove(Fiyat.LastIndexOf("\" />"));

            return (Fiyat);
        }

        public static string klonAltBaslik(string s)
        {
            string uridata = s;
            string rawData = (code(uridata));


            string Fiyat = rawData.Remove(rawData.LastIndexOf("class=\"ratingText"));
            Fiyat = ReverseString(Fiyat);
            Fiyat = Fiyat.Remove(Fiyat.LastIndexOf(">\"emaNbuSorp"));
            Fiyat = ReverseString(Fiyat);
            Fiyat = Fiyat.Remove(Fiyat.LastIndexOf("</h2>"));


            return (Fiyat);
        }


        public static string klonResim(string s)
        {
            string uridata = s;
            string rawData = (code(uridata));


            string resimveri = rawData.Remove(rawData.LastIndexOf("<div class=\"imgObj\">"));
            resimveri = ReverseString(resimveri);
            resimveri = resimveri.Remove(resimveri.LastIndexOf(">\"jbOgmi\"=ssalc vid<"));
            resimveri = ReverseString(resimveri);

            string[] everycut = resimveri.Split(new string[] { "data-src=" }, StringSplitOptions.None);


               

            resimveri = "";

            foreach (var item in everycut)
            {
                int i = 0;
                resimveri = resimveri + "," + everycut[i];
            }

            resimveri = ReverseString(resimveri);

            string[] everycut2 = resimveri.Split(new string[] { "\"=lanigiro-atad" }, StringSplitOptions.None);
            ;

            resimveri = "";

            foreach (var item in everycut2)
            {
                int ei = 0;
                everycut2[ei] = ReverseString(everycut2[ei]);

            }

            foreach (var item in everycut2)
            {
                int i2 = 0;


                resimveri = resimveri + everycut2[i2];
            }

            return (resimveri);
        }

    }
}
