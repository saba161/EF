using System;
using m;

public class DeleteVideoGameCommand 
{
    private  string name;
    private  int age;

    public DeleteVideoGameCommand(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Detele()
    {
          using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
        {
            VideoGame d = context.VideoGames.Find();
            if(d != null)
            {
                context.VideoGames.Remove(d);
                context.SaveChanges();
            }
        }
    }
}