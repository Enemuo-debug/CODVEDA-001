namespace AnimalKingdom
{
    public class Vertebrate
    {
        public bool HasBackbone { get; set; } = true;
        public virtual void DisplayInfo()
        {
            Console.WriteLine("I am a vertebrate and I have a backbone: " + HasBackbone);
        }

        public virtual void Sound()
        {
            Console.WriteLine("Vertebrates make various sounds.");
        }
    }
    public class Dog : Vertebrate
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a dog, a vertebrate, and I have a backbone: " + HasBackbone);
        }

        public override void Sound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}