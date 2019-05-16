using System;
using System.Linq;
using m;

public class VideoGameView 
{
    private readonly string name;
    private readonly int age;

    public VideoGameView(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Show() 
    {
        using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
        {
            var findedRecords = context.VideoGames.Where(r => r.Title == this.name && r.Platform == age);
            if (findedRecords.Count() > 0) 
            {
                foreach(var item in findedRecords)
                {
                    Console.WriteLine($"Id: {item.Id} Platform: {item.Platform} Title: {item.Title}");
                }
            } 
            else 
            {
                Console.WriteLine($"Record with Name: {name} and with Age: {age} not found");
            }  
        }
    }
}