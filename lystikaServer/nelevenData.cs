using System;
using System.Net;
using System.Text;
using lystikaServer.n11ProductService;
using N11ProductIntegration;
namespace lystikaServer
{
    public class nelevenData
    {
        public static void n11Data()
        {
            /**

            //Giriş Değerleri Verilir
            string anahtar= "dbd6f8d0-52c1-4675-ab4d-3efc2badb56c";
            string gizliAnahtar= "iDg6PakWEtkcLrea";
            int sayfaDegeri       = 0  ;
            int sayfaToplamDegeri = 3;


            //Doğrulamanın İçine Verilen Giriş Değerleri Konulur
           

            var authentication1 = new n11ProductService.Authentication();
            authentication1.appKey = anahtar; //api anahtarınız
            authentication1.appSecret = gizliAnahtar;//api şifeniz

            //veri verilir
            n11ProductService.RequestPagingData requestPagingData = new n11ProductService.RequestPagingData();
            requestPagingData.currentPage =(sayfaDegeri);
            requestPagingData.pageSize    =(sayfaToplamDegeri);

            n11ProductService.GetProductListRequest getProductListRequest = new n11ProductService.GetProductListRequest();
            getProductListRequest.auth       =(authentication1);
            getProductListRequest.pagingData =(requestPagingData);

            n11ProductService.GetProductListRequest1 ikinci = new n11ProductService.GetProductListRequest1();

            n11ProductService.ProductServicePort port = new n11ProductService.ProductServicePortClient();


            n11ProductService.GetProductListRequest ProductListRequest = new n11ProductService.GetProductListRequest();
            ProductListRequest.auth = authentication1;

            n11ProductService.GetProductListResponse response = new n11ProductService.GetProductListResponse();
            





            //Sorgu Yazdırılır




    **/
            string anahtar = "dbd6f8d0-52c1-4675-ab4d-3efc2badb56c";
            string gizliAnahtar = "iDg6PakWEtkcLrea";

            var authentication1 = new n11ProductService.Authentication();
            authentication1.appKey = anahtar; //api anahtarınız
            authentication1.appSecret = gizliAnahtar;//api şifeniz


            long productIdValue = 125661592L;

            n11ProductService.Authentication authentication = new n11ProductService.Authentication();
            authentication.appKey=(anahtar);
            authentication.appSecret=(gizliAnahtar);

            n11ProductService.GetProductByProductIdRequest request = new n11ProductService.GetProductByProductIdRequest();
            
            request.productId=(productIdValue);



            n11ProductService.ProductServicePort port = new ProductServicePortClient();
            GetProductByProductIdResponse response = port.GetProductByProductId(request);

            Product sampleProduct = response.product;
            Console.WriteLine("Name of product is: " + sampleProduct.getTitle());





        }
    }
}
