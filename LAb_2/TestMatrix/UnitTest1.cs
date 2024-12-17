using LAb_2;
namespace TestMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_WithDoubleArray_CreatesCorrectMatrix()
        {
            double[,] data = { { 1.0, 2.0 }, { 3.0, 4.0 } };
            MyMatrix matrix = new MyMatrix(data);

            Assert.AreEqual(2, matrix.Height);
            Assert.AreEqual(2, matrix.Width);
            Assert.AreEqual(1.0, matrix.GetEl(0, 0));
            Assert.AreEqual(4.0, matrix.GetEl(1, 1));
        }

        [TestMethod]
        public void Constructor_WithJaggedArray_CreatesCorrectMatrix()
        {
            double[][] data =
            {
                new double[] { 1.0, 2.0 },
                new double[] { 3.0, 4.0 }
            };
            MyMatrix matrix = new MyMatrix(data);

            Assert.AreEqual(2, matrix.Height);
            Assert.AreEqual(2, matrix.Width);
            Assert.AreEqual(1.0, matrix.GetEl(0, 0));
            Assert.AreEqual(4.0, matrix.GetEl(1, 1));
        }

        [TestMethod]
        public void Constructor_WithNonRectangularJaggedArray_ThrowsException()
        {
            double[][] data =
            {
                new double[] { 1.0, 2.0 },
                new double[] { 3.0 }
            };

            Assert.ThrowsException<ArgumentException>(() => new MyMatrix(data));
        }

        [TestMethod]
        public void Constructor_WithStringArray_CreatesCorrectMatrix()
        {
            string[] data = { "1 2", "3 4" };
            MyMatrix matrix = new MyMatrix(data);

            Assert.AreEqual(2, matrix.Height);
            Assert.AreEqual(2, matrix.Width);
            Assert.AreEqual(1.0, matrix.GetEl(0, 0));
            Assert.AreEqual(4.0, matrix.GetEl(1, 1));
        }

        [TestMethod]
        public void Constructor_WithString_ThrowsExceptionForInvalidData()
        {
            string invalidMatrix = "1 a\n3 4";
            Assert.ThrowsException<FormatException>(() => new MyMatrix(invalidMatrix));
        }

        [TestMethod]
        public void SetEl_SetsCorrectElement()
        {
            double[,] data = { { 1.0, 2.0 }, { 3.0, 4.0 } };
            MyMatrix matrix = new MyMatrix(data);

            matrix.SetEl(0, 1, 5.0);
            Assert.AreEqual(5.0, matrix.GetEl(0, 1));
        }

        [TestMethod]
        public void GetEl_GetsCorrectElement()
        {
            double[,] data = { { 1.0, 2.0 }, { 3.0, 4.0 } };
            MyMatrix matrix = new MyMatrix(data);

            Assert.AreEqual(2.0, matrix.GetEl(0, 1));
        }

        [TestMethod]
        public void ToString_ReturnsCorrectRepresentation()
        {
            double[,] data = { { 1.0, 2.0 }, { 3.0, 4.0 } };
            MyMatrix matrix = new MyMatrix(data);

            string expectedOutput = "1 \t2 \t\n3 \t4 \t\n";
            Assert.AreEqual(expectedOutput, matrix.ToString());
        }
        [TestMethod]
        public void Operator_Addition_ValidMatrices_ShouldReturnCorrectSum()
        {
            string[] matrix1Data = { "1 2", "3 4" };
            string[] matrix2Data = { "5 6", "7 8" };
            var matrix1 = new MyMatrix(matrix1Data);
            var matrix2 = new MyMatrix(matrix2Data);

            var result = matrix1 + matrix2;

            Assert.AreEqual(6, result[0, 0]);
            Assert.AreEqual(8, result[0, 1]);
            Assert.AreEqual(10, result[1, 0]);
            Assert.AreEqual(12, result[1, 1]);
        }

        [TestMethod]
        public void Operator_Addition_InvalidMatrices_ShouldThrowException()
        {
            string[] matrix1Data = { "1 2", "3 4" };
            string[] matrix2Data = { "1 2 3", "4 5 6" };
            var matrix1 = new MyMatrix(matrix1Data);
            var matrix2 = new MyMatrix(matrix2Data);

            Assert.ThrowsException<ArgumentException>(() => _ = matrix1 + matrix2);
        }

        [TestMethod]
        public void Operator_Multiplication_InvalidMatrices_ShouldThrowException()
        {
            string[] matrix1Data = { "1 2 3", "4 5 6" };
            string[] matrix2Data = { "1 2", "3 4" };
            var matrix1 = new MyMatrix(matrix1Data);
            var matrix2 = new MyMatrix(matrix2Data);

            Assert.ThrowsException<ArgumentException>(() => _ = matrix1 * matrix2);
        }

        [TestMethod]
        public void GetTransponedCopy_ShouldReturnCorrectTransposedMatrix()
        {
            string[] matrixData = { "1 2", "3 4", "5 6" };
            var matrix = new MyMatrix(matrixData);

            var transposed = matrix.GetTransponedCopy();

            Assert.AreEqual(2, transposed.Height);
            Assert.AreEqual(3, transposed.Width);
            Assert.AreEqual(1, transposed[0, 0]);
            Assert.AreEqual(3, transposed[0, 1]);
            Assert.AreEqual(5, transposed[0, 2]);
            Assert.AreEqual(2, transposed[1, 0]);
            Assert.AreEqual(4, transposed[1, 1]);
            Assert.AreEqual(6, transposed[1, 2]);
        }

        [TestMethod]
        public void TransponeMe_ShouldModifyMatrixCorrectly()
        {
            string[] matrixData = { "1 2", "3 4", "5 6" };
            var matrix = new MyMatrix(matrixData);

            matrix.TransponeMe();

            Assert.AreEqual(2, matrix.Height);
            Assert.AreEqual(3, matrix.Width);
            Assert.AreEqual(1, matrix[0, 0]);
            Assert.AreEqual(3, matrix[0, 1]);
            Assert.AreEqual(5, matrix[0, 2]);
            Assert.AreEqual(2, matrix[1, 0]);
            Assert.AreEqual(4, matrix[1, 1]);
            Assert.AreEqual(6, matrix[1, 2]);
        }

        [TestMethod]
        public void CalcDeterminant_ValidSquareMatrix_ShouldReturnCorrectValue()
        {
            string[] matrixData = { "1 2", "3 4" };
            var matrix = new MyMatrix(matrixData);

            var determinant = matrix.CalcDeterminant();

            Assert.AreEqual(-2, determinant);
        }

        [TestMethod]
        public void CalcDeterminant_NonSquareMatrix_ShouldThrowException()
        {
            string[] matrixData = { "1 2", "3 4", "5 6" };
            var matrix = new MyMatrix(matrixData);

            
            Assert.ThrowsException<ArgumentException>(() => _ = matrix.CalcDeterminant());
        }

        [TestMethod]
        public void CalcDeterminant_LargeSquareMatrix_ShouldReturnCorrectValue()
        {
            string[] matrixData = { "6 1 1", "4 -2 5", "2 8 7" };
            var matrix = new MyMatrix(matrixData);

            var determinant = matrix.CalcDeterminant();

            Assert.AreEqual(-306, determinant); 
        }
    }
}