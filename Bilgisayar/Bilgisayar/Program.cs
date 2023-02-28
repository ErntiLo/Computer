using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bilgisayar
{
    class Pc
    {




        public void sifre()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                  Eren-Beyza                                          |");
            Console.WriteLine("|                              (Lütfen şifre giriniz)                                  |");
            Console.WriteLine("|                                   (****)                                             |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------------------✉✉✉------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------______----");
        el:
            Console.Write("Şifreyi Buraya giriniz: ");
            String sifre = Console.ReadLine();
            if (sifre == "1474")
            {
               pcek();
            }
            else
            {
                Console.WriteLine("Şifre Yanlış tekrar deneyiniz . . .");
                goto el;
            }
        }
        public void pcek()
        {
       
            Console.WriteLine("Şifre doğru Bilgisayar Açılıyor . . . ");
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      DOSYA GEZGİNİ                                                                   |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      BU BİLGİSAYAR                                                                   |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      ÇÖP KUTUSU                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      Bilmace (2)                                                                     |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      ROBLOX                                                                          |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      VISUAL STUDIO                                                                   |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      SPOTIFY                                                                         |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      Taş Kağıt Makas (1)                                                             |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      DISCORD                                                                         |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      WHATSAPP                                                                        |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|      FUSION 360                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|                                                                                      |");
            Console.WriteLine("|--------------------------------------------------------------------------------------|");
            Console.WriteLine("|                                      --✉✉✉--                                       |");
            Console.WriteLine("|-----------------------------------------------------------------------------______---|");
            bas:
            Console.WriteLine("OYNAMAK İSTEDİĞİNİZ UYGULAMANIN YANINDAKİ SAYIYI YAZINIZ: ");
            string oyun = Console.ReadLine();
            if (oyun == "1")
            {
                tkm();
            }
            if(oyun == "2")
            {
                Console.Clear();
                bilmece();
            }else
            {
                Console.WriteLine("Lütfen Doğru Bir Sayı Giriniz");
                goto bas;
            }
        }
        public void tkm()
        {
            
            Random rnd = new Random();
            Console.Clear();
            Console.Write("------Taş Kağıt Makas------\n" +
                          "1 - Bilgisayara Karşı\n" +
                          "2 - İki Kişilik\n" +
                          "Seçiniz : ");
            int menuSecim = Convert.ToInt32(Console.ReadLine());
            switch (menuSecim)
            {
                case 1:
                    Console.Clear();
                    Console.Write("------Taş Kağıt Makas------\n" +
                                    "1 - Taş\n" +
                                    "2 - Kağıt\n" +
                                    "3 - Makas\n" +
                                    "Seçiniz : ");
                    int oyuncuSecimPC = Convert.ToInt32(Console.ReadLine());
                    int pcSecim = rnd.Next(1, 3);

                    if (pcSecim == oyuncuSecimPC)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                     "Berabere !");
                    }

                    else if (pcSecim == 1 && oyuncuSecimPC == 2)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Oyuncu Kazandı !");
                    }

                    else if (pcSecim == 1 && oyuncuSecimPC == 3)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Bilgisayar Kazandı !");
                    }

                    else if (pcSecim == 2 && oyuncuSecimPC == 1)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Bilgisayar Kazandı !");
                    }

                    else if (pcSecim == 2 && oyuncuSecimPC == 3)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Oyuncu Kazandı !");
                    }

                    else if (pcSecim == 3 && oyuncuSecimPC == 1)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Bilgisayar Kazandı !");
                    }

                    else if (pcSecim == 3 && oyuncuSecimPC == 2)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                   "Oyuncu Kazandı !");
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.Write("------Taş Kağıt Makas------\n" +
                                    "---------1. Oyuncu---------\n" +
                                    "1 - Taş\n" +
                                    "2 - Kağıt\n" +
                                    "3 - Makas\n" +
                                    "Seçiniz : ");
                    int oyuncuSecim = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    Console.Write("------Taş Kağıt Makas------\n" +
                                    "---------2. Oyuncu---------\n" +
                                    "1 - Taş\n" +
                                    "2 - Kağıt\n" +
                                    "3 - Makas\n" +
                                    "Seçiniz : ");
                    int oyuncu2Secim = Convert.ToInt32(Console.ReadLine());

                    if (oyuncu2Secim == oyuncuSecim)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                     "Berabere !");
                    }

                    else if (oyuncu2Secim == 1 && oyuncuSecim == 2)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                        "1. Oyuncu Kazandı !");
                    }

                    else if (oyuncu2Secim == 1 && oyuncuSecim == 3)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                       "2. Oyuncu Kazandı !");
                    }

                    else if (oyuncu2Secim == 2 && oyuncuSecim == 1)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                        "2. Oyuncu Kazandı !");
                    }

                    else if (oyuncu2Secim == 2 && oyuncuSecim == 3)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                        "1. Oyuncu Kazandı !");
                    }

                    else if (oyuncu2Secim == 3 && oyuncuSecim == 1)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                        "1. Oyuncu Kazandı !");
                    }

                    else if (oyuncu2Secim == 3 && oyuncuSecim == 2)
                    {
                        Console.Clear(); Console.WriteLine("------Taş Kağıt Makas------\n" +
                                                                                                        "2. Oyuncu Kazandı !");
                        
                    }
                    break;
           
            }


            
        }

        public void bilmece()
        {
            string cevap1, cevap2, cevap3, cevap4, cevap5;
            int secim;
            Console.WriteLine("                             ****> BiLMeCeLeR <***** \n\nBilmece oyununa hoşgeldiniz.Başlamak için bir seçim yapınız. \n\n1)Oyuna başla 2)Cevapları gör\n\nUYARI ! Lütfen soruları küçük harflerle cevaplandırınız.");
            secim = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Dışı var içi yok, dayak yer suçu yok");
                    cevap1 = Console.ReadLine();
                    if (cevap1 == "top")
                    {
                        Console.Write("Tebrikler. Doğru cevap. Bir sonraki soruya geçmek için bir tuşa basınız.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Yattım yumuşak, uyudum sıcak sıcak");
                        cevap2 = Console.ReadLine();
                        if (cevap2 == "yatak")
                        {
                            Console.Write("Tebrikler. Doğru cevap. Bir sonraki soruya geçmek için bir tuşa basınız.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Çarşıdan aldım bir tane,eve geldim bin tane");
                            cevap3 = Console.ReadLine();
                            if (cevap3 == "nar")
                            {
                                Console.Write("Tebrikler. Doğru cevap. Bir sonraki soruya geçmek için bir tuşa basınız.");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Bilmece bildirmece el üstünde kaydırmaca");
                                cevap4 = Console.ReadLine();
                                if (cevap4 == "sabun")
                                {
                                    Console.Write("Tebrikler. Doğru cevap. Bir sonraki soruya geçmek için bir tuşa basınız.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Ne içilir ne yenir, sıcakta kaldımı erir");
                                    cevap5 = Console.ReadLine();
                                    if (cevap5 == "dondurma")
                                    {
                                        Console.Write("Tebrikler. Doğru cevap. Oyunu bitirdiniz. Kapatmak için bir tuşa basınız.");
                                        Console.ReadKey();
                                    }
                                    if (cevap5 != "dondurma")
                                    {
                                        Console.Write("\nMalesef yanlış cevap.Elendiniz.Kapatmak için bir tuşa basınız.\n\n(Not: Yardım için oyun başlangıcındaki 'Cevapları Gör' şıkkını seçebilirsiniz.) ");
                                        Console.ReadKey();
                                    }
                                }
                                if (cevap4 != "sabun")
                                {
                                    Console.Write("\nMalesef yanlış cevap.Elendiniz.Kapatmak için bir tuşa basınız.\n\n(Not: Yardım için oyun başlangıcındaki 'Cevapları Gör' şıkkını seçebilirsiniz.) ");
                                    Console.ReadKey();
                                }
                            }
                            if (cevap3 != "nar")
                            {
                                Console.Write("\nMalesef yanlış cevap.Elendiniz.Kapatmak için bir tuşa basınız.\n\n(Not: Yardım için oyun başlangıcındaki 'Cevapları Gör' şıkkını seçebilirsiniz.) ");
                                Console.ReadKey();
                            }
                        }
                        if (cevap2 != "yatak")
                        {
                            Console.Write("\nMalesef yanlış cevap.Elendiniz.Kapatmak için bir tuşa basınız.\n\n(Not: Yardım için oyun başlangıcındaki 'Cevapları Gör' şıkkını seçebilirsiniz.) ");
                            Console.ReadKey();
                        }
                    }
                    if (cevap1 != "top")
                    {
                        Console.Write("\nMalesef yanlış cevap.Elendiniz.\nKapatmak için bir tuşa basınız.\n\n(Not: Yardım için oyun başlangıcındaki 'Cevapları Gör' şıkkını seçebilirsiniz.) ");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.Write("-------> Cevaplar <-------\n\nSoru1:Top\nSoru2:Yatak\nSoru3:Nar\nSoru4:Sabun\nSoru5:Dondurma\n\nKapatmak için bir tuşa basınız.");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("Hatalı tuşlama yaptınız.Kapatmak için bir tuşa basınız.");
                    Console.ReadKey();
                    break;
            }
        }
        
        internal class Program
        {


            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Pc bilgisayar = new Pc();
                bilgisayar.sifre();

                Console.ReadKey();
            }
        }
    }
}

