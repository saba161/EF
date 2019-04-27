using System;
using System.Linq;
using m;

public class UpdateVideoGameCommand 
{
    private readonly string name;
    private readonly int age;

    public UpdateVideoGameCommand(string name, int age)
    {   
        this.name = name;
        this.age = age;
    }
    public void Update()
    {
        using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
        {
            var u = context.VideoGames;
            if(u != null)
            {
                var update = u.Where(r => r.Title == this.name && r.Platform == age);  
                Console.WriteLine(this.name + this.age);     
            }
        }
    }
}