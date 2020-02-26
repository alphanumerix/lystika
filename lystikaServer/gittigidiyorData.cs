using System;
using GittiGidiyor;
using GittiGidiyor.Product;
using GittiGidiyor.Cargo;
using GittiGidiyor.Search;
namespace lystikaServer
{
    public class gittigidiyorData
    {
     public static void GGtumunuListele()//ürün listesi getirme
        {
            AuthConfig config = new AuthConfig();
            config.ApiKey = "7PK2PGYfWTwaS7SepH5XSUVcWCduyzC8";
            config.SecretKey = "SREzBND4y7tD7pCW";
            config.RoleName = "elkstor";
            config.RolePass = "VfAFVPjCy2bdaFkFrYQnJEDx92NRmTzP";
            ConfigurationManager.setAuthParameters(config);

        Console.WriteLine("----GittiGidiyor Seçkili Listeleme----");
            Console.WriteLine("Aktif Satışlar İçin= as");
            Console.WriteLine("Listelemeye Hazır İçin= lh");
            Console.WriteLine("Satılanlar İçin= s");
            Console.WriteLine("Satılmayanlar İçin= snot");
            string pullVeri=("A");
            Console.Write( "?=" );
            pullVeri = Console.ReadLine();
               string kondisyonSeckisi=("Veri yook xd");

            if (pullVeri=="as")
            {
                kondisyonSeckisi = "A";
            }

           else if (pullVeri == "lh")
            {
                kondisyonSeckisi = "L";
            }
            else if (pullVeri == "s")
            {
                kondisyonSeckisi = "S";
            }
            else if (pullVeri == "snot")
            {
                kondisyonSeckisi = "U";
            }
            else
            {
                Console.WriteLine("Yanlış Girdi Yaptınız Lütfen Tekrar Deneyiniz ");
               
                 GGtumunuListele();       
                              
                                           }


            string kehkeh;
            Console.Write("Kaç Ürün Görüntülensin :");
            kehkeh = Console.ReadLine();
            int kacUrun = Convert.ToInt32(kehkeh);



            try
            {
                ProductService productService = ServiceProvider.getProductService();
                


                productServiceListResponse response = productService.getProducts(0,kacUrun,kondisyonSeckisi, true, "tr");





                if (response != null && response.ackCode.ToString().Equals("success"))
                {
                    int urunCount=0;

                    Console.WriteLine(response.productCount);
                    productDetailType[] productDetail = response.products;
                    foreach (productDetailType productDetailType in productDetail)
                    {
                        urunCount++;

                        Console.WriteLine("*****************************************");
                        Console.Write(urunCount.ToString()+". Ürün   ");
                        Console.Write(" id:  " + productDetailType.productId);
                        Console.WriteLine(" Fiyat:" + productDetailType.product.buyNowPrice + " tl");

                        // Console.WriteLine("ürün kk :" + productDetailType.product.categoryCode);
                        Console.WriteLine("başlık:  " + productDetailType.product.title);
                     //   Console.WriteLine("ürün format:" + productDetailType.product.format);
                        Console.WriteLine(" ürün açıklama:  " + productDetailType.product.description);
                        //  Console.WriteLine("resim verisi:" + productDetailType.product.photos);
                        Console.WriteLine("*****************************************");
                        Console.WriteLine("");
                        Console.WriteLine("");




                        //  Console.WriteLine(productDetailType.product.photos);//fotoğrafları almak başlıktan sonra en önemli detay

                    }




                    

                }
                else
                {
                    Console.WriteLine(response.error.errorId);
                    Console.WriteLine(response.error.errorCode);
                    Console.WriteLine(response.error.message);
                    Shell.shell();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu ,Sistem Yöneticisine Danışın");
            }


            Shell.shell();



        }

        



    }

    }
