using System;
using System.Linq;
using m;

public class UpdateVideoGameCommand 
{
    private readonly int id;
    
    public UpdateVideoGameCommand(int id)
    {   
        this.id = id;
    }
    public void Update(int id, string u_name, int u_age)
    {
        using (VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
        {
            var entity = context.VideoGames.SingleOrDefault(r => r.Id == this.id);
            if(entity != null)
            {
                entity.Title = u_name;
                entity.Platform = u_age;
                context.SaveChanges();
            }
        }
    }
}