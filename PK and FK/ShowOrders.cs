using System;
using System.Linq;
using Project_Geolab;

public class ShowOrders 
{
    private readonly string email;

    public ShowOrders(string email)
    {
        this.email = email;
    }

    public void Show()
    {
        using(Technic context = new Technic())
        {
            var findedRecords = context.Customers.Where(r => r.Email == this.email).ToList();
            if(findedRecords.Count() > 0)
            {
                foreach(var item in findedRecords)
                {
                    Console.WriteLine($"Id: {item.Id} Name: {item.Name} Age: {item.Age}");
                }
            }
        }
    }
}

