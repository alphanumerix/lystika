using System;
namespace lystikaServer
{
    public class yardim
    {
        public static void docShell()
        {
            Console.Clear();
            Console.WriteLine("lystika yardımına hoş geldin");
            Console.WriteLine("Tüm Komutların Listesi için -hepsi- yazabilirsin");
            Console.WriteLine("Geriye dönmek için -back- yazabilirsin");
            Console.WriteLine("Bir Komut hakkında bilgi almak istiyorsan komutun adını yazabilirsin");
            shellDoc();
         }
            public static void shellDoc()  //Konsolun yardım sözdizimlerini Takip Etmesini Sağlar
            {
                string komut;
                Console.Write("yardım :");
                komut = Console.ReadLine();

                if (komut == "test")
                {
                    Console.WriteLine("Sistemi Test etmek için kullanılır");
                    shellDoc();
                }
                else if (komut == "clear")
                {
                    Console.WriteLine("Ekranı temizlemek için kullanılır ");
                    shellDoc();


                }
                else if (komut == "yardim")
                {
                    Console.WriteLine("Yardım'a Gelmek İçin kullanılır");
                    shellDoc();

                }

                else if (komut == "exit")
                {
                    Console.WriteLine("Çıkmak İçin Kullanılır");
                    shellDoc();

                }
                else if (komut == "hepsi")
                {
                    Console.WriteLine("exit,yardim,clear,test,ggtool");
                    shellDoc();

                }
                else if (komut == "back")
                {
                    Shell.shell();

                }
                else if (komut=="ggtool")
                {
                Console.WriteLine("Gittigidiyor ürünlerine müdahale etmek ve görüntülemek için kullanılır");
                Console.WriteLine("list=Genel Kapsamlı Ürün Listeleme");
                Console.WriteLine("searchkw=Anahtar Kelime İle Ürün Arama");
                Console.WriteLine("search=ID İle Ürün Arama");
                Console.WriteLine("addprod=Ürün Ekleme");




                shellDoc();
            }


                else
                {
                    Console.WriteLine("Hatalı Giriş");
                    shellDoc();
                }
            }

        }
    }
