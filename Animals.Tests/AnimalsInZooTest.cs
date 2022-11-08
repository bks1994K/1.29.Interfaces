
namespace Animals.Tests
{
    public class AnimalsInZooTests
    {
        [TestCase(new[] { "fish" }, new[] { 10d }, 10)]
        [TestCase(new[] { "fish", "grass" }, new[] { 20d, 5d }, 20)]
        [TestCase(new[] { "eggs", "grass" }, new[] { 10d, 50d }, 0)]
        [TestCase(new[] { "eggs", "grass", "fish" }, new[] { 0.5d, 5.9d, 10d }, 10)]
        [TestCase(new[] { "meat", "eggs", "grass", "fish" }, new[] { 10.3d, 0.5d, 5.9d, 9.7d }, 20)]

        public void DoEatTest(string[] a, double[] b, double expected)
        {
            AnimalsInZoo bear = new AnimalsInZoo("bear", "forest", 1000, new[] { "fish", "meat" }, true, "Byyyyeer", "Vinni", 50.5, 3);
            bear.DoEat(a, b);
            double actual = bear.AtedFood;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new[] { "fish", "grass" }, new[] { -10d, 50d })]
        [TestCase(new[] { "meat", "grass" }, new[] { 5.5d, -9d })]
        public void DoEatTest_When_weightLessZero_ShouldArgumentException(string[] a, double[] b)
        {
            AnimalsInZoo bear = new AnimalsInZoo("bear", "forest", 1000, new[] { "fish", "meat" }, true, "Byyyyeer", "Vinni", 50.5, 3);
            Assert.Throws<ArgumentException>(() => bear.DoEat(a, b));
        }

        [TestCase(new[] { "fish", "grass", "meat" }, new[] { 3.2d, 5d })]
        [TestCase(new[] { "eggs", "grass" }, new[] { 0.9d, 15d, 10.6d })]
        [TestCase(new[] { "meat" }, new double[] { })]
        public void DoEatTest_When_weightLengthNoEqual_foodLength_ShouldArgumentException(string[] a, double[] b)
        {
            AnimalsInZoo bear = new AnimalsInZoo("bear", "forest", 1000, new[] { "fish", "meat" }, true, "Byyyyeer", "Vinni", 50.5, 3);
            Assert.Throws<ArgumentException>(() => bear.DoEat(a, b));
        }
    }
}


