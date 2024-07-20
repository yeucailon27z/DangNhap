using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_711._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban chon:");
            // Sử dụng Console.ReadLine() để nhập giá trị từ bàn phím
            int soLuong = int.Parse(Console.ReadLine());

            // In ra giá trị bạn đã nhập
            Console.WriteLine("Ban da nhap so: " + soLuong);

            switch (soLuong)
            {
                case 0:
                    Console.WriteLine("Gioi");
                    break;
                case 1:
                    Console.WriteLine("Kha");
                    break;
                case 2:
                    Console.WriteLine("Trung Binh");
                    break;
                case 3:
                    Console.WriteLine("Yeu");
                    break;
                case 4:
                    Console.WriteLine("Kem");
                    break;
                default:
                    Console.WriteLine("Gia tri nhap vao khong hop le");
                    break;
            }
            Console.ReadKey();
        }
    }
}

