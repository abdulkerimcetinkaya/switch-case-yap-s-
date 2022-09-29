using System;

namespace switch_case_yapısı
{
    class Program
    {
        static void Main(String[] args)
        {

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat ayındasınız");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan ayındasınız");
                    break;
                case 3:
                    System.Console.WriteLine("Mart ayındasınız");
                    break;
                default:
                    System.Console.WriteLine("Yanlış veri girdiniz");
                    break;

            }


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış Ayındasınız");
                    break;

                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar Ayındasınız");
                    break;

                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz Ayındasınız");
                    break;

                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar Ayındasınız");
                    break;

                default:
                break;
            }

        }
    }
}
