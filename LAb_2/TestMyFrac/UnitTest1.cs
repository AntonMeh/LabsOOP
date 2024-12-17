using LAb_2;
namespace TestMyFrac
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_ZeroDenom_ShouldThrowArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() => new MyFracClass(3,0) , "Знаменник не може дорівнювати нулю.");
        }
        [TestMethod]
        public void Test_ToString_ReturnsCorrectFormat()
        {
            MyFracClass test = new MyFracClass(3,3);
            string testString = test.ToString();
            Assert.AreEqual("1/1", testString);
        }
        [TestMethod]
        public void Test_Reduce_ShouldReturnCorrectFrac()
        {
            var test = new MyFracClass(11,110);
            Assert.AreEqual(1,test.Nom);
            Assert.AreEqual(10,test.Denom);
        }
        [TestMethod]
        public void Constructor_WithNegativeDenominator_SetsNomAndDenomCorrectly()
        {
            var test = new MyFracClass(12,-13);
            Assert.AreEqual(-12,test.Nom);
            Assert.AreEqual(13,test.Denom);
        }
        [TestMethod]
        public void DoubleValue_ReturnsCorrectDoubleRepresentation()
        {
            var test = new MyFracClass(1, 2);
            Assert.AreEqual(0.5, MyFracClass.DoubleValue(test), 1e-9);
        }
        [TestMethod]
        public void Plus_AddsTwoFractions_Correctly()
        {
            var f1 = new MyFracClass(13,14);
            var f2 = new MyFracClass(12,20);
            var res = MyFracClass.Plus(f1, f2);
            Assert.AreEqual("107/70", res.ToString());
        }
        [TestMethod]
        public void Minus_DividesTwoFractions_Correctly()
        {
            var f1 = new MyFracClass(9, 14);
            var f2 = new MyFracClass(2, 13);
            var res = MyFracClass.Minus(f1, f2);
            Assert.AreEqual("89/182", res.ToString());
        }
        [TestMethod]
        public void Multiply_MultipliesTwoFractions_Correctly()
        {
            var f1 = new MyFracClass(3, 27);
            var f2 = new MyFracClass(9, 18);
            var res = MyFracClass.Multiply(f1, f2);
            Assert.AreEqual("1/18", res.ToString());
        }
        [TestMethod]
        public void Divide_DividesTwoFractions_Correctly()
        {
            var f1 = new MyFracClass(16, 23);
            var f2 = new MyFracClass(13, 53);
            var res = MyFracClass.Divide(f1, f2);
            Assert.AreEqual("848/299", res.ToString());
        }
        [TestMethod]
        public void CalcExpr1_ComputesExpressionCorrectly()
        {
            var result = MyFracClass.CalcExpr1(3);
            Assert.AreEqual("3/4", result.ToString());
        }
        [TestMethod]
        public void CalcExpr2_ComputesExpressionCorrectly()
        {
            var result = MyFracClass.CalcExpr2(2);
            Assert.AreEqual("0/1", result.ToString());
        }
    }
}