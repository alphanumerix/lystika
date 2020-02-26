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

     
       


        public static void n11Data()
        {

            

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


       
    }
}
