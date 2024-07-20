using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuhocc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
             public double length;
        public double width;

        //cac phuong thuc
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
    }
}
