namespace Animals
{
    public class BirdAnimal : AbstractAnimal, IFlyer, ISwimmer
    {
        public BirdAnimal(string name)
        {
            Type = "bird";
            Name = name;
            Habitat = "air";
            HabitatArea = 10000;
            Food = new[] { "grass", "worm" };
            IsPredator = false;
            Sound = "Kurlyk-Kurlyk";
            WeightFood = 10;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} play with {Type}");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name}: I can fly");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name}: I can swim on the surface of the water");
        }
    }
}
