using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;
            Console.WriteLine("Moi ban nhap so:");
            n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                sum=sum+i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\t");
            Console.WriteLine("\nTong cac so la:"+sum);
            Console.ReadKey();
        }
    }
}
