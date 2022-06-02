using System;

namespace Soru2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Birinci Pozitif Tam Sayi Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Ikinci Pozitif Tam Sayi Giriniz: ");
            int m = int.Parse(Console.ReadLine());
            String sonuc = "";

            if(n<0 || m<0)
            {
                Console.WriteLine("Girmiş olduğunuz sayilar pozitif değildir. ");
            }
            else
            {
                for (int i = 1; i <= n ; i++)
                {
                    Console.Write("Lütfen" + " " + i + "." + "sayiyi giriniz: ");
                    int k= int.Parse(Console.ReadLine());

                    if (k==m || k%m==0)
                    {
                        sonuc = sonuc + Convert.ToString(k) + " ";
                    }
                }
            Console.WriteLine("Tam bölünen yada eşit sayilar: " + sonuc);
            }

            
        }
    }
}