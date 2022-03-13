using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir method olsun göndərilən "n" sayda ədədin hamsını toplayıb geri qaytarsın.
            int num = Sum(1, 2, 3);
            Console.WriteLine(num);




        } static int Sum( params int[]num)
        {
            int Summ = 0;
            foreach (var item in num)
            {
             
                Summ += item;
            } 
            return Summ;        
        }
    }
}
