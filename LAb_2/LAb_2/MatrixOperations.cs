using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb_2
{
    partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1 == null || matrix2 == null)
                throw new ArgumentNullException();

            if(matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width)
                throw new ArgumentException("These matrixes aren`t equal");
        
            double[,] sumMatrix = new double[matrix1.Height, matrix1.Width];

            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix2.Height; j++)
                {
                    sumMatrix[i,j] = matrix1[i,j] + matrix2[i,j]; 
                }
            }
            return new MyMatrix(sumMatrix);
        }
        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1 == null || matrix2 == null)
                throw new ArgumentNullException();

            if (matrix1.Width != matrix2.Height )
                throw new ArgumentException("Multiplication is impossible");

            double[,] mulMatrix = new double[matrix1.Height, matrix2.Width];
                                
            for (int i = 0; i < matrix1.Height; i++)
            {
                for (int j = 0; j < matrix2.Width; j++)
                {
                    for(int k = 0; k < matrix2.Height; k++)
                    {
                        mulMatrix[i, j] = matrix1[i, k] * matrix2[k, j];
                    }

                }
            }
            return new MyMatrix(mulMatrix);
        }
        private double[,] GetTransponedArray()
        {
            double[,] transMatrix = new double[_matrix.GetLength(1), _matrix.GetLength(0)];

            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                for (int j = 0; j < _matrix.GetLength(0); j++)
                {
                    transMatrix[i,j] = _matrix[j,i];
                }
                
            }
            return transMatrix;
        }
        public MyMatrix GetTransponedCopy() =>  new MyMatrix(GetTransponedArray());
        
        public void TransponeMe() => _matrix = GetTransponedArray();

        public double? CalcDeterminant()
        {
            if (Height != Width)
            {
                throw new ArgumentException("This matrix isn`t square");
            }
            return CalculateDeterminant(_matrix);
        }
        public double CalculateDeterminant(double[,] matrix)
        {
            int n = matrix.GetLength(0);
           
            if (n == 1)  return matrix[0, 0];
            
            if (n == 2)  return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            double determinant = 0;
            for (int j = 0; j < n; j++)
            {
                determinant += Math.Pow(-1, j) * matrix[0, j] * CalculateDeterminant(GetMinor(matrix, 0, j));
            }
            return determinant;
        }

        private double[,] GetMinor(double[,] matrix, int rowToRemove, int colToRemove)
        {
            int n = matrix.GetLength(0);
            double[,] minor = new double[n - 1, n - 1];
            int minorRow = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == rowToRemove)
                    continue;
                int minorCol = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == colToRemove)
                        continue;
                    minor[minorRow, minorCol] = _matrix[i, j];
                    minorCol++;
                }
                minorRow++;
            }
            return minor;
        }
        public  string DetermineTheMatrixType()
        {
            bool isSquare = false;
            if (Height == Width)
            {
                Console.WriteLine("Square Matrix"); 
                isSquare = true;
            }

            else if (Height == 0 && Width == 1)
                Console.WriteLine("Column Matrix ");

            else if (Height == 1 && Width == 0)
                Console.WriteLine("Row Matrix ");

            else if (Height < Width)
                Console.WriteLine("Horizontal Matrix ");

            else if (Height > Width)
                Console.WriteLine("Vertical Matrix ");

            bool isZeroMatrix = true;
            bool isDiagonal = true;
            bool isIdentity = true;
            bool isSymmetric = true;
            bool isSkewSymmetric = true;
            bool isUpperTriangular = true;
            bool isLowerTriangular = true;
            for (int i =0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (_matrix[i, j] != 0) isZeroMatrix = false;

                    if (isSquare)
                    {
                        if (i != j && _matrix[i, j] != 0) isDiagonal = false;

                        if (i == j && _matrix[i, j] != 1) isIdentity = false;

                        if (_matrix[i, j] != _matrix[j, i]) isSymmetric = false;

                        if (_matrix[i, j] != -_matrix[j, i]) isSkewSymmetric = false;

                        if (i > j && _matrix[i, j] != 0) isUpperTriangular = false;

                        if (i < j && _matrix[i, j] != 0) isLowerTriangular = false;
                    }
                }
            }
            if (isZeroMatrix) return "Zero Matrix";
            if (!isSquare) return "Not a Square Matrix";
            if (isIdentity) return "Identity Matrix";
            if (isDiagonal) return "Diagonal Matrix";
            if (isSymmetric) return "Symmetric Matrix";
            if (isSkewSymmetric) return "Skew-Symmetric Matrix";
            if (isUpperTriangular) return "Upper Triangular Matrix";
            if (isLowerTriangular) return "Lower Triangular Matrix";

            return "";
        }
    }
    
}
