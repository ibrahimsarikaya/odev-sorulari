using System;

namespace Soru3 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Lütfen Pozitif Bir Tam Sayi Giriniz: ");
           int n = int.Parse(Console.ReadLine());
           String[] kelimeler = new String[n];

           for (int i = 0; i < n; i++)
           {
               Console.Write("Lütfen " + i + "." +"kelimeyi yaziniz: ");
               kelimeler[i]= Console.ReadLine();
           }
           foreach (String item in kelimeler.Reverse())
           {
               
               Console.Write(item + " ");
           }

           
            
        }
    }
}