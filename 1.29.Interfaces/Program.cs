using Animals;

BirdAnimal cormorant = new BirdAnimal("Baklan");
cormorant.Eat(new[] { "worm" }, new[] { 2.9 });
cormorant.Play();
cormorant.Fly();
Console.WriteLine();

BirdAnimal[] birds = new BirdAnimal[]
    { 
    new BirdAnimal("Bird1"),
    new BirdAnimal("Bird2"),
    };
for (int i = 0; i < birds.Length; i++)
{
    if (birds[i] is IFlyer)
    {
        ((IFlyer)birds[i]).Fly();
    }
}
Console.WriteLine();


AbstractAnimal[] animals = new AbstractAnimal[]
    {
    new FishAnimal ("Nemo"),
    new FishAnimal ("Dori"),
    new PrimateAnimal("monkey"),
    new BirdAnimal("waterBird")
    };
for (int i = 0; i < animals.Length; i++)
{
    animals[i].Eat(new[] { "mollusk" }, new[] { 0.5 });
    animals[i].Play();
    animals[i].Eat(new[] { "seaweed" }, new[] { 5.5 });
    if (animals[i] is ISwimmer)
    {
        ((ISwimmer)animals[i]).Swim();
    }    
}
Console.WriteLine();

PrimateAnimal caesar = new PrimateAnimal("Caesar");
caesar.Eat(new[] { "bananas" }, new[] { 100d });
caesar.Play();
caesar.Climb();
Console.WriteLine();

PrimateAnimal[] primates = new PrimateAnimal[]
    {
    new PrimateAnimal ("Primate1"),
    new PrimateAnimal ("Primate2"),
    };
for (int j = 0; j < primates.Length; j++)
{
    if (primates[j] is IClimber)
    {
        ((IClimber)primates[j]).Climb();
    }
}


