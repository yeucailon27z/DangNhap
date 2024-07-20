using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "admin";
            string password = "password";

            Console.WriteLine("Enter username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string inputPassword = Console.ReadLine();
            
            if(inputUsername == username && inputPassword == password) 
            {
                Console.WriteLine("Login successful");
            }
            else 
            {
                Console.WriteLine("Invalid username or password");
            }
            Console.ReadKey();
        }
    }
}
