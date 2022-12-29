using NUnit.Framework;

namespace OneDimArrays1.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new[] { 261, -288, 224, -280, -30, 2 }, 50, 485)]
        [TestCase(new[] { 180, -173, 65, 222, -200, -66 }, 67, 402)]
        [TestCase(new[] { 162, 30, 27, 268, 116, 223 }, 120, 653)]
        public void Task1_ReturnsCorrectValue(int[] array, int a, int expected)
        {
            var actual = Tasks.Task1(array, a);

            Assert.AreEqual(expected, actual, "Task1 returns incorrect value.");
        }


        [TestCase(new[] { 261, -288, 224, -280, -30, 2 }, -598)]
        [TestCase(new[] { 180, -173, 65, 222, -200 }, -373)]
        [TestCase(new[] { 162, 30, 27, 268, 116, -5 }, -5)]
        public void Task2_ReturnsCorrectValue(int[] array, int expected)
        {
            var actual = Tasks.Task2(array);

            Assert.AreEqual(expected, actual, "Task2 returns incorrect value.");
        }

        [TestCase(new[] { 3, 7, 16, 12, 5, 22, 100 }, 116)]
        [TestCase(new[] { 8, 20, 36, 1, -6, -5 }, 38)]
        [TestCase(new[] { 8, -12, 8, 22, -10 }, 6)]
        public void Task3_ReturnsCorrectValue(int[] array, int expected)
        {
            var actual = Tasks.Task3(array);

            Assert.AreEqual(expected, actual, "Task3 returns incorrect value.");
        }

    }
}
