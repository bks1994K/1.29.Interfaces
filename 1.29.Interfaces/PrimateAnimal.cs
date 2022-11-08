namespace Animals
{
    public class PrimateAnimal : AbstractAnimal, IClimber
    {
        public PrimateAnimal(string name)
        {
            Type = "primate";
            Name = name;
            Habitat = "earth";
            HabitatArea = 30000;
            Food = new[] { "bananas" };
            IsPredator = true;
            Sound = "Ygy";
            WeightFood = 75;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} can play with you, if you give {ConvertArrayToString(Food)}");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name}: can climbing vines");
        }
    }
}


