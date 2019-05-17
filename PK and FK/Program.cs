using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Project_Geolab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Type R - Read Record  2) Type C - Creat Reccord  3) Type U - Update Record 4) Type D - Detelete Record");
            var command = Console.ReadLine();
            
            if("C" == command)
            {
                Console.WriteLine("Enter Name");
                var name = Console.ReadLine();

                Console.WriteLine("Enter Email");
                var email = Console.ReadLine();

                Console.WriteLine("Enter Age");
                var ageStr = Console.ReadLine();
                int age = Int32.Parse(ageStr);

                Console.WriteLine("Enter productname");
                var productname = Console.ReadLine();

                Console.WriteLine("Enter Quantity");
                var quantityStr = Console.ReadLine();
                int quantity = Int32.Parse(quantityStr); 

                new CreateTechnicCommand(name, email, age, productname, quantity).Execute();

            }else if("R" == command)
            {
                Console.WriteLine("Enter Email");
                var email = Console.ReadLine();

                new ShowOrders(email).Show();
            }
        }
    }
}
