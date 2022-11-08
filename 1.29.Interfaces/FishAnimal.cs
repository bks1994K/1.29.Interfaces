namespace Animals
{
    public class FishAnimal : AbstractAnimal, ISwimmer
    {
        public FishAnimal(string name)
        {
            Type = "fish";
            Name = name;
            Habitat = "water";
            HabitatArea = 50000;
            Food = new[] { "mollusk", "seaweed" };
            IsPredator = true;
            Sound = "BulBul";
            WeightFood = 2.5;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} hard to play underwater");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name}: can breathe underwater");
        }
    }
}

