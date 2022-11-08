using Animals;

namespace Animals.Tests
{
    public class PrimateAnimalTests
    {
        [TestCase(new[] { "bananas" }, new[] { 75d }, 75d)]
        [TestCase(new[] { "meat" }, new[] { 10d }, 0)]
        [TestCase(new[] { "bananas", "grass" }, new[] { 10d, 0.5 }, 10d)]
        [TestCase(new[] { "fish", "bananas" }, new[] { 10.5, 20.5 }, 20.5)]
        [TestCase(new[] { "bananas" }, new[] { 2.6 }, 2.6)]
        [TestCase(new[] { "meat", "grass", "bananas" }, new[] { 10d, 25d, 40d }, 40d)]
        [TestCase(new string[] { }, new double[] { }, 0)]
        public void EatTest(string[] a, double[] b, double expected)
        {
            PrimateAnimal primate = new PrimateAnimal("Obezyana");
            primate.Eat(a, b);
            double actual = primate.AtedFood;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { "bananas" }, new[] { -5d })]
        [TestCase(new[] { "meat", "bananas" }, new[] { 5d, -0.5 })]
        [TestCase(new[] { "bananas", "worm" }, new[] { -2.5, -5.5 })]
        public void EatTest_When_weightLessZero_ShouldArgumentException(string[] a, double[] b)
        {
            PrimateAnimal primate = new PrimateAnimal("Obezyana");
            Assert.Throws<ArgumentException>(() => primate.Eat(a, b));
        }

        [TestCase(new[] { "bananas" }, new[] { 5.6, 10d })]
        [TestCase(new[] { "bananas", "meat" }, new[] { 1.2 })]
        [TestCase(new string[] { }, new[] { 20d, 6.9 })]
        [TestCase(new[] { "bananas", "worm" }, new double[] { })]

        public void EatTest_When_weightLengthNotEqual_foodLength_ShouldArgumentException(string[] a, double[] b)
        {
            PrimateAnimal primate = new PrimateAnimal("Obezyana");
            Assert.Throws<ArgumentException>(() => primate.Eat(a, b));
        }
    }
}