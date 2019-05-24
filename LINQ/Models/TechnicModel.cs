using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public DateTime StartDate { get; set; }
}