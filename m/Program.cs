using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age:");
            var ageStr = Console.ReadLine();
            int age = Int32.Parse(ageStr);

            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine();

            Console.WriteLine("1) Type R - Read Record  2) Type C - Creat Reccord  3) Type U - Update Record 4) Type D - Detelete Record");
            var command = Console.Read();

            if (command == 'R') 
            {
                new VideoGameView(name, age).Show();
            }
            else if (command == 'C')
            {
                new CreateVideGameCommand(name, age).Execute();
            }else if(command == 'D')
            {
                new DeleteVideoGameCommand(name, age).Detele();          
            }
        }
    }
}
