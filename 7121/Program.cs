using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("Hien thi bang so Hex tu 0-255 (he thap phan) trong C#:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            for (int i = 0; i <= 255; i++)
            {
                if (i < 16)  // 0 la so dau tien trong hai so cua hang dau tien
                    Console.Write("0");

                Console.Write("{0} ",
                    Convert.ToString(i, 16));  // so trong he thap luc phan

                if (i % 16 == 15)    // nhay toi hang tiep theo
                    Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
