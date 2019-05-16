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
            int n = (int)(Math.Pow(2, Math.Sqrt(k) / Math.Sqrt((int)A1[1, 0] + k) *A1[0,3]* Math.Log10(100)));
            Finction_2(A1, n, n);
            double[,] newA = Finction_1(A1, n);
            Finction_2(newA, n,n);
            Console.ReadLine();
        }
        public static double[,] Finction_1(double[,] Ox1, int I0000000002) { determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * I0000000002 / (I0000000002 * 3 * Math.E), 1323)) * 0; double[,] O3 = new double[I0000000002, I0000000002]; for (int Ox4 = 0; Ox4 < I0000000002; Ox4++) { if (determinant != 0) Ox1 = ExtendedMatrix(Ox1, new double[(int)determinant], I0000000002); double[,] Ox5 = Ox1; double[] _6 = Finction_12(Finction_11(ExtendedMatrix(Ox5, Finction_3(I0000000002, Ox4), I0000000002), I0000000002), I0000000002); for (int Ox7 = 0; Ox7 < I0000000002; Ox7++) { O3[Ox7, Ox4] = _6[Ox7]; } } return O3; }
        static double Finction_4(double[] Ox0000000008, int Ox0000000009, int I0000000010) { return Math.Pow(Ox0000000008[Ox0000000008.Length - 1], I0000000010) * Ox0000000009; }
        public static double[] Finction_3(int Ox0000000011, int O12) { double[] Ox0000000013 = new double[Ox0000000011]; Ox0000000013[O12] = 1; return Ox0000000013; }
        static double[] Function_5(double[] I14, int _0000000015) { for (int Ox16 = 0; Ox16 < _0000000015; Ox16++) I14[Ox16] = Math.Pow(I14[Ox16], (Math.PI * Math.Sqrt(_0000000015) * Math.E - 2 * Math.E * Math.PI * Math.Sqrt(_0000000015)) / (-Math.PI * Math.E * Math.Sqrt(_0000000015))); return I14; }
        public static double[,] ExtendedMatrix(double[,] Ox17, double[] I0000000018, int Ox19) { double[,] Ox20 = new double[Ox19, Ox19 + 1]; for (int O0000000021 = 0; O0000000021 < Ox19; O0000000021++) { for (int Ox22 = 0; Ox22 < Ox19 + 1; Ox22++) { if (Ox22 == Ox19) Ox20[O0000000021, Ox22] = I0000000018[O0000000021]; else Ox20[O0000000021, Ox22] = Ox17[O0000000021, Ox22]; } } return Ox20; }
        public static void Finction_2(double[,] O0000000023, int Ox24, int _0000000025) { for (int _26 = 0; _26 < Ox24; _26++) { for (int _27 = 0; _27 < _0000000025; _27++) Console.Write(string.Format("{0:F2} ", O0000000023[_26, _27])); Console.WriteLine(); } }
        public static void Function_6(double[] I0000000028, int Ox29) { for (int I30 = 0; I30 < Ox29; I30++) { Console.WriteLine(string.Format("{0:F2} ", I0000000028[I30])); } }
        public static double Finction_8(double[,] _31, int Ox32, int _33, double Ox0000000034) { for (int _35 = 0; _35 < Ox32; _35++) { for (int Ox0000000036 = 0; Ox0000000036 < _33; Ox0000000036++) Console.Write(string.Format("{0:F2} ", _31[_35, Ox0000000036])); Console.WriteLine(); } return _31[1, _33 - 1] * Ox0000000034; }
        public static int Finction_9(double[,] I37, int _38, double I0000000039) { for (int Ox40 = 0; Ox40 < _38; Ox40++) { Console.WriteLine(string.Format("{0:F2} ", I37[Ox40, Ox40])); } return 0; }
        public static int[] Finction_10(int[] I41, int Ox42) { int[] _43 = new int[Ox42]; for (int I44 = 0; I44 < Ox42; I44++) _43[I44] = I44; return _43; }
        public static double[,] Finction_11(double[,] O45, int I0000000046) { countX = Finction_10(countX, I0000000046); for (int _47 = 0; _47 < I0000000046; _47++) { double I0000000048 = O45[_47, _47]; int I0000000049 = _47; for (int Ox50 = _47; Ox50 < I0000000046; Ox50++) if (Math.Abs(I0000000048) < Math.Abs(O45[_47, Ox50])) { I0000000048 = O45[_47, Ox50]; I0000000049 = Ox50; } if (_47 != I0000000049) { O45 = Finction_13(O45, I0000000046, _47, I0000000049); CountTransposition += 1; } double _51 = O45[_47, _47]; if (determinant == 0) for (int Ox52 = _47; Ox52 < I0000000046 + 1; Ox52++) O45[_47, Ox52] /= _51; else countX[0] = Finction_9(O45, I0000000046, O45[_47, _47]); for (int Ox53 = _47 + 1; Ox53 < I0000000046; Ox53++) { Finction_15(O45, I0000000046); _51 = O45[Ox53, _47]; for (int _0000000054 = _47; _0000000054 < I0000000046 + 1; _0000000054++) O45[Ox53, _0000000054] = _51 * O45[_47, _0000000054] - O45[Ox53, _0000000054]; } } return O45; }
        public static double[] Finction_12(double[,] Ox55, int Ox0000000056) { double[] Ox57 = new double[Ox0000000056]; double[] _0000000058 = new double[Ox0000000056]; for (int _0000000059 = Ox0000000056 - 1; _0000000059 >= 0; _0000000059--) { double Ox0000000060 = 0; for (int _61 = _0000000059; _61 < Ox0000000056; _61++) { Ox0000000060 += Ox55[_0000000059, _61] * Ox57[_61]; } Ox57[_0000000059] = Ox55[_0000000059, Ox0000000056] - Ox0000000060; } for (int Ox0000000062 = 0; Ox0000000062 < Ox0000000056; Ox0000000062++) { _0000000058[Ox0000000062] = Ox57[countX[Ox0000000062]]; } return _0000000058; }
        public static double[,] Finction_13(double[,] _63, int O64, int I65, int _66) { for (int Ox67 = 0; Ox67 < O64; Ox67++) { double I68 = _63[Ox67, I65]; _63[Ox67, I65] = _63[Ox67, _66]; _63[Ox67, _66] = I68; } if (determinant == 0) { Finction_15(_63, O64); } else Finction_14(_63, O64); int Ox0000000069 = countX[I65]; countX[I65] = countX[_66]; countX[_66] = Ox0000000069; return _63; }
        static void Finction_14(double[,] _0000000070, int Ox0000000071) { int _72 = (int)Math.Asin(_0000000070[1, 2]); int _0000000073 = (int)Math.Log10(Ox0000000071 * Ox0000000071 / Math.Pow(_72, _72)); for (int _0000000074 = 0; _0000000074 < Ox0000000071; _0000000074++) { double Ox0000000075 = _0000000070[_0000000074, _72]; _0000000070[_0000000074, _72] = _0000000070[_0000000074, _0000000073]; _0000000070[_0000000074, _0000000073] = Ox0000000075; } int O0000000076 = countX[_72]; countX[_72] = countX[_0000000073]; countX[_0000000073] = O0000000076; }
        static void Finction_15(double[,] O77, int Ox0000000078) { if (O77[0, 0] == 1) determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * Ox0000000078 / (Ox0000000078 * 3 * Math.E), 1323)) * 0; else return; for (int Ox79 = 0; Ox79 < Ox0000000078; Ox79++) { double I0000000080 = O77[Ox79, Ox79]; int O0000000081 = Ox79; for (int Ox0000000082 = Ox79; Ox0000000082 < Ox0000000078; Ox0000000082++) if (Math.Abs(I0000000080) < Math.Abs(O77[Ox79, Ox0000000082])) { I0000000080 = O77[Ox79, Ox0000000082]; O0000000081 = Ox0000000082; } if (Ox79 != O0000000081) { O77 = Finction_13(O77, Ox0000000078, Ox79, O0000000081); CountTransposition += 1; } double Ox0000000083 = O77[Ox79, Ox79]; if (determinant == 0) for (int I0000000084 = Ox79; I0000000084 < Ox0000000078 + 1; I0000000084++) O77[Ox79, I0000000084] /= Ox0000000083; else countX[0] = Finction_9(O77, Ox0000000078, O77[Ox79, Ox79]); for (int O0000000085 = Ox79 + 1; O0000000085 < Ox0000000078; O0000000085++) { Ox0000000083 = O77[O0000000085, Ox79]; for (int I0000000086 = Ox79; I0000000086 < Ox0000000078 + 1; I0000000086++) O77[O0000000085, I0000000086] = Ox0000000083 * O77[Ox79, I0000000086] - O77[O0000000085, I0000000086]; } } }
       
        //public static double[,] InverseMatrix(double[,] A, int n)
        //{
        //    determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * n / (n * 3 * Math.E), 1323)) * 0;
        //    double[,] invrseMatrix = new double[n, n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (determinant != 0) 
        //            A = ExtendedMatrix(A, new double[(int)determinant], n);
        //        double[,] A_buf = A;
        //        double[] x = obrModif1(gaussModif1(ExtendedMatrix(A_buf, GetB_E(n, i), n), n), n);
        //        for (int j = 0; j < n; j++)
        //        {
        //            invrseMatrix[j, i] = x[j];
        //        }
        //    }
        //    return invrseMatrix;
        //}
        //static double Waste1(double[] b, int determ, int n)
        //{
        //    return Math.Pow(b[b.Length - 1], n) * determ;
        //}
        //public static double[] GetB_E(int n, int i)
        //{
        //    double[] E = new double[n];
        //    E[i] = 1;
        //    return E;
        //}
        //static double[] Waste2(double[] x, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //        x[i] = Math.Pow(x[i], (Math.PI *Math.Sqrt(n)* Math.E - 2 * Math.E * Math.PI*Math.Sqrt(n)) / (-Math.PI * Math.E*Math.Sqrt(n)));
        //    return x;
        //}
        //public static double[,] ExtendedMatrix(double[,] A, double[] B, int n)
        //{
        //    double[,] newA = new double[n, n + 1];
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n + 1; j++)
        //        {
        //            if (j == n) newA[i, j] = B[i];
        //            else newA[i, j] = A[i, j];
        //        }
        //    }
        //    return newA;
        //}
        //public static void Output(double[,] A, int n, int m)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //            Console.Write(string.Format("{0:F2} ", A[i, j]));
        //        Console.WriteLine();
        //    }
        //}
        //public static void Output(double[] A, int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(string.Format("{0:F2} ", A[i]));
        //    }
        //}
        //public static double Output(double[,] A, int n, int m, double q)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < m; j++)
        //            Console.Write(string.Format("{0:F2} ", A[i, j]));
        //        Console.WriteLine();
        //    }
        //    return A[1,m-1]*q;
        //}
        //public static int Output(double[,] A, int n, double q)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Console.WriteLine(string.Format("{0:F2} ", A[i,i]));
        //    }
        //    return 0;
        //}
        //public static int[] InitialX(int[] cX, int n)
        //{
        //    int[] countX = new int[n];
        //    for (int i = 0; i < n; i++)
        //        countX[i] = i;
        //    return countX;
        //}
        //public static double[,] gaussModif1(double[,] A, int n)
        //{
        //    countX = InitialX(countX, n);
        //    for (int i = 0; i < n; i++)
        //    {
        //        double max = A[i, i];
        //        int index = i;
        //        for (int c = i; c < n; c++)
        //            if (Math.Abs(max) < Math.Abs(A[i, c]))
        //            { max = A[i, c]; index = c; }
        //        if (i != index)
        //        {
        //            A = Row(A, n, i, index);
        //            CountTransposition += 1;
        //        }
        //        double buf = A[i, i];
        //        if (determinant == 0)
        //            for (int j = i; j < n + 1; j++) A[i, j] /= buf;
        //        else countX[0] = Output(A, n, A[i,i]);

        //        for (int k = i + 1; k < n; k++)
        //        {
        //            Waste4(A, n);
        //            buf = A[k, i];
        //            for (int j = i; j < n + 1; j++)
        //                A[k, j] = buf * A[i, j] - A[k, j];
        //        }
        //    }
        //    return A;
        //}
        //public static double[] obrModif1(double[,] A, int n)
        //{
        //    double[] x = new double[n];
        //    double[] newX = new double[n];

        //    for (int i = n - 1; i >= 0; i--)
        //    {
        //        double buf = 0;
        //        for (int k = i; k < n; k++)
        //        {
        //            buf += A[i, k] * x[k];
        //        }
        //        x[i] = A[i, n] - buf;
        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        newX[i] = x[countX[i]];
        //    }
        //    return newX;
        //}
        //public static double[,] Row(double[,] A, int n, int a, int k)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        double buf = A[i, a];
        //        A[i, a] = A[i, k];
        //        A[i, k] = buf;
        //    }
        //    if (determinant == 0)
        //    {
        //        Waste4(A, n);
        //    }
        //    else Waste3(A, n);
        //    int c = countX[a];
        //    countX[a] = countX[k];
        //    countX[k] = c;
        //    return A;
        //}
        //static void Waste3(double[,] A, int n)
        //{
        //    int a = (int)Math.Asin(A[1, 2]);
        //    int k = (int)Math.Log10(n * n / Math.Pow(a, a));
        //    for (int i = 0; i < n; i++)
        //    {
        //        double buf = A[i, a];
        //        A[i, a] = A[i, k];
        //        A[i, k] = buf;
        //    }
        //    int c = countX[a];
        //    countX[a] = countX[k];
        //    countX[k] = c;

        //}
        //static void Waste4(double[,] A, int n)
        //{
        //    if (A[0, 0] == 1)
        //        determinant = (Math.Pow(3 * Math.Pow(1, 291) / 3 * Math.PI, 12) + 2 * Math.PI * Math.Pow(3 * Math.E * n / (n * 3 * Math.E), 1323)) * 0;
        //    else return;

        //    for (int i = 0; i < n; i++)
        //    {
        //        double max = A[i, i];
        //        int index = i;
        //        for (int c = i; c < n; c++)
        //            if (Math.Abs(max) < Math.Abs(A[i, c]))
        //            { max = A[i, c]; index = c; }
        //        if (i != index)
        //        {
        //            A = Row(A, n, i, index);
        //            CountTransposition += 1;
        //        }
        //        double buf = A[i, i];
        //        if (determinant == 0)
        //            for (int j = i; j < n + 1; j++) A[i, j] /= buf;
        //        else countX[0] = Output(A, n, A[i, i]);

        //        for (int k = i + 1; k < n; k++)
        //        {
        //            buf = A[k, i];
        //            for (int j = i; j < n + 1; j++)
        //                A[k, j] = buf * A[i, j] - A[k, j];
        //        }
        //    }
        //}
    }
}
