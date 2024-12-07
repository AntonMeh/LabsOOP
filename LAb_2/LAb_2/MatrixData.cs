using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAb_2
{
    public partial class MyMatrix
    {
        private double[,] _matrix;
        private double? det = null;

        public MyMatrix(MyMatrix matrix)
        {
            int rows = matrix._matrix.GetLength(0);
            int cols = matrix._matrix.GetLength(1);
            _matrix = new double[rows, cols];
            Array.Copy(matrix._matrix, _matrix, matrix._matrix.Length);
        }
        public MyMatrix(double[,] other) => _matrix = (double[,])other.Clone();

        public bool IsRectangular(double[][] array)
        {
            bool res = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length != array[0].Length) {
                    res = false;
                    throw new ArgumentException("This matrix isn`t rectangular");
                    
                }
                    
            }
            return res;
        }
        public MyMatrix(double[][] otherJagged)
        {
            if (otherJagged.Length == 0 || otherJagged == null)
                throw new ArgumentException("Where is array? :(");

            if (IsRectangular(otherJagged))
            {
                int rows = otherJagged.GetLength(0);
                int cols = otherJagged[0].GetLength(0);

                _matrix = new double[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        _matrix[i, j] = otherJagged[i][j];
                    }
                }
            }
        }
        public bool IsRectangularStr(string[] arraySt)
        {
            for (int i = 1; i < arraySt.Length; i++)
            {
                if (arraySt[i].Split().Length != arraySt[0].Split().Length)
                    throw new ArgumentException("This array isn't rectangular");
            }
            return true;
        }
        public MyMatrix(string[] otherStr)
        {
            if (otherStr == null || otherStr.Length == 0)
                throw new ArgumentException("Where is array? :(");

            foreach (var str in otherStr)
            {
                if (str.Any(char.IsLetter))
                    throw new ArgumentException("Array must contain only numbers");
            }

            if (IsRectangularStr(otherStr))
            {
                int rows = otherStr.Length;
                int cols = otherStr[0].Split().Length; 

                _matrix = new double[rows, cols]; 

                for (int i = 0; i < rows; i++)
                {
                    int[] newArr = Array.ConvertAll(otherStr[i].Trim().Split(), int.Parse);
                    for (int j = 0; j < cols; j++)
                    {
                        _matrix[i, j] = newArr[j];
                    }
                }
            }
        }

        public MyMatrix(string other)
        {
            if (other.Length == 0 || other == null)
                throw new ArgumentException("Where is array? :(");

            string[] newStr = other.Split(new[] {"\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);

            string[][] matrixStr = new string[newStr.Length][];

            for (int i = 0; i < matrixStr.Length; i++)
            {
                matrixStr[i] = newStr[i].Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            }

            for(int i = 0;i < matrixStr.Length; i++)
            {
                if (matrixStr[i].Length != matrixStr[0].Length)
                {
                    throw new ArgumentException("Isn`t rectangular");
                }
            }

            int rows = matrixStr.Length;
            int columns = matrixStr[0].Length;

            _matrix = new double[rows, columns];
            for(int i = 0;i < rows;i++)
            {
                for(int j = 0;j < columns; j++)
                {
                    _matrix[i,j] = double.Parse(matrixStr[i][j]);
                }
            }
        }
        public int Height
        {
            get { return _matrix.GetLength(0); }
        }
        public int Width
        {
            get { return _matrix.GetLength(1); }
        }
        public int getHeight() =>  _matrix.GetLength(0); 

        public int getWidth() =>  _matrix.GetLength(1);
 
        public double GetEl(int row, int col) =>  _matrix[row, col];  
        
        public void SetEl(int row, int col, double element) => _matrix[row, col] = element;
   
        public double this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < Height) 
                {
                    if (j >= 0 && j < Width)
                        return _matrix[i, j];
                }
                return 0;
            }
            set {
                if (i > 0 && i < Height && j > 0 && j < Width)
                {
                    _matrix[i, j] = value;
                    det = null;
                }
            }
        }
        override public String ToString()
        {
            StringBuilder outputMatrix = new StringBuilder();
            for (int i = 0; i <  _matrix.GetLength(0); i++)
            {
                for(int j = 0;j < _matrix.GetLength(1); j++)
                {
                    outputMatrix.Append($"{_matrix[i,j]} \t");                    
                }
                outputMatrix.Append("\n");
            }
            return outputMatrix.ToString();
        }
    }
}
 