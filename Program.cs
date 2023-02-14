using System;

namespace Generics_problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Maximum Problem using Generics");

            int a = 7, b = 6, c = 4;
            Intmaxvalue(a, b, c);
        }


        public static void Intmaxvalue(int a,int b, int c)
        {
            int max = a;
            if(b.CompareTo(a) >0)
            {
                max= b;
            }
            if(c.CompareTo(b) >0)
            {
                max= c;
            }
            Console.WriteLine("Maximum Integer is: " + max);

        }
    }
}
