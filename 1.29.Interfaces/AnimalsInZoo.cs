namespace Animals
{
    public class AnimalsInZoo
    {
        private int _age;
        private double _weightFood;
        private double _atedFood;
        public string Type { get; set; }
        public string Habitat { get; set; }
        public int HabitatArea { get; set; }
        public string[] Food { get; set; }
        public bool IsPredator { get; set; }
        public string Sound { get; set; }
        public string Name { get; set; }
        public double WeightFood
        {
            get
            {
                return _weightFood;
            }
            set
            {
                if (value > 0)
                {
                    _weightFood = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        public double AtedFood
        {
            get { return _atedFood; }
            private set { }
        }

        public AnimalsInZoo(string type, string habitat, int habitatArea, string[] food, bool isPredator, string sound, string name, double weightFood, int age)
        {
            Type = type;
            Habitat = habitat;
            HabitatArea = habitatArea;
            Food = food;
            IsPredator = isPredator;
            Sound = sound;
            Name = name;
            WeightFood = weightFood;
            Age = age;
            _atedFood = 0;
        }

        public AnimalsInZoo(string type, string name)
        {
            Type = type;
            Name = name;
            switch (type)
            {
                case "bear":
                    Habitat = "forest";
                    HabitatArea = 5000;
                    Food = new[] { "meat", "fish" };
                    IsPredator = true;
                    Sound = "Beaaaar";
                    WeightFood = 100;
                    break;
                case "cow":
                    Habitat = "field";
                    HabitatArea = 1000;
                    Food = new[] { "grass" };
                    IsPredator = false;
                    Sound = "Muuuuu";
                    WeightFood = 50;
                    break;
                default:
                    break;
            }
        }

        public void DoEat(string[] food, double[] weightFood)
        {
            if (food.Length != weightFood.Length)
            {
                throw new ArgumentException("arguments are not equal");
            }
            for (int i = 0; i < food.Length; i++)
            {
                if (weightFood[i] < 0)
                {
                    throw new ArgumentException("weightFood <0");
                }
            }
            for (int i = 0; i < food.Length; i++)
            {
                bool canEat = false;
                for (int j = 0; j < Food.Length; j++)
                {
                    if ((food[i] == Food[j]))
                    {
                        Console.WriteLine($"{Name}: I ate {food[i]} {weightFood[i]}");
                        _atedFood = _atedFood + weightFood[i];
                        canEat = true;
                    }
                }
                if (!canEat)
                {
                    Console.WriteLine($"{Name}: I can not eat {food[i]}");
                }
            }
            if (_atedFood >= _weightFood)
            {
                Console.WriteLine($"{Name}: I am full");
            }
            else
            {
                Console.WriteLine($"{Name}: I want more eat");
            }
        }

        public void DoSound()
        {
            Console.WriteLine($"{Name}: {Sound}");
        }

        public void DoPlay()
        {
            if (!IsPredator && _age <= 2)
            {
                Console.WriteLine($"{Name} play with you");
            }
            else if (IsPredator)
            {
                Console.WriteLine($"Play with {Type}-{Name} is dangerous");
            }
        }
    }
}


