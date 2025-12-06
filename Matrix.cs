using System;

namespace MatrixProject
{
    public class Matrix
    {
        private int[,] data;
        private int rows;
        private int cols;
        private Random random = new Random();

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = random.Next(0, 11);
                }
            }
        }

        private Matrix(int[,] data)
        {
            this.rows = data.GetLength(0);
            this.cols = data.GetLength(1);
            this.data = data;
        }

        public int GetRows()
        {
            return rows;
        }

        public int GetCols()
        {
            return cols;
        }


        public int this[int i, int j]
        {
            get { 
                return data[i, j]; 
            }
            set { 
                data[i, j] = value; 
            }
        }

        public int Max()
        {
            int max = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] > max)
                    {
                        max = data[i, j];
                    }
                }
            }
            return max;
        }

        public int Min()
        {
            int min = data[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (data[i, j] < min)
                    {
                        min = data[i, j];
                    }
                }
            }
            return min;
        }

        public static Matrix operator *(Matrix m, int number)
        {
            int[,] result = new int[m.rows, m.cols];

            for (int i = 0; i < m.rows; i++)
            {
                for (int j = 0; j < m.cols; j++)
                {
                    result[i, j] = m.data[i, j] * number;
                }
            }

            return new Matrix(result);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.rows != 3 || m1.cols != 3 || m2.rows != 3 || m2.cols != 3)
            {
                throw new InvalidOperationException("Multiplication is only supported for 3x3 matrices!");
            }

            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] = result[i, j] + m1[i, k] * m2[k, j];
                    }
                }
            }

            return new Matrix(result);
        }

        
        public Matrix Transpose()
        {
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = data[i, j];
                }
            }

            return new Matrix(result);
        }

        
        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + "    ");

                }
                Console.WriteLine();
            }
        }

        public static Matrix FromArray(int[,] array)
        {
            return new Matrix(array);
        }
    }
}
