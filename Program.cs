using System;
using System.Security.Cryptography.X509Certificates;

namespace Generics_problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Maximum Problem using Generics");

            int a = 7, b = 6, c = 4;
            float p = 6.7f, q = 8.7f, r = 5.5f;
            string l = "Apple", m = "Peach", n = "Banana";

            Intmaxvalue(a, b, c);
            Floatmax(p, q, r);
            MaxString(l, m, n);
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
            Console.WriteLine("Maximum Integer Value is: " + max);

        }
        public static void Floatmax(float a,float b, float c)
        {
            float max = a;
            {
                if(b.CompareTo(a) > 0)
                {
                    max= b;
                }
                if(c.CompareTo(b) > 0)
                {
                    max= c;
                }
                Console.WriteLine("Maximum Float is Value is: " + max);
            }
            
        }
        public static void MaxString(string l,string m, string n)
        {
            string max=l;
            if (m.CompareTo(l) > 0)
            {
                max= m;
            }
            if (n.CompareTo(m) > 0)
            {
                max= n;
            }
            Console.WriteLine("Enter maximum string: " + max);
        }
    }
}
