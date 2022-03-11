using System;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(5,6);
            Console.WriteLine(Sum(5,6));
         string info=   Info("Aqil", "Xalilov", 20);
            Console.WriteLine(info );
            int divide=Divide(5,6);
            Console.WriteLine(divide);
           
            
    int Summassive = SumMassiveElement(1,2,3);
            Console.WriteLine(Summassive);
            Console.WriteLine(defaultt(8));
           
        }

        static int Sum(int num1,int num2)
        {
         return num1 + num2;
        }
        static string Info(string name,string surname , int age)
        {
            return $"{name} {surname} {age}";
        }
        static void Print()
        {
            Console.WriteLine("method isledi");
        } 
        static int Divide(int num1,int num2)
        {
            if (num1>num2)
            {
                return num1;

            }else
            {
                return num2;
            }
        }
        static int SumMassiveElement(params int[]arr)
        {
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            } return sum;

        }
        static int defaultt(int num1, int num2 = 3)
        {
            return num1 + num2;
        }
    } 
    
}
