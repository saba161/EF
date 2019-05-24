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
            // 1) ****************************************************************
            // var people = new List<Person>
            // {
            //     new Person {Name = "saba", Age = 19},
            //     new Person {Name = "luka", Age = 16},
            //     new Person {Name = "giviko", Age = 20}
            // };
            // var peoplenames = from Person in people where  Person.Age >= 18 select Person.Name;

            // foreach(var item in peoplenames)
            // {
            //     Console.WriteLine("Name: {0}", item);
            // }

            // 2) ****************************************************************

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
            //         Salary = 2200,
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
            // var query = employess.Where(e => e.Salary > 2200)
            //     .Select(e => new {FirstName = e.FirstName, LastName = e.LastName, Salary = e.Salary});
            
            // foreach(var item in query)
            // {
            //     Console.WriteLine("FirstName = {0} | LastName = {1} | Salary = {2}", item.FirstName, item.LastName, item.Salary);
            // }

            // 3) ****************************************************************

            
        }
    }
}
