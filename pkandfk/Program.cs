using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Project_Geolab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("1) Type R - Read Record  2) Type C - Creat Reccord  3) Type U - Update Record 4) Type D - Detelete Record 5) Type E - existing record");
            // var command = Console.ReadLine();
            
            // if("C" == command)
            // {
            //     Console.WriteLine("Enter Name");
            //     var name = Console.ReadLine();

            //     Console.WriteLine("Enter Email");
            //     var email = Console.ReadLine();

            //     Console.WriteLine("Enter Age");
            //     var ageStr = Console.ReadLine();
            //     int age = Int32.Parse(ageStr);

            //     Console.WriteLine("Enter productname");
            //     var productname = Console.ReadLine();

            //     Console.WriteLine("Enter Quantity");
            //     var quantityStr = Console.ReadLine();
            //     int quantity = Int32.Parse(quantityStr); 

            //     new CreateTechnicCommand(name, email, age, productname, quantity).Execute();

            // }else if("R" == command)
            // {
            //     Console.WriteLine("Enter Email");
            //     var email = Console.ReadLine();

            //     new ShowCustomerInformations(email).Show();
            // }else if(command == "E")
            // {
            //     Console.WriteLine("Enter Email");
            //     var email = Console.ReadLine();

            //     Console.WriteLine("Enter productname");
            //     var productname = Console.ReadLine();

            //     Console.WriteLine("Enter Quantity");
            //     var quantityStr = Console.ReadLine();
            //     int quantity = Int32.Parse(quantityStr);
            //     new ExistingCustomer(email, productname, quantity).Existing();
            // }

            var people = new List<Person>
            {
                new Person {Name = "saba", Age = 19},
                new Person {Name = "luka", Age = 16},
                new Person {Name = "giviko", Age = 20}
            };
            var peoplenames = from Person in people where  Person.Age >= 18 select Person.Name;

            foreach(var item in peoplenames)
            {
                Console.WriteLine("Name: {0}", item);
            }

            // var employess = new List<Person>
            // {
            //     new Person 
            //     {
            //         FirstName = "saba",
            //         LastName = "koghuashvili",
            //         Salary = 94000,
            //         StartDate = DateTime.Parse("1/4/2019")
            //     },

            //     new Person 
            //     {
            //         FirstName = "Gio",
            //         LastName = "koghuashvili",
            //         Salary = 20200,
            //         StartDate = DateTime.Parse("2/6/2002")
            //     },

            //     new Person 
            //     {
            //         FirstName = "giviko",
            //         LastName = "koghuashvili",
            //         Salary = 20200,
            //         StartDate = DateTime.Parse("1/1/1999")
            //     }
            // };
        }
    }
}
