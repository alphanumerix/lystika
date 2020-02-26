using System;
using System.Windows.Forms;
namespace lystikaServer
{
    public class Shell
    {
       
            public static void shell()
            {
                Console.WriteLine("Komut Gir");
                shellLine();
            }
            public static void shellLine()  //Konsolun Sözdizimlerini Takip Etmesini Sağlar
            {
                string komut;
                Console.Write("#:");
                komut = Console.ReadLine();

                if (komut == "test")
                {
                    Console.WriteLine("Sistem Çalışıyor");
                    shellLine();
                }
                else if (komut == "clear")
                {
                    Console.Clear();
                    shell();
                }

            else if (komut == "n11tool")
            {
                nelevenData.n11Data();


            }
            else if (komut == "n11clonegui")
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else if (komut == "yardim")
                {
                yardim.docShell();
                 }

            else if (komut == "exit")
            {
            }

            else if (komut == "ggtool")
            {
                Console.WriteLine("-----Gittigidiyor Aracı-----");
                Console.WriteLine("list=Genel Kapsamlı Ürün Listeleme");
                Console.WriteLine("searchkw=Anahtar Kelime İle Ürün Arama");
                Console.WriteLine("search=ID İle Ürün Arama");
                Console.WriteLine("addprod=Ürün Ekleme");


                string gtkomt;
                Console.Write("GGTool ?:");
                gtkomt = Console.ReadLine();

                if (gtkomt=="list")
                {
                    gittigidiyorData.GGtumunuListele();
                }
                else
                {
                    Console.WriteLine("Hatalı Girdi");
                    shellLine();
                }

            }

            else
                {
                    Console.WriteLine("Sözdizimi Hatası");
                    shellLine();
                }
            }

        }
    }

