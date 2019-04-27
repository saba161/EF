using System;
using m;

public class CreateVideGameCommand 
{
    private readonly string name;
    private readonly int age;

    public CreateVideGameCommand(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
        public void Execute()
        {
            using(VideoGamesDatabaseContext context = new VideoGamesDatabaseContext())
            {
                context.VideoGames.Add(new VideoGame() { Title = this.name , Platform = this.age});
                context.SaveChanges();
            }
            Console.WriteLine("Record is Created");
        }
}