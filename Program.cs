using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {

            // 0 ile 200 arasındaki asal ve palindrom sayıların toplamı

            int toplam = 0;

            for (int i = 0; i < 200; i++)
            {
                string sayi = i.ToString();
                bool asalSayimi = true;
                for (int k = 0; k < sayi.Length / 2; k++)
                {
                    for (int l = 2; l < i; l++)
                    {
                        if (i % l == 0) // girilen sayının modu alınarak asal olup olmadığına bakılır.
                        {
                            asalSayimi = false;
                            break;
                        }
                    }

                    if (sayi[k] == sayi[sayi.Length - k - 1] && asalSayimi) //baştaki ve sondaki değerlere bakılarak palindrom sayımı değilmi anlaşılır 
                    {
                        toplam += i;

                       
                    }
                        
                }


            }

            Console.WriteLine("TOPlam: " + toplam);


            //string s;

            //Console.Write("Kelime girin : ");

            //s = Console.ReadLine();
            //bool durum = true;
            //for (int i = 0; i < s.Length / 2; i++)
            //{
            //    char ilksayi = s[i];
            //    char sonsayi = s[s.Length - i - 1];

            //    int deger = s.Length / 2;

            //    if (s[i] != s[s.Length - i - 1])
            //        durum = false;
            //}
            //if (durum == true)
            //    Console.WriteLine("Palindrome kelime girdiniz");
            //else
            //    Console.WriteLine("Palindrome olmayan kelime girdiniz");
            //Console.ReadLine();
        }
    }
}
