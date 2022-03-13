using System;

namespace tak_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Repeat deyə bir method olsun və iki parametr qəbul etsin biri 
            //    "word" digəri "count" yəni bu şəkildə "Repeat(string word, int count)" bu method göndərilən
            //    word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.Məsələn:
            //   Repeat("Ha!") //Ha!
            // Repeat("Ha!", 2) //Ha!Ha!
            //       Repeat("Ha!" , 3) //Ha!Ha!Ha!
            Console.WriteLine("yazacaqniz sozu daxil edin");
            string a=Console.ReadLine();
            Console.WriteLine("nece defe yazaqnizi daxil edin");
            int b=Convert.ToInt32(Console.ReadLine()); 
          string d=  Repeat(a, b);
            Console.WriteLine(d);
        }

        static string Repeat(string word,int count)
        {
           string b=word;

            for (int i = 1; i < count; i++)
            {
                b = b + word;
            }
            return b;
        } 
    }
}
