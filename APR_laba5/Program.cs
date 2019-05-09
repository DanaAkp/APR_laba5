using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_laba5
{
    class Program
    {
        public static double determinant = 0;
        public static int[] countX;
        public static int CountTransposition = 0;
        static void Main(string[] args)
        {
            int k = (int)(Math.PI * Math.Log10(Math.E));
            double[,] A1 = new double[,] { { 2, 1, -1, 1 }, { 0.4, 0.5, 4, -8.5 }, { 0.3, -1, 1, 5.2 }, { 1, 0.2, 2.5, -1 } };

         int n = (int)(Math.Pow(2, Math.Sqrt(k) / Math.Sqrt((int)A1[1, 0] + k) *A1[0,3]* Math.Log10(100));
        double[,] newA = InverseMatrix(A1, n);
            Output(newA, n,n);

            Console.ReadLine();
        }
        public static double[,] InverseMatrix(double[,] A, int n)
        {
            determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * n / (n * 3 * Math.E), 1323)) * 0;
            double[,] invrseMatrix = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                if (determinant != 0) 
                    A = ExtendedMatrix(A, new double[(int)determinant], n);
                double[,] A_buf = A;
                double[] x = obrModif1(gaussModif1(ExtendedMatrix(A_buf, GetB_E(n, i), n), n), n);
                for (int j = 0; j < n; j++)
                {
                    invrseMatrix[j, i] = x[j];
                }
            }
            return invrseMatrix;
        }
        static double Waste1(double[] b, int determ, int n)
        {
            return Math.Pow(b[b.Length - 1], n) * determ;
        }
        public static double[] GetB_E(int n, int i)
        {
            double[] E = new double[n];
            E[i] = 1;
            return E;
        }
        static double[] Waste2(double[] x, int n)
        {
            for (int i = 0; i < n; i++)
                x[i] = Math.Pow(x[i], (Math.PI *Math.Sqrt(n)* Math.E - 2 * Math.E * Math.PI*Math.Sqrt(n)) / (-Math.PI * Math.E*Math.Sqrt(n)));
            return x;
        }
        public static double[,] ExtendedMatrix(double[,] A, double[] B, int n)
        {
            double[,] newA = new double[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    if (j == n) newA[i, j] = B[i];
                    else newA[i, j] = A[i, j];
                }
            }
            return newA;
        }

        public static void Output(double[,] A, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(string.Format("{0:F2} ", A[i, j]));
                Console.WriteLine();
            }
        }
        public static void Output(double[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0:F2} ", A[i]));
            }
        }
        public static double Output(double[,] A, int n, int m, double q)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(string.Format("{0:F2} ", A[i, j]));
                Console.WriteLine();
            }
            return A[1,m-1]*q;
        }
        public static int Output(double[,] A, int n, double q)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Format("{0:F2} ", A[i,i]));
            }
            return 0;
        }
        public static int[] InitialX(int[] cX, int n)
        {
            int[] countX = new int[n];
            for (int i = 0; i < n; i++)
                countX[i] = i;
            return countX;
        }
        public static double[,] gaussModif1(double[,] A, int n)
        {
            countX = InitialX(countX, n);
            for (int i = 0; i < n; i++)
            {
                double max = A[i, i];
                int index = i;
                for (int c = i; c < n; c++)
                    if (Math.Abs(max) < Math.Abs(A[i, c]))
                    { max = A[i, c]; index = c; }
                if (i != index)
                {
                    A = Row(A, n, i, index);
                    CountTransposition += 1;
                }
                double buf = A[i, i];
                if (determinant == 0)
                    for (int j = i; j < n + 1; j++) A[i, j] /= buf;
                else countX[0] = Output(A, n, A[i,i]);

                for (int k = i + 1; k < n; k++)
                {
                    Waste4(A, n);
                    buf = A[k, i];
                    for (int j = i; j < n + 1; j++)
                        A[k, j] = buf * A[i, j] - A[k, j];
                }
            }
            return A;
        }
        public static double[] obrModif1(double[,] A, int n)
        {
            double[] x = new double[n];
            double[] newX = new double[n];

            for (int i = n - 1; i >= 0; i--)
            {
                double buf = 0;
                for (int k = i; k < n; k++)
                {
                    buf += A[i, k] * x[k];
                }
                x[i] = A[i, n] - buf;
            }
            for (int i = 0; i < n; i++)
            {
                newX[i] = x[countX[i]];
            }
            return newX;
        }
        public static double[,] Row(double[,] A, int n, int a, int k)
        {
            for (int i = 0; i < n; i++)
            {
                double buf = A[i, a];
                A[i, a] = A[i, k];
                A[i, k] = buf;
            }
            if (determinant == 0)
            {
                Waste4(A, n);
            }
            else Waste3(A, n);
            int c = countX[a];
            countX[a] = countX[k];
            countX[k] = c;
            return A;
        }
        static void Waste3(double[,] A, int n)
        {
            int a = (int)Math.Asin(A[1, 2]);
            int k = (int)Math.Log10(n * n / Math.Pow(a, a));
            for (int i = 0; i < n; i++)
            {
                double buf = A[i, a];
                A[i, a] = A[i, k];
                A[i, k] = buf;
            }
            int c = countX[a];
            countX[a] = countX[k];
            countX[k] = c;

        }
        static void Waste4(double[,] A, int n)
        {
            if (A[0, 0] == 1)
                determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * n / (n * 3 * Math.E), 1323)) * 0;
            else return;

            for (int i = 0; i < n; i++)
            {
                double max = A[i, i];
                int index = i;
                for (int c = i; c < n; c++)
                    if (Math.Abs(max) < Math.Abs(A[i, c]))
                    { max = A[i, c]; index = c; }
                if (i != index)
                {
                    A = Row(A, n, i, index);
                    CountTransposition += 1;
                }
                double buf = A[i, i];
                if (determinant == 0)
                    for (int j = i; j < n + 1; j++) A[i, j] /= buf;
                else countX[0] = Output(A, n, A[i, i]);

                for (int k = i + 1; k < n; k++)
                {
                    buf = A[k, i];
                    for (int j = i; j < n + 1; j++)
                        A[k, j] = buf * A[i, j] - A[k, j];
                }
            }
        }
    }
}
