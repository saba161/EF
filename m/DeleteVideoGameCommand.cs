using System;
using System.Linq;
using m;

public class DeleteVideoGameCommand 
{
    private readonly string name;
    private readonly int age;
    private readonly int id;

    public DeleteVideoGameCommand(string name, int age, int id)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }

    public void Detele(int id)
    {
        using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
        {
            var d = context.VideoGames;
            if(d != null)
            {
                var remove = d.Where(x => x.Id == id).FirstOrDefault();            
                context.VideoGames.Remove(remove);
                context.SaveChanges();
            }
        }
    }
}