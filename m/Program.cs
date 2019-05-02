using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Type R - Read Record  2) Type C - Creat Reccord  3) Type U - Update Record 4) Type D - Detelete Record");
            var command = Console.ReadLine();

            if (command == "R") 
            {
                Console.WriteLine("Enter Name:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                var ageStr = Console.ReadLine();
                int age = Int32.Parse(ageStr);

                new VideoGameView(name, age).Show();
            }
            else if (command == "C")
            {
                Console.WriteLine("Enter Name:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                var ageStr = Console.ReadLine();
                int age = Int32.Parse(ageStr);

                new CreateVideGameCommand(name, age).Execute();
            }else if(command == "D")
            {
                Console.WriteLine("Enter Id:");
                int id = Convert.ToInt32(Console.ReadLine());

                new DeleteVideoGameCommand(id).Detele(id);          
            }else if(command == "U")
            {
                Console.WriteLine("Enter Id:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name:");
                var u_name = Console.ReadLine();

                Console.WriteLine("Enter Age:");
                var u_age = Convert.ToInt32(Console.ReadLine());

                new UpdateVideoGameCommand(id).Update(id, u_name, u_age);
            }
        }
    }
}
