using OpenBLAS;
using System;
using System.Runtime.InteropServices;

namespace BasicExample
{
    public enum BlasOp : sbyte
    {
        /// <summary>
        /// The non IntTranspose
        /// </summary>
        NonTranspose = (sbyte)'n',
        /// <summary>
        /// The IntTranspose
        /// </summary>
        Transpose = (sbyte)'t',
        /// <summary>
        /// The conjugate IntTranspose
        /// </summary>
        ConjugateTranspose = (sbyte)'c',
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num_threads = 2;

            BLAS.OpenblasSetNumThreads(ref num_threads);

            float[,] a = new float[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            float[,] b = new float[,] { { 2, 2, 2}, { 3, 3, 3 } };
            var c = Dot(a, b, 1, 0);

            Console.ReadLine();
        }

        static Array Dot(float[,] a, float[,] b, float alpha, float beta)
        {
            unsafe
            {
                int m = 2;
                int k = 3;
                int n = 2;
                int lda = 2;
                int ldb = 3;
                int ldc = 2;
                float[,] c = new float[m, n];

                sbyte nta = (sbyte)BlasOp.NonTranspose;
                
                BLAS.Sgemm(&nta, &nta, ref m, ref n, ref k, ref alpha, ref a[0, 0], ref lda, ref b[0, 0], ref ldb, ref beta, ref c[0, 0], ref ldc);

                return c;
            }
            
        }
    }
}
