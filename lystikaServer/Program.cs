using System;
using System.Windows.Forms;

namespace lystikaServer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("lystika sunucu tarafına hoş geldin,");
            Console.WriteLine("Bilgi Almak İçin -yardim- Yazabilirsin ");

            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");


            //Shell.shell();//sözdizimi okuyucusunu açar


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
     

     

        }
    }
