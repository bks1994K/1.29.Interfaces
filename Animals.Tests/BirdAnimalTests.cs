using Animals;

namespace Animals.Tests
{
    public class BirdAnimalTests
    {
        [TestCase(new[] { "grass" }, new[] { 0.5 }, 0.5)]
        [TestCase(new[] { "grass" }, new[] { 12d }, 12d)]
        [TestCase(new[] { "grass", "worm" }, new[] { 5d, 0.8 }, 5.8)]
        [TestCase(new[] { "grass", "worm" }, new[] { 7d, 7d }, 14d)]
        [TestCase(new[] { "grass", "meat" }, new[] { 3.5, 5d }, 3.5)]
        [TestCase(new[] { "meat", "grass" }, new[] { 4.5, 7d }, 7d)]
        [TestCase(new[] { "meat" }, new[] { 0.5 }, 0)]
        [TestCase(new string[] { }, new double[] { }, 0)]
        public void EatTest(string[] a, double[] b, double expected)
        {
            BirdAnimal bird = new BirdAnimal("Ptica");
            bird.Eat(a, b);
            double actual = bird.AtedFood;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { "grass" }, new[] { -5d })]
        [TestCase(new[] { "meat", "grass" }, new[] { -5d, -0.5 })]
        [TestCase(new[] { "grass", "worm" }, new[] { -2.5, -5.5 })]
        public void EatTest_When_weightLessZero_ShouldArgumentException(string[] a, double[] b)
        {
            BirdAnimal bird = new BirdAnimal("Ptica");
            Assert.Throws<ArgumentException>(() => bird.Eat(a, b));
        }

        [TestCase(new[] { "grass" }, new[] { 5.6, 1.2 })]
        [TestCase(new[] { "grass", "meat" }, new[] { 1.2 })]
        [TestCase(new string[] { }, new[] { 1.2, 6.9 })]
        [TestCase(new[] { "grass", "worm" }, new double[] { })]

        public void EatTest_When_weightLengthNotEqual_foodLength_ShouldArgumentException(string[] a, double[] b)
        {
            BirdAnimal bird = new BirdAnimal("Ptica");
            Assert.Throws<ArgumentException>(() => bird.Eat(a, b));
        }
    }
}