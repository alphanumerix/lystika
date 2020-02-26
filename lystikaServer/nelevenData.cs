using System;
using System.Net;
using System.Text;
using System.ServiceModel;
using System.IO;

//using Microsoft.Web.Services3.Messaging;
using n11Api.com.n11.api;
//using lystikaServer.n11CategoryService;

namespace lystikaServer
{
    
    public class nelevenData
    {
        public static string apiAnahtari1;
        public static string apiSifresi1;

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

            string Fiyat = ReverseString(rawData);

             Fiyat = rawData.Remove(rawData.LastIndexOf("emaNbuSorp"));
            return (Fiyat);
        }

            public static void n11Data()
        {

            string uri = Console.ReadLine();
            string vls = klonAltBaslik(uri);
            
            Console.WriteLine(vls);

            //Console.WriteLine("\" /><input type=\"hidden\" id=\"productSDDPriceDiscount\"");

            Shell.shellLine();


            /*
            ProductBasic[] products = getProds();


            foreach (var prod in products)
            {
                Console.WriteLine("başlık="+prod.title);
                Console.WriteLine("fiyat=" + prod.price);

            }
            




            apiAnahtari1 = "dbd6f8d0-52c1-4675-ab4d-3efc2badb56c";
            apiSifresi1 = "iDg6PakWEtkcLrea";

            var authentication1 = new n11Api.com.n11.api.Authentication();
            authentication1.appKey = apiAnahtari1; //api anahtarınız
            authentication1.appSecret = apiSifresi1;//api şifeniz

            long productIdValue =381565960;

        

            GetProductByProductIdRequest request = new GetProductByProductIdRequest();
            request.auth=(authentication1);
            request.productId=(productIdValue);


            GetProductListRequest ProductListRequest = new GetProductListRequest();
            ProductListRequest.auth = authentication1;

           n11Api.com.n11.api.ProductServicePortService port = new ProductServicePortService();

            GetProductByProductIdRequest getProductByProductIdRequest = new GetProductByProductIdRequest(); 

            GetProductByProductIdResponse response = port.GetProductByProductId(getProductByProductIdRequest);

            var product = response.product;

            Console.WriteLine(product.title);

            Shell.shellLine();
            */
        }

        private static ProductBasic[] getProds()
        {

            apiAnahtari1 = "dbd6f8d0-52c1-4675-ab4d-3efc2badb56c";
            apiSifresi1 = "iDg6PakWEtkcLrea";

            var authentication1 = new n11Api.com.n11.api.Authentication();
            authentication1.appKey = apiAnahtari1; //api anahtarınız
            authentication1.appSecret = apiSifresi1;//api şifeniz


            GetProductListRequest ProductListRequest = new GetProductListRequest();
            ProductListRequest.auth = authentication1;

            ProductServicePortService port = new ProductServicePortService();



            GetProductListResponse response = port.GetProductList(ProductListRequest);
            var products = response.products;
            return products;

           
        }


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
    }
}
