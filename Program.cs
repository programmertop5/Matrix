using System;
namespace MatrixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Creating 3x3 matrices--------------");
            Matrix m1 = new Matrix(3, 3);
            Console.WriteLine("----------\nMatrix 1:-------------");
            m1.Print();
            Matrix m2 = new Matrix(3, 3);
            Console.WriteLine("\n--------Matrix 2:-------------");
            m2.Print();
            Console.WriteLine("\n----------Maximum and Minimum--------");
            Console.WriteLine($"--------Maximum of Matrix 1: {m1.Max()}---------");
            Console.WriteLine($"--------Minimum of Matrix 1: {m1.Min()}--------");
            Console.WriteLine("\n------Multiplying matrix by number------");
            Matrix m3 = m1 * 3;
            Console.WriteLine("\n-----Matrix 1 * 3:-------");
            m3.Print();
            Console.WriteLine("\n------ Multiplying matrix by matrix ----");
            Matrix m4 = m1 * m2;
            Console.WriteLine("\n----Matrix 1 * Matrix 2:-----");
            m4.Print();
            Console.WriteLine("\n----- Transposition-----");
            Matrix m5 = m1.Transpose();
            Console.WriteLine("\n-----Transposed Matrix 1:----");
            m5.Print();

            Console.WriteLine("\n-------Example from image--------");
            Matrix a = Matrix.FromArray(new int[,] {
                {3, 12, 4},
                {5, 6, 8},
                {1, 0, 2}
            });
            Console.WriteLine("\n-----Matrix A:------");
            a.Print();
            Matrix b = Matrix.FromArray(new int[,] {
                {7, 3, 8},
                {11, 9, 5},
                {6, 8, 4}
            });
            Console.WriteLine("\n----Matrix B:----");
            b.Print();
            Matrix result = a * b;
            Console.WriteLine("\n---Result A * B:----");
            result.Print();
            
            Console.WriteLine("\n------Transposition example--------");
            Matrix testMatrix = Matrix.FromArray(new int[,] {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            });
            Console.WriteLine("\n-----Original matrix:-----");
            testMatrix.Print();
            Matrix transposed = testMatrix.Transpose();
            Console.WriteLine("\n-----Transposed matrix:-------");
            transposed.Print();
        }
    }
}
