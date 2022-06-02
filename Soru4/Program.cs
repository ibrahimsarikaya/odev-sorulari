using System;

namespace Soru4 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Lütfen Bir Cümle Yaziniz: ");
           string cumle = Console.ReadLine();
           string[] kelimeler = cumle.Split(' ');
           cumle = cumle.Replace(" ","");
           Console.WriteLine("Toplam harf sayisi: " + cumle.Length + " " + "Toplam kelime Sayisi: " + kelimeler.Length);
        }
    }
}