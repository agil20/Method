using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Sahe deyə Method(lar) yaradılır.
            //Çevrənin sahəsi -S = p * r² (p = 3)
            //Düzbucaqlının sahəsi -S = a * b

            //Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2

            int circlearea = Circle(3);
            int rectonArea = Circle(3, 4);
            int reccirle = Circle(2, 3, 4, 4);



        } static int Circle(int r)
        { int s;
            return s = (r * r) * 3;
        }
        static int Circle(int a,int b)
        {
            return a * b;
        }
        static int Circle(int a,int b,int c,int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;
            return S;


        }
    }
}
