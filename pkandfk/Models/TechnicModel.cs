using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [StringLength(45)]
    public string Email { get; set; }
    public int Age { get; set; }

    // Ссылка на заказы
    public virtual List<Order> Orders { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public DateTime PurchaseDate { get; set; }

    // Ссылка на покупателя
    public Customer Customer { get; set; }
}

public class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }
}