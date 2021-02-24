using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Username: ");
            String Username = Console.ReadLine();
            Console.Write("Enter the Password: ");
            String Password = Console.ReadLine();
            User a = new User(Username, Password);
            if (a.Username == "admin" && a.Password == "admin")
            {
                Console.WriteLine("login sucessful");
            }
            Console.WriteLine("select the payment mode \n 1.cash \n 2.Card");




        }
    }
}
