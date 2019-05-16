using System;
using System.Linq;
using m;

public class DeleteVideoGameCommand 
{
    private readonly int id;

    public DeleteVideoGameCommand(int id)
    {
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
            Console.WriteLine("Record is Deleted");
        }
    }
}