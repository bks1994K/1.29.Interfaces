namespace Animals
{
    public abstract class AbstractAnimal
    {
        protected int _age;
        protected double _weightFood;
        protected double _atedFood;
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
            get
            {
                return _atedFood;
            }
            protected set
            {
            }
        }

        public void Eat(string[] food, double[] weightFood)
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

        public abstract void Play();

        protected string ConvertArrayToString(string[] array)
        {
            if (array.Length == 0)
            {
                return "something";
            }
            string result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = $"{result} or {array[i]}";
            }
            return result;
        }
    }
}
 