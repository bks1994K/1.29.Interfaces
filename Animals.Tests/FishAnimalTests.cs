using Animals;

namespace Animals.Tests
{
    public class FishAnimalTests
    {
        [TestCase(new[] { "mollusk", "seaweed" }, new[] { 1d, 0.8 }, 1.8)]
        [TestCase(new[] { "mollusk", "seaweed", "meat" }, new[] { 0.5, 0.5, 1d }, 1d)]
        [TestCase(new[] { "seaweed", "mollusk", }, new[] { 0.3, 1d }, 1.3)]
        [TestCase(new[] { "grass", "mollusk" }, new[] { 0.2, 0.8 }, 0.8)]
        [TestCase(new[] { "grass", "meat" }, new[] { 5d, 0.8 }, 0)]
        [TestCase(new[] { "mollusk", "meat", "seaweed" }, new[] { 5d, 0.8, 10d }, 15d)]
        [TestCase(new string[] { }, new double[] { }, 0)]
        public void EatTest(string[] a, double[] b, double expected)
        {
            FishAnimal fish = new FishAnimal("Ryba");
            fish.Eat(a, b);
            double actual = fish.AtedFood;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { "mollusk" }, new[] { -5d })]
        [TestCase(new[] { "meat", "mollusk" }, new[] { -5d, -0.5 })]
        [TestCase(new[] { "mollusk", "worm" }, new[] { -2.5, 5.5 })]
        public void EatTest_When_weightLessZero_ShouldArgumentException(string[] a, double[] b)
        {
            FishAnimal fish = new FishAnimal("Ryba");
            Assert.Throws<ArgumentException>(() => fish.Eat(a, b));
        }

        [TestCase(new[] { "mollusk" }, new[] { 5.6, 1.2 })]
        [TestCase(new[] { "seaweed", "meat" }, new[] { 1.2 })]
        [TestCase(new string[] { }, new[] { 1.2, 6.9 })]
        [TestCase(new[] { "mollusk", "worm" }, new double[] { })]

        public void EatTest_When_weightLengthNotEqual_foodLength_ShouldArgumentException(string[] a, double[] b)
        {
            FishAnimal fish = new FishAnimal("Ryba");
            Assert.Throws<ArgumentException>(() => fish.Eat(a, b));
        }
    }

}