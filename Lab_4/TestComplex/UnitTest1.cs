using Lab_4;
namespace TestComplex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_ShouldReduceFraction()
        {
            var fraction = new MyFrac(4, 8);

            Assert.AreEqual("1/2", fraction.ToString());
        }

        [TestMethod]
        public void Constructor_ZeroDenominator_ShouldThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new MyFrac(1, 0));
        }

        [TestMethod]
        public void Add_TwoFractions_ShouldReturnCorrectResult()
        {
            var frac1 = new MyFrac(1, 2);
            var frac2 = new MyFrac(1, 3);

            var result = frac1.Add(frac2);

            Assert.AreEqual("5/6", result.ToString());
        }

        [TestMethod]
        public void Subtract_TwoFractions_ShouldReturnCorrectResult()
        {
            var frac1 = new MyFrac(1, 2);
            var frac2 = new MyFrac(1, 3);

            var result = frac1.Subtract(frac2);

            Assert.AreEqual("1/6", result.ToString());
        }

        [TestMethod]
        public void Multiply_TwoFractions_ShouldReturnCorrectResult()
        {
            var frac1 = new MyFrac(2, 3);
            var frac2 = new MyFrac(3, 4);

            var result = frac1.Multiply(frac2);

            Assert.AreEqual("1/2", result.ToString());
        }

        [TestMethod]
        public void Divide_TwoFractions_ShouldReturnCorrectResult()
        {
            var frac1 = new MyFrac(2, 3);
            var frac2 = new MyFrac(3, 4);

            var result = frac1.Divide(frac2);

            Assert.AreEqual("8/9", result.ToString());
        }

        [TestMethod]
        public void Divide_ByZeroFraction_ShouldThrowArgumentException()
        {
            var frac1 = new MyFrac(1, 2);
            var frac2 = new MyFrac(0, 1);

            Assert.ThrowsException<ArgumentException>(() => frac1.Divide(frac2));
        }

        [TestMethod]
        public void CompareTo_EqualFractions_ShouldReturnZero()
        {
            var frac1 = new MyFrac(2, 4);
            var frac2 = new MyFrac(1, 2);

            var result = frac1.CompareTo(frac2);

            Assert.AreEqual(0, result);
        }
    }
}