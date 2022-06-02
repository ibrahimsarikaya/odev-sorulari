using System;

namespace Soru1 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Pozitif Bir Tam Sayi Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            String sonuc = "";
            if (n<0)
            {
                Console.WriteLine("Girmiş olduğunuz sayı pozitif değildir.");

            }
            else
            {
                for(int i=1; i<=n; i++)
                {
                Console.Write("Lütfen"+ " " + i + "." + " " + "sayiyi giriniz: ");
                int k = int.Parse(Console.ReadLine());

                    if(k%2==0) 
                    {
                        sonuc = sonuc + Convert.ToString(k) + " ";
                    }
                
                }
                Console.WriteLine("Çift Sayılar: " + sonuc);
            }

        }
    }
}