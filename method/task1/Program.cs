using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir method olsun iki parametr qəbul etsin və bu parametrlərdən birincini ikinciyə bölüb nəticəni geri qaytarsın.
            Console.WriteLine("birnic daxil edinn: ");
            
            double a=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ikinci ededi daxil edin");
            double b=Convert.ToDouble(Console.ReadLine());
            double d=Divide(a,b);
            Console.WriteLine(d);



        } static double Divide(double a,double b)
        {
            return a / b;
        } 
    }
}
