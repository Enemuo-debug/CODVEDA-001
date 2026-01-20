namespace AnimalKingdom;

public class Non_Vertebrate
{
    public bool HasBackbone { get; set; } = false;
    public virtual void DisplayInfo()
    {
        Console.WriteLine("I am a non-vertebrate and I don't have a backbone");
    }
    public virtual void Sound()
    {
        Console.WriteLine("Non-vertebrates make various sounds.");
    }
}

public class Snake : Non_Vertebrate
{
    public override void DisplayInfo()
    {
        Console.WriteLine("I am a snake, a non-vertebrate, and I don't have a backbone");
    }
    public override void Sound()
    {
        Console.WriteLine("Hiss");
    }
}
