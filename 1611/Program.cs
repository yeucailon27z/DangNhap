using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1611
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dtb;
            Console.WriteLine("Moi ban nhap diem tb: ");
            dtb=float.Parse(Console.ReadLine());
            if (dtb >= 8)
                Console.WriteLine("Hoc sinh gioi");
            else if (dtb >= 6.5 && dtb < 8)
                Console.WriteLine("Hoc sinh kha");
            else if (dtb >= 5 && dtb < 6.5)
                Console.WriteLine("Hoc sinh TB");
            else
                Console.WriteLine("Hoc sinh yeu");
            Console.ReadKey();
        }
    }
}
