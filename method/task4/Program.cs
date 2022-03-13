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

            int circlearea = CircleArea(3);
            int rectonArea = RectanArea(3, 4);
            int reccirle = RecCircle(2, 3, 4, 4);



        } static int CircleArea(int r,int p = 3) //perimetrin qiymetini verirem cunku basa cevrelerdde islede bilek
        { int s;
            return s = (r * r) * p;
        }
        static int RectanArea(int a,int b)
        {
            return a * b;
        }
        static int RecCircle(int a,int b,int c,int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;
            return S;


        }
    }
}
