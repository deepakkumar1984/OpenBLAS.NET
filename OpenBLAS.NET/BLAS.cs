using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenBLAS
{
    public unsafe partial class BLAS
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xerbla_")]
            internal static extern int Xerbla(sbyte* _0, int* info, int _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "openblas_set_num_threads_")]
            internal static extern void OpenblasSetNumThreads(int* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sdot_")]
            internal static extern float Sdot(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sdsdot_")]
            internal static extern float Sdsdot(int* _0, float* _1, float* _2, int* _3, float* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsdot_")]
            internal static extern double Dsdot(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ddot_")]
            internal static extern double Ddot(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qdot_")]
            internal static extern double Qdot(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cdotu_")]
            internal static extern global::OpenBLAS.ComplexFloat.__Internal Cdotu(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cdotc_")]
            internal static extern global::OpenBLAS.ComplexFloat.__Internal Cdotc(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zdotu_")]
            internal static extern void Zdotu(global::System.IntPtr @return, int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zdotc_")]
            internal static extern void Zdotc(global::System.IntPtr @return, int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xdotu_")]
            internal static extern void Xdotu(global::System.IntPtr @return, int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xdotc_")]
            internal static extern void Xdotc(global::System.IntPtr @return, int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "saxpy_")]
            internal static extern void Saxpy(int* _0, float* _1, float* _2, int* _3, float* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "daxpy_")]
            internal static extern void Daxpy(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qaxpy_")]
            internal static extern void Qaxpy(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "caxpy_")]
            internal static extern void Caxpy(int* _0, float* _1, float* _2, int* _3, float* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zaxpy_")]
            internal static extern void Zaxpy(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xaxpy_")]
            internal static extern void Xaxpy(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "caxpyc_")]
            internal static extern void Caxpyc(int* _0, float* _1, float* _2, int* _3, float* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zaxpyc_")]
            internal static extern void Zaxpyc(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xaxpyc_")]
            internal static extern void Xaxpyc(int* _0, double* _1, double* _2, int* _3, double* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scopy_")]
            internal static extern void Scopy(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dcopy_")]
            internal static extern void Dcopy(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qcopy_")]
            internal static extern void Qcopy(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ccopy_")]
            internal static extern void Ccopy(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zcopy_")]
            internal static extern void Zcopy(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xcopy_")]
            internal static extern void Xcopy(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sswap_")]
            internal static extern void Sswap(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dswap_")]
            internal static extern void Dswap(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qswap_")]
            internal static extern void Qswap(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cswap_")]
            internal static extern void Cswap(int* _0, float* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zswap_")]
            internal static extern void Zswap(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xswap_")]
            internal static extern void Xswap(int* _0, double* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sasum_")]
            internal static extern float Sasum(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scasum_")]
            internal static extern float Scasum(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dasum_")]
            internal static extern double Dasum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qasum_")]
            internal static extern double Qasum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzasum_")]
            internal static extern double Dzasum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxasum_")]
            internal static extern double Qxasum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssum_")]
            internal static extern float Ssum(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scsum_")]
            internal static extern float Scsum(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsum_")]
            internal static extern double Dsum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsum_")]
            internal static extern double Qsum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzsum_")]
            internal static extern double Dzsum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxsum_")]
            internal static extern double Qxsum(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "isamax_")]
            internal static extern int Isamax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "idamax_")]
            internal static extern int Idamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "iqamax_")]
            internal static extern int Iqamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "icamax_")]
            internal static extern int Icamax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "izamax_")]
            internal static extern int Izamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ixamax_")]
            internal static extern int Ixamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ismax_")]
            internal static extern int Ismax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "idmax_")]
            internal static extern int Idmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "iqmax_")]
            internal static extern int Iqmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "icmax_")]
            internal static extern int Icmax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "izmax_")]
            internal static extern int Izmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ixmax_")]
            internal static extern int Ixmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "isamin_")]
            internal static extern int Isamin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "idamin_")]
            internal static extern int Idamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "iqamin_")]
            internal static extern int Iqamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "icamin_")]
            internal static extern int Icamin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "izamin_")]
            internal static extern int Izamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ixamin_")]
            internal static extern int Ixamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ismin_")]
            internal static extern int Ismin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "idmin_")]
            internal static extern int Idmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "iqmin_")]
            internal static extern int Iqmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "icmin_")]
            internal static extern int Icmin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "izmin_")]
            internal static extern int Izmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ixmin_")]
            internal static extern int Ixmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "samax_")]
            internal static extern float Samax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "damax_")]
            internal static extern double Damax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qamax_")]
            internal static extern double Qamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scamax_")]
            internal static extern float Scamax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzamax_")]
            internal static extern double Dzamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxamax_")]
            internal static extern double Qxamax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "samin_")]
            internal static extern float Samin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "damin_")]
            internal static extern double Damin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qamin_")]
            internal static extern double Qamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scamin_")]
            internal static extern float Scamin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzamin_")]
            internal static extern double Dzamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxamin_")]
            internal static extern double Qxamin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "smax_")]
            internal static extern float Smax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dmax_")]
            internal static extern double Dmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qmax_")]
            internal static extern double Qmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scmax_")]
            internal static extern float Scmax(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzmax_")]
            internal static extern double Dzmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxmax_")]
            internal static extern double Qxmax(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "smin_")]
            internal static extern float Smin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dmin_")]
            internal static extern double Dmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qmin_")]
            internal static extern double Qmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scmin_")]
            internal static extern float Scmin(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dzmin_")]
            internal static extern double Dzmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxmin_")]
            internal static extern double Qxmin(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sscal_")]
            internal static extern void Sscal(int* _0, float* _1, float* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dscal_")]
            internal static extern void Dscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qscal_")]
            internal static extern void Qscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cscal_")]
            internal static extern void Cscal(int* _0, float* _1, float* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zscal_")]
            internal static extern void Zscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xscal_")]
            internal static extern void Xscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csscal_")]
            internal static extern void Csscal(int* _0, float* _1, float* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zdscal_")]
            internal static extern void Zdscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xqscal_")]
            internal static extern void Xqscal(int* _0, double* _1, double* _2, int* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "snrm2_")]
            internal static extern float Snrm2(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "scnrm2_")]
            internal static extern float Scnrm2(int* _0, float* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dnrm2_")]
            internal static extern double Dnrm2(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qnrm2_")]
            internal static extern double Qnrm2(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dznrm2_")]
            internal static extern double Dznrm2(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qxnrm2_")]
            internal static extern double Qxnrm2(int* _0, double* _1, int* _2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "srot_")]
            internal static extern void Srot(int* _0, float* _1, int* _2, float* _3, int* _4, float* _5, float* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "drot_")]
            internal static extern void Drot(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5, double* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qrot_")]
            internal static extern void Qrot(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5, double* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csrot_")]
            internal static extern void Csrot(int* _0, float* _1, int* _2, float* _3, int* _4, float* _5, float* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zdrot_")]
            internal static extern void Zdrot(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5, double* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xqrot_")]
            internal static extern void Xqrot(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5, double* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "srotg_")]
            internal static extern void Srotg(float* _0, float* _1, float* _2, float* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "drotg_")]
            internal static extern void Drotg(double* _0, double* _1, double* _2, double* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qrotg_")]
            internal static extern void Qrotg(double* _0, double* _1, double* _2, double* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "crotg_")]
            internal static extern void Crotg(float* _0, float* _1, float* _2, float* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zrotg_")]
            internal static extern void Zrotg(double* _0, double* _1, double* _2, double* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xrotg_")]
            internal static extern void Xrotg(double* _0, double* _1, double* _2, double* _3);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "srotmg_")]
            internal static extern void Srotmg(float* _0, float* _1, float* _2, float* _3, float* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "drotmg_")]
            internal static extern void Drotmg(double* _0, double* _1, double* _2, double* _3, double* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "srotm_")]
            internal static extern void Srotm(int* _0, float* _1, int* _2, float* _3, int* _4, float* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "drotm_")]
            internal static extern void Drotm(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qrotm_")]
            internal static extern void Qrotm(int* _0, double* _1, int* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sger_")]
            internal static extern void Sger(int* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dger_")]
            internal static extern void Dger(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qger_")]
            internal static extern void Qger(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgeru_")]
            internal static extern void Cgeru(int* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgerc_")]
            internal static extern void Cgerc(int* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgeru_")]
            internal static extern void Zgeru(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgerc_")]
            internal static extern void Zgerc(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgeru_")]
            internal static extern void Xgeru(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgerc_")]
            internal static extern void Xgerc(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgemv_")]
            internal static extern void Sgemv(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7, float* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgemv_")]
            internal static extern void Dgemv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgemv_")]
            internal static extern void Qgemv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgemv_")]
            internal static extern void Cgemv(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7, float* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgemv_")]
            internal static extern void Zgemv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgemv_")]
            internal static extern void Xgemv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strsv_")]
            internal static extern void Strsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrsv_")]
            internal static extern void Dtrsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrsv_")]
            internal static extern void Qtrsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrsv_")]
            internal static extern void Ctrsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrsv_")]
            internal static extern void Ztrsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrsv_")]
            internal static extern void Xtrsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strmv_")]
            internal static extern void Strmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrmv_")]
            internal static extern void Dtrmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrmv_")]
            internal static extern void Qtrmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrmv_")]
            internal static extern void Ctrmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrmv_")]
            internal static extern void Ztrmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrmv_")]
            internal static extern void Xtrmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "stpsv_")]
            internal static extern void Stpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtpsv_")]
            internal static extern void Dtpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtpsv_")]
            internal static extern void Qtpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctpsv_")]
            internal static extern void Ctpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztpsv_")]
            internal static extern void Ztpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtpsv_")]
            internal static extern void Xtpsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "stpmv_")]
            internal static extern void Stpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtpmv_")]
            internal static extern void Dtpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtpmv_")]
            internal static extern void Qtpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctpmv_")]
            internal static extern void Ctpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztpmv_")]
            internal static extern void Ztpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtpmv_")]
            internal static extern void Xtpmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "stbmv_")]
            internal static extern void Stbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtbmv_")]
            internal static extern void Dtbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtbmv_")]
            internal static extern void Qtbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctbmv_")]
            internal static extern void Ctbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztbmv_")]
            internal static extern void Ztbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtbmv_")]
            internal static extern void Xtbmv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "stbsv_")]
            internal static extern void Stbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtbsv_")]
            internal static extern void Dtbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtbsv_")]
            internal static extern void Qtbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctbsv_")]
            internal static extern void Ctbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztbsv_")]
            internal static extern void Ztbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtbsv_")]
            internal static extern void Xtbsv(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssymv_")]
            internal static extern void Ssymv(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsymv_")]
            internal static extern void Dsymv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsymv_")]
            internal static extern void Qsymv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csymv_")]
            internal static extern void Csymv(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsymv_")]
            internal static extern void Zsymv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsymv_")]
            internal static extern void Xsymv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sspmv_")]
            internal static extern void Sspmv(sbyte* _0, int* _1, float* _2, float* _3, float* _4, int* _5, float* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dspmv_")]
            internal static extern void Dspmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qspmv_")]
            internal static extern void Qspmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cspmv_")]
            internal static extern void Cspmv(sbyte* _0, int* _1, float* _2, float* _3, float* _4, int* _5, float* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zspmv_")]
            internal static extern void Zspmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xspmv_")]
            internal static extern void Xspmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssyr_")]
            internal static extern void Ssyr(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsyr_")]
            internal static extern void Dsyr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsyr_")]
            internal static extern void Qsyr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csyr_")]
            internal static extern void Csyr(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsyr_")]
            internal static extern void Zsyr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsyr_")]
            internal static extern void Xsyr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssyr2_")]
            internal static extern void Ssyr2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsyr2_")]
            internal static extern void Dsyr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsyr2_")]
            internal static extern void Qsyr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csyr2_")]
            internal static extern void Csyr2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsyr2_")]
            internal static extern void Zsyr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsyr2_")]
            internal static extern void Xsyr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sspr_")]
            internal static extern void Sspr(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dspr_")]
            internal static extern void Dspr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qspr_")]
            internal static extern void Qspr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cspr_")]
            internal static extern void Cspr(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zspr_")]
            internal static extern void Zspr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xspr_")]
            internal static extern void Xspr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sspr2_")]
            internal static extern void Sspr2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dspr2_")]
            internal static extern void Dspr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qspr2_")]
            internal static extern void Qspr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cspr2_")]
            internal static extern void Cspr2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zspr2_")]
            internal static extern void Zspr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xspr2_")]
            internal static extern void Xspr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cher_")]
            internal static extern void Cher(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zher_")]
            internal static extern void Zher(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xher_")]
            internal static extern void Xher(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chpr_")]
            internal static extern void Chpr(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhpr_")]
            internal static extern void Zhpr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhpr_")]
            internal static extern void Xhpr(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cher2_")]
            internal static extern void Cher2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zher2_")]
            internal static extern void Zher2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xher2_")]
            internal static extern void Xher2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chpr2_")]
            internal static extern void Chpr2(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhpr2_")]
            internal static extern void Zhpr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhpr2_")]
            internal static extern void Xhpr2(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chemv_")]
            internal static extern void Chemv(sbyte* _0, int* _1, float* _2, float* _3, int* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhemv_")]
            internal static extern void Zhemv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhemv_")]
            internal static extern void Xhemv(sbyte* _0, int* _1, double* _2, double* _3, int* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chpmv_")]
            internal static extern void Chpmv(sbyte* _0, int* _1, float* _2, float* _3, float* _4, int* _5, float* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhpmv_")]
            internal static extern void Zhpmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhpmv_")]
            internal static extern void Xhpmv(sbyte* _0, int* _1, double* _2, double* _3, double* _4, int* _5, double* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "snorm_")]
            internal static extern int Snorm(sbyte* _0, int* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dnorm_")]
            internal static extern int Dnorm(sbyte* _0, int* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cnorm_")]
            internal static extern int Cnorm(sbyte* _0, int* _1, int* _2, float* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "znorm_")]
            internal static extern int Znorm(sbyte* _0, int* _1, int* _2, double* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgbmv_")]
            internal static extern void Sgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgbmv_")]
            internal static extern void Dgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgbmv_")]
            internal static extern void Qgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgbmv_")]
            internal static extern void Cgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgbmv_")]
            internal static extern void Zgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgbmv_")]
            internal static extern void Xgbmv(sbyte* _0, int* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssbmv_")]
            internal static extern void Ssbmv(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7, float* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsbmv_")]
            internal static extern void Dsbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsbmv_")]
            internal static extern void Qsbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csbmv_")]
            internal static extern void Csbmv(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7, float* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsbmv_")]
            internal static extern void Zsbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsbmv_")]
            internal static extern void Xsbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chbmv_")]
            internal static extern void Chbmv(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7, float* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhbmv_")]
            internal static extern void Zhbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhbmv_")]
            internal static extern void Xhbmv(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7, double* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgemm_")]
            internal static extern void Sgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgemm_")]
            internal static extern void Dgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgemm_")]
            internal static extern void Qgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgemm_")]
            internal static extern void Cgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgemm_")]
            internal static extern void Zgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgemm_")]
            internal static extern void Xgemm(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgemm3m_")]
            internal static extern void Cgemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgemm3m_")]
            internal static extern void Zgemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgemm3m_")]
            internal static extern void Xgemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sge2mm_")]
            internal static extern int Sge2mm(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dge2mm_")]
            internal static extern int Dge2mm(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cge2mm_")]
            internal static extern int Cge2mm(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zge2mm_")]
            internal static extern int Zge2mm(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strsm_")]
            internal static extern void Strsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, float* _6, float* _7, int* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrsm_")]
            internal static extern void Dtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrsm_")]
            internal static extern void Qtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrsm_")]
            internal static extern void Ctrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, float* _6, float* _7, int* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrsm_")]
            internal static extern void Ztrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrsm_")]
            internal static extern void Xtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strmm_")]
            internal static extern void Strmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, float* _6, float* _7, int* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrmm_")]
            internal static extern void Dtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrmm_")]
            internal static extern void Qtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrmm_")]
            internal static extern void Ctrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, float* _6, float* _7, int* _8, float* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrmm_")]
            internal static extern void Ztrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrmm_")]
            internal static extern void Xtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, int* _4, int* _5, double* _6, double* _7, int* _8, double* _9, int* _10);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssymm_")]
            internal static extern void Ssymm(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsymm_")]
            internal static extern void Dsymm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsymm_")]
            internal static extern void Qsymm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csymm_")]
            internal static extern void Csymm(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsymm_")]
            internal static extern void Zsymm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsymm_")]
            internal static extern void Xsymm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csymm3m_")]
            internal static extern void Csymm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsymm3m_")]
            internal static extern void Zsymm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsymm3m_")]
            internal static extern void Xsymm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssyrk_")]
            internal static extern void Ssyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsyrk_")]
            internal static extern void Dsyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsyrk_")]
            internal static extern void Qsyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csyrk_")]
            internal static extern void Csyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsyrk_")]
            internal static extern void Zsyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsyrk_")]
            internal static extern void Xsyrk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ssyr2k_")]
            internal static extern void Ssyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dsyr2k_")]
            internal static extern void Dsyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qsyr2k_")]
            internal static extern void Qsyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "csyr2k_")]
            internal static extern void Csyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zsyr2k_")]
            internal static extern void Zsyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xsyr2k_")]
            internal static extern void Xsyr2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chemm_")]
            internal static extern void Chemm(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhemm_")]
            internal static extern void Zhemm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhemm_")]
            internal static extern void Xhemm(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "chemm3m_")]
            internal static extern void Chemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zhemm3m_")]
            internal static extern void Zhemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xhemm3m_")]
            internal static extern void Xhemm3m(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cherk_")]
            internal static extern void Cherk(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zherk_")]
            internal static extern void Zherk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xherk_")]
            internal static extern void Xherk(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cher2k_")]
            internal static extern void Cher2k(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8, float* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zher2k_")]
            internal static extern void Zher2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xher2k_")]
            internal static extern void Xher2k(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8, double* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cher2m_")]
            internal static extern int Cher2m(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, float* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zher2m_")]
            internal static extern int Zher2m(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xher2m_")]
            internal static extern int Xher2m(sbyte* _0, sbyte* _1, sbyte* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, double* _11, int* _12);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgemt_")]
            internal static extern int Sgemt(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgemt_")]
            internal static extern int Dgemt(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgemt_")]
            internal static extern int Cgemt(sbyte* _0, int* _1, int* _2, float* _3, float* _4, int* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgemt_")]
            internal static extern int Zgemt(sbyte* _0, int* _1, int* _2, double* _3, double* _4, int* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgema_")]
            internal static extern int Sgema(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgema_")]
            internal static extern int Dgema(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgema_")]
            internal static extern int Cgema(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgema_")]
            internal static extern int Zgema(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgems_")]
            internal static extern int Sgems(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgems_")]
            internal static extern int Dgems(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgems_")]
            internal static extern int Cgems(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, float* _8, int* _9, float* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgems_")]
            internal static extern int Zgems(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, double* _8, int* _9, double* _10, int* _11);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgemc_")]
            internal static extern int Sgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, int* _11, float* _12, float* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgemc_")]
            internal static extern int Dgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, int* _11, double* _12, double* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgemc_")]
            internal static extern int Qgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, int* _11, double* _12, double* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgemc_")]
            internal static extern int Cgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, float* _5, float* _6, int* _7, float* _8, int* _9, float* _10, int* _11, float* _12, float* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgemc_")]
            internal static extern int Zgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, int* _11, double* _12, double* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgemc_")]
            internal static extern int Xgemc(sbyte* _0, sbyte* _1, int* _2, int* _3, int* _4, double* _5, double* _6, int* _7, double* _8, int* _9, double* _10, int* _11, double* _12, double* _13, int* _14);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgetf2_")]
            internal static extern int Sgetf2(int* _0, int* _1, float* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgetf2_")]
            internal static extern int Dgetf2(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgetf2_")]
            internal static extern int Qgetf2(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgetf2_")]
            internal static extern int Cgetf2(int* _0, int* _1, float* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgetf2_")]
            internal static extern int Zgetf2(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgetf2_")]
            internal static extern int Xgetf2(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgetrf_")]
            internal static extern int Sgetrf(int* _0, int* _1, float* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgetrf_")]
            internal static extern int Dgetrf(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgetrf_")]
            internal static extern int Qgetrf(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgetrf_")]
            internal static extern int Cgetrf(int* _0, int* _1, float* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgetrf_")]
            internal static extern int Zgetrf(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgetrf_")]
            internal static extern int Xgetrf(int* _0, int* _1, double* _2, int* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "slaswp_")]
            internal static extern int Slaswp(int* _0, float* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dlaswp_")]
            internal static extern int Dlaswp(int* _0, double* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qlaswp_")]
            internal static extern int Qlaswp(int* _0, double* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "claswp_")]
            internal static extern int Claswp(int* _0, float* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zlaswp_")]
            internal static extern int Zlaswp(int* _0, double* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xlaswp_")]
            internal static extern int Xlaswp(int* _0, double* _1, int* _2, int* _3, int* _4, int* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgetrs_")]
            internal static extern int Sgetrs(sbyte* _0, int* _1, int* _2, float* _3, int* _4, int* _5, float* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgetrs_")]
            internal static extern int Dgetrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, int* _5, double* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgetrs_")]
            internal static extern int Qgetrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, int* _5, double* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgetrs_")]
            internal static extern int Cgetrs(sbyte* _0, int* _1, int* _2, float* _3, int* _4, int* _5, float* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgetrs_")]
            internal static extern int Zgetrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, int* _5, double* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgetrs_")]
            internal static extern int Xgetrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, int* _5, double* _6, int* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgesv_")]
            internal static extern int Sgesv(int* _0, int* _1, float* _2, int* _3, int* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgesv_")]
            internal static extern int Dgesv(int* _0, int* _1, double* _2, int* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qgesv_")]
            internal static extern int Qgesv(int* _0, int* _1, double* _2, int* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgesv_")]
            internal static extern int Cgesv(int* _0, int* _1, float* _2, int* _3, int* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgesv_")]
            internal static extern int Zgesv(int* _0, int* _1, double* _2, int* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xgesv_")]
            internal static extern int Xgesv(int* _0, int* _1, double* _2, int* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "spotf2_")]
            internal static extern int Spotf2(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dpotf2_")]
            internal static extern int Dpotf2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qpotf2_")]
            internal static extern int Qpotf2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cpotf2_")]
            internal static extern int Cpotf2(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zpotf2_")]
            internal static extern int Zpotf2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xpotf2_")]
            internal static extern int Xpotf2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "spotrf_")]
            internal static extern int Spotrf(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dpotrf_")]
            internal static extern int Dpotrf(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qpotrf_")]
            internal static extern int Qpotrf(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cpotrf_")]
            internal static extern int Cpotrf(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zpotrf_")]
            internal static extern int Zpotrf(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xpotrf_")]
            internal static extern int Xpotrf(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "spotrs_")]
            internal static extern int Spotrs(sbyte* _0, int* _1, int* _2, float* _3, int* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dpotrs_")]
            internal static extern int Dpotrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qpotrs_")]
            internal static extern int Qpotrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cpotrs_")]
            internal static extern int Cpotrs(sbyte* _0, int* _1, int* _2, float* _3, int* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zpotrs_")]
            internal static extern int Zpotrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xpotrs_")]
            internal static extern int Xpotrs(sbyte* _0, int* _1, int* _2, double* _3, int* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "slauu2_")]
            internal static extern int Slauu2(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dlauu2_")]
            internal static extern int Dlauu2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qlauu2_")]
            internal static extern int Qlauu2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "clauu2_")]
            internal static extern int Clauu2(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zlauu2_")]
            internal static extern int Zlauu2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xlauu2_")]
            internal static extern int Xlauu2(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "slauum_")]
            internal static extern int Slauum(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dlauum_")]
            internal static extern int Dlauum(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qlauum_")]
            internal static extern int Qlauum(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "clauum_")]
            internal static extern int Clauum(sbyte* _0, int* _1, float* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zlauum_")]
            internal static extern int Zlauum(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xlauum_")]
            internal static extern int Xlauum(sbyte* _0, int* _1, double* _2, int* _3, int* _4);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strti2_")]
            internal static extern int Strti2(sbyte* _0, sbyte* _1, int* _2, float* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrti2_")]
            internal static extern int Dtrti2(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrti2_")]
            internal static extern int Qtrti2(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrti2_")]
            internal static extern int Ctrti2(sbyte* _0, sbyte* _1, int* _2, float* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrti2_")]
            internal static extern int Ztrti2(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrti2_")]
            internal static extern int Xtrti2(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "strtri_")]
            internal static extern int Strtri(sbyte* _0, sbyte* _1, int* _2, float* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dtrtri_")]
            internal static extern int Dtrtri(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qtrtri_")]
            internal static extern int Qtrtri(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ctrtri_")]
            internal static extern int Ctrtri(sbyte* _0, sbyte* _1, int* _2, float* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ztrtri_")]
            internal static extern int Ztrtri(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "xtrtri_")]
            internal static extern int Xtrtri(sbyte* _0, sbyte* _1, int* _2, double* _3, int* _4, int* _5);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "slamch_")]
            internal static extern float Slamch(sbyte* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dlamch_")]
            internal static extern double Dlamch(sbyte* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qlamch_")]
            internal static extern double Qlamch(sbyte* _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "slamc3_")]
            internal static extern float Slamc3(float* _0, float* _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dlamc3_")]
            internal static extern double Dlamc3(double* _0, double* _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "qlamc3_")]
            internal static extern double Qlamc3(double* _0, double* _1);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "saxpby_")]
            internal static extern void Saxpby(int* _0, float* _1, float* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "daxpby_")]
            internal static extern void Daxpby(int* _0, double* _1, double* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "caxpby_")]
            internal static extern void Caxpby(int* _0, float* _1, float* _2, int* _3, float* _4, float* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zaxpby_")]
            internal static extern void Zaxpby(int* _0, double* _1, double* _2, int* _3, double* _4, double* _5, int* _6);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "somatcopy_")]
            internal static extern void Somatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "domatcopy_")]
            internal static extern void Domatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "comatcopy_")]
            internal static extern void Comatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, float* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zomatcopy_")]
            internal static extern void Zomatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, double* _7, int* _8);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "simatcopy_")]
            internal static extern void Simatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dimatcopy_")]
            internal static extern void Dimatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cimatcopy_")]
            internal static extern void Cimatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, float* _4, float* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zimatcopy_")]
            internal static extern void Zimatcopy(sbyte* _0, sbyte* _1, int* _2, int* _3, double* _4, double* _5, int* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "sgeadd_")]
            internal static extern void Sgeadd(int* _0, int* _1, float* _2, float* _3, int* _4, float* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "dgeadd_")]
            internal static extern void Dgeadd(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, double* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cgeadd_")]
            internal static extern void Cgeadd(int* _0, int* _1, float* _2, float* _3, int* _4, float* _5, float* _6, int* _7);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("openblas", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "zgeadd_")]
            internal static extern void Zgeadd(int* _0, int* _1, double* _2, double* _3, int* _4, double* _5, double* _6, int* _7);
        }

        public static int Xerbla(sbyte* _0, ref int info, int _1)
        {
            fixed (int* __info1 = &info)
            {
                var __arg1 = __info1;
                var __ret = __Internal.Xerbla(_0, __arg1, _1);
                return __ret;
            }
        }

        public static void OpenblasSetNumThreads(ref int _0)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                __Internal.OpenblasSetNumThreads(__arg0);
            }
        }

        public static float Sdot(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Sdot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static float Sdsdot(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Sdsdot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static double Dsdot(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Dsdot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static double Ddot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Ddot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static double Qdot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Qdot(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return __ret;
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexFloat Cdotu(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Cdotu(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexFloat.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexFloat Cdotc(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = __Internal.Cdotc(__arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexFloat.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexDouble Zdotu(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = new global::OpenBLAS.ComplexDouble.__Internal();
                                __Internal.Zdotu(new IntPtr(&__ret), __arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexDouble.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexDouble Zdotc(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = new global::OpenBLAS.ComplexDouble.__Internal();
                                __Internal.Zdotc(new IntPtr(&__ret), __arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexDouble.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexXdouble Xdotu(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = new global::OpenBLAS.ComplexXdouble.__Internal();
                                __Internal.Xdotu(new IntPtr(&__ret), __arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexXdouble.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static global::OpenBLAS.ComplexXdouble Xdotc(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                var __ret = new global::OpenBLAS.ComplexXdouble.__Internal();
                                __Internal.Xdotc(new IntPtr(&__ret), __arg0, __arg1, __arg2, __arg3, __arg4);
                                return global::OpenBLAS.ComplexXdouble.__CreateInstance(__ret);
                            }
                        }
                    }
                }
            }
        }

        public static void Saxpy(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Saxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Daxpy(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Daxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qaxpy(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Qaxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Caxpy(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Caxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zaxpy(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Zaxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xaxpy(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Xaxpy(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Caxpyc(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Caxpyc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zaxpyc(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Zaxpyc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xaxpyc(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Xaxpyc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Scopy(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Scopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Dcopy(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Dcopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Qcopy(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Qcopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Ccopy(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Ccopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Zcopy(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Zcopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Xcopy(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Xcopy(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Sswap(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Sswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Dswap(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Dswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Qswap(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Qswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Cswap(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Cswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Zswap(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Zswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Xswap(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Xswap(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static float Sasum(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Sasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scasum(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dasum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qasum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzasum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxasum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxasum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Ssum(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ssum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scsum(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scsum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dsum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dsum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qsum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qsum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzsum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzsum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxsum(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxsum(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Isamax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Isamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Idamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Idamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Iqamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Iqamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Icamax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Icamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Izamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Izamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ixamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ixamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ismax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ismax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Idmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Idmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Iqmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Iqmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Icmax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Icmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Izmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Izmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ixmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ixmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Isamin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Isamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Idamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Idamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Iqamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Iqamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Icamin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Icamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Izamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Izamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ixamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ixamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ismin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ismin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Idmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Idmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Iqmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Iqmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Icmin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Icmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Izmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Izmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static int Ixmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Ixmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Samax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Samax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Damax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Damax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scamax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxamax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxamax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Samin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Samin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Damin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Damin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scamin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxamin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxamin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Smax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Smax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scmax(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxmax(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxmax(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Smin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Smin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scmin(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dzmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dzmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxmin(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxmin(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static void Sscal(ref int _0, ref float _1, ref float _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Sscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Dscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Dscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Qscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Qscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Cscal(ref int _0, ref float _1, ref float _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Cscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Zscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Zscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Xscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Xscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Csscal(ref int _0, ref float _1, ref float _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Csscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Zdscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Zdscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Xqscal(ref int _0, ref double _1, ref double _2, ref int _3)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Xqscal(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static float Snrm2(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Snrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static float Scnrm2(ref int _0, ref float _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Scnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dnrm2(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qnrm2(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Dznrm2(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Dznrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static double Qxnrm2(ref int _0, ref double _1, ref int _2)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        var __ret = __Internal.Qxnrm2(__arg0, __arg1, __arg2);
                        return __ret;
                    }
                }
            }
        }

        public static void Srot(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4, ref float _5, ref float _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (float* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Srot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Drot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5, ref double _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Drot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qrot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5, ref double _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Qrot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csrot(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4, ref float _5, ref float _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (float* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Csrot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zdrot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5, ref double _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Zdrot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xqrot(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5, ref double _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Xqrot(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Srotg(ref float _0, ref float _1, ref float _2, ref float _3)
        {
            fixed (float* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Srotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Drotg(ref double _0, ref double _1, ref double _2, ref double _3)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Drotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Qrotg(ref double _0, ref double _1, ref double _2, ref double _3)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Qrotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Crotg(ref float _0, ref float _1, ref float _2, ref float _3)
        {
            fixed (float* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Crotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Zrotg(ref double _0, ref double _1, ref double _2, ref double _3)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Zrotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Xrotg(ref double _0, ref double _1, ref double _2, ref double _3)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            __Internal.Xrotg(__arg0, __arg1, __arg2, __arg3);
                        }
                    }
                }
            }
        }

        public static void Srotmg(ref float _0, ref float _1, ref float _2, ref float _3, ref float _4)
        {
            fixed (float* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Srotmg(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Drotmg(ref double _0, ref double _1, ref double _2, ref double _3, ref double _4)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                __Internal.Drotmg(__arg0, __arg1, __arg2, __arg3, __arg4);
                            }
                        }
                    }
                }
            }
        }

        public static void Srotm(ref int _0, ref float _1, ref int _2, ref float _3, ref int _4, ref float _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Srotm(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Drotm(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Drotm(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qrotm(ref int _0, ref double _1, ref int _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    __Internal.Qrotm(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sger(ref int _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (float* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Sger(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dger(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Dger(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qger(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Qger(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgeru(ref int _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (float* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Cgeru(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgerc(ref int _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (float* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Cgerc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgeru(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Zgeru(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgerc(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Zgerc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgeru(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Xgeru(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgerc(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (double* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            fixed (int* ___88 = &_8)
                                            {
                                                var __arg8 = ___88;
                                                __Internal.Xgerc(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sgemv(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7, ref float _8, ref float _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (float* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Sgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dgemv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Dgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qgemv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Qgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgemv(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7, ref float _8, ref float _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (float* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Cgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgemv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Zgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgemv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Xgemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Strsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Strsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Dtrsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Dtrsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Qtrsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Qtrsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Ctrsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Ctrsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Ztrsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Ztrsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Xtrsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Xtrsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Strmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Strmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Dtrmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Dtrmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Qtrmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Qtrmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Ctrmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Ctrmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Ztrmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Ztrmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Xtrmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (int* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                __Internal.Xtrmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7);
                            }
                        }
                    }
                }
            }
        }

        public static void Stpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Stpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Dtpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Dtpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Qtpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Qtpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Ctpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Ctpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Ztpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Ztpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Xtpsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Xtpsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Stpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Stpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Dtpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Dtpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Qtpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Qtpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Ctpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (float* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Ctpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Ztpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Ztpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Xtpmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (double* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            __Internal.Xtpmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6);
                        }
                    }
                }
            }
        }

        public static void Stbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (float* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Stbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dtbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Dtbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qtbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Qtbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ctbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (float* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Ctbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ztbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Ztbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xtbmv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Xtbmv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Stbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (float* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Stbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dtbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Dtbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qtbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Qtbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ctbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (float* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Ctbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ztbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Ztbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xtbsv(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (int* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (double* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (int* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    __Internal.Xtbsv(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssymv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Ssymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsymv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Dsymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsymv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Qsymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csymv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Csymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsymv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Zsymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsymv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Xsymv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sspmv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref float _4, ref int _5, ref float _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Sspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dspmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Dspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qspmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Qspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cspmv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref float _4, ref int _5, ref float _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Cspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zspmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Zspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xspmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Xspmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssyr(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Ssyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsyr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Dsyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsyr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Qsyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csyr(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Csyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsyr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Zsyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsyr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Xsyr(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssyr2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Ssyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsyr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Dsyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsyr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Qsyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csyr2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Csyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsyr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Zsyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsyr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Xsyr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sspr(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Sspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Dspr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Dspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Qspr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Qspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Cspr(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Cspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Zspr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Zspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Xspr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Xspr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Sspr2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Sspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dspr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Dspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qspr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Qspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cspr2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Cspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zspr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Zspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xspr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Xspr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cher(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Cher(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zher(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Zher(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xher(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    __Internal.Xher(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chpr(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Chpr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Zhpr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Zhpr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Xhpr(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                __Internal.Xhpr(_0, __arg1, __arg2, __arg3, __arg4, __arg5);
                            }
                        }
                    }
                }
            }
        }

        public static void Cher2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Cher2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zher2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Zher2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xher2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Xher2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chpr2(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Chpr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhpr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Zhpr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhpr2(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        __Internal.Xhpr2(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chemv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Chemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhemv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Zhemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhemv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                __Internal.Xhemv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chpmv(sbyte* _0, ref int _1, ref float _2, ref float _3, ref float _4, ref int _5, ref float _6, ref float _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (float* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Chpmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhpmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Zhpmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhpmv(sbyte* _0, ref int _1, ref double _2, ref double _3, ref double _4, ref int _5, ref double _6, ref double _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (double* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            __Internal.Xhpmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Snorm(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Snorm(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dnorm(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Dnorm(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Cnorm(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Cnorm(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Znorm(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Znorm(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static void Sgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (float* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (float* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Sgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (double* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (double* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Dgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (double* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (double* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Qgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (float* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (float* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Cgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (double* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (double* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Zgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgbmv(sbyte* _0, ref int _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (int* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (double* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    fixed (double* ___1111 = &_11)
                                                    {
                                                        var __arg11 = ___1111;
                                                        fixed (int* ___1212 = &_12)
                                                        {
                                                            var __arg12 = ___1212;
                                                            __Internal.Xgbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssbmv(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7, ref float _8, ref float _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (float* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Ssbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Dsbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Qsbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csbmv(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7, ref float _8, ref float _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (float* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Csbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Zsbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Xsbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chbmv(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7, ref float _8, ref float _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (float* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (float* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Chbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Zhbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhbmv(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7, ref double _8, ref double _9, ref int _10)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (double* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            fixed (double* ___99 = &_9)
                                            {
                                                var __arg9 = ___99;
                                                fixed (int* ___1010 = &_10)
                                                {
                                                    var __arg10 = ___1010;
                                                    __Internal.Xhbmv(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (float* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (float* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Sgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Dgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Qgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (float* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (float* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Cgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Zgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Xgemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (float* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (float* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Cgemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Zgemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xgemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (double* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (int* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        __Internal.Xgemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sge2mm(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (float* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (float* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (float* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Sge2mm(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dge2mm(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (double* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (double* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (double* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Dge2mm(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cge2mm(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (float* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (float* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (float* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Cge2mm(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zge2mm(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (double* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (double* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (double* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Zge2mm(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Strsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref float _6, ref float _7, ref int _8, ref float _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (float* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (float* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (float* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Strsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Dtrsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Qtrsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ctrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref float _6, ref float _7, ref int _8, ref float _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (float* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (float* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (float* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Ctrsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ztrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Ztrsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xtrsm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Xtrsm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Strmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref float _6, ref float _7, ref int _8, ref float _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (float* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (float* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (float* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Strmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Dtrmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Qtrmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ctrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref float _6, ref float _7, ref int _8, ref float _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (float* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (float* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (float* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Ctrmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ztrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Ztrmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xtrmm(sbyte* _0, sbyte* _1, sbyte* _2, sbyte* _3, ref int _4, ref int _5, ref double _6, ref double _7, ref int _8, ref double _9, ref int _10)
        {
            fixed (int* ___44 = &_4)
            {
                var __arg4 = ___44;
                fixed (int* ___55 = &_5)
                {
                    var __arg5 = ___55;
                    fixed (double* ___66 = &_6)
                    {
                        var __arg6 = ___66;
                        fixed (double* ___77 = &_7)
                        {
                            var __arg7 = ___77;
                            fixed (int* ___88 = &_8)
                            {
                                var __arg8 = ___88;
                                fixed (double* ___99 = &_9)
                                {
                                    var __arg9 = ___99;
                                    fixed (int* ___1010 = &_10)
                                    {
                                        var __arg10 = ___1010;
                                        __Internal.Xtrmm(_0, _1, _2, _3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Ssymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Dsymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Qsymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Csymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zsymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsymm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xsymm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csymm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Csymm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsymm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zsymm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsymm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xsymm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Ssyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Dsyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Qsyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Csyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Zsyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsyrk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Xsyrk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Ssyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Ssyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dsyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Dsyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Qsyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Qsyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Csyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Csyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zsyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zsyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xsyr2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xsyr2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Chemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zhemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhemm(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xhemm(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Chemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Chemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zhemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zhemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xhemm3m(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xhemm3m(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cherk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Cherk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zherk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Zherk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xherk(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            __Internal.Xherk(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cher2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8, ref float _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (float* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Cher2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zher2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Zher2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Xher2k(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8, ref double _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (double* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    __Internal.Xher2k(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cher2m(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref float _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (float* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (float* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (float* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (float* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (float* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Cher2m(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zher2m(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (double* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (double* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (double* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Zher2m(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xher2m(sbyte* _0, sbyte* _1, sbyte* _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref double _11, ref int _12)
        {
            fixed (int* ___33 = &_3)
            {
                var __arg3 = ___33;
                fixed (int* ___44 = &_4)
                {
                    var __arg4 = ___44;
                    fixed (double* ___55 = &_5)
                    {
                        var __arg5 = ___55;
                        fixed (double* ___66 = &_6)
                        {
                            var __arg6 = ___66;
                            fixed (int* ___77 = &_7)
                            {
                                var __arg7 = ___77;
                                fixed (double* ___88 = &_8)
                                {
                                    var __arg8 = ___88;
                                    fixed (int* ___99 = &_9)
                                    {
                                        var __arg9 = ___99;
                                        fixed (double* ___1010 = &_10)
                                        {
                                            var __arg10 = ___1010;
                                            fixed (double* ___1111 = &_11)
                                            {
                                                var __arg11 = ___1111;
                                                fixed (int* ___1212 = &_12)
                                                {
                                                    var __arg12 = ___1212;
                                                    var __ret = __Internal.Xher2m(_0, _1, _2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgemt(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Sgemt(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgemt(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Dgemt(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgemt(sbyte* _0, ref int _1, ref int _2, ref float _3, ref float _4, ref int _5, ref float _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (float* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Cgemt(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgemt(sbyte* _0, ref int _1, ref int _2, ref double _3, ref double _4, ref int _5, ref double _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (double* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Zgemt(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgema(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Sgema(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgema(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Dgema(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgema(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Cgema(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgema(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Zgema(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgems(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Sgems(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgems(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Dgems(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgems(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref float _8, ref int _9, ref float _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Cgems(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgems(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref double _8, ref int _9, ref double _10, ref int _11)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    var __ret = __Internal.Zgems(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11);
                                                    return __ret;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref int _11, ref float _12, ref float _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (float* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (float* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (float* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Sgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref int _11, ref double _12, ref double _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (double* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (double* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Dgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref int _11, ref double _12, ref double _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (double* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (double* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Qgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref float _5, ref float _6, ref int _7, ref float _8, ref int _9, ref float _10, ref int _11, ref float _12, ref float _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (float* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (float* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (float* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (float* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (float* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Cgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref int _11, ref double _12, ref double _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (double* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (double* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Zgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xgemc(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref int _4, ref double _5, ref double _6, ref int _7, ref double _8, ref int _9, ref double _10, ref int _11, ref double _12, ref double _13, ref int _14)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (double* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (double* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        fixed (int* ___99 = &_9)
                                        {
                                            var __arg9 = ___99;
                                            fixed (double* ___1010 = &_10)
                                            {
                                                var __arg10 = ___1010;
                                                fixed (int* ___1111 = &_11)
                                                {
                                                    var __arg11 = ___1111;
                                                    fixed (double* ___1212 = &_12)
                                                    {
                                                        var __arg12 = ___1212;
                                                        fixed (double* ___1313 = &_13)
                                                        {
                                                            var __arg13 = ___1313;
                                                            fixed (int* ___1414 = &_14)
                                                            {
                                                                var __arg14 = ___1414;
                                                                var __ret = __Internal.Xgemc(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8, __arg9, __arg10, __arg11, __arg12, __arg13, __arg14);
                                                                return __ret;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgetf2(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Sgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgetf2(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Dgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qgetf2(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Qgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgetf2(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Cgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgetf2(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Zgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xgetf2(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Xgetf2(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgetrf(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Sgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgetrf(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Dgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qgetrf(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Qgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgetrf(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Cgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgetrf(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Zgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xgetrf(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref int _5)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    var __ret = __Internal.Xgetrf(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5);
                                    return __ret;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Slaswp(ref int _0, ref float _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Slaswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dlaswp(ref int _0, ref double _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Dlaswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qlaswp(ref int _0, ref double _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Qlaswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Claswp(ref int _0, ref float _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Claswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zlaswp(ref int _0, ref double _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Zlaswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xlaswp(ref int _0, ref double _1, ref int _2, ref int _3, ref int _4, ref int _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (int* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (int* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        var __ret = __Internal.Xlaswp(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgetrs(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4, ref int _5, ref float _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Sgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgetrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref int _5, ref double _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Dgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qgetrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref int _5, ref double _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Qgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgetrs(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4, ref int _5, ref float _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (float* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Cgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgetrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref int _5, ref double _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Zgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xgetrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref int _5, ref double _6, ref int _7, ref int _8)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (int* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (double* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        fixed (int* ___88 = &_8)
                                        {
                                            var __arg8 = ___88;
                                            var __ret = __Internal.Xgetrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Sgesv(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Sgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dgesv(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Dgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qgesv(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Qgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cgesv(ref int _0, ref int _1, ref float _2, ref int _3, ref int _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Cgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zgesv(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Zgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xgesv(ref int _0, ref int _1, ref double _2, ref int _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            var __ret = __Internal.Xgesv(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                            return __ret;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Spotf2(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Spotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dpotf2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Dpotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qpotf2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Qpotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Cpotf2(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Cpotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Zpotf2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Zpotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xpotf2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Xpotf2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Spotrf(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Spotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dpotrf(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Dpotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qpotrf(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Qpotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Cpotrf(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Cpotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Zpotrf(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Zpotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xpotrf(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Xpotrf(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Spotrs(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Spotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Dpotrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Dpotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Qpotrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Qpotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Cpotrs(sbyte* _0, ref int _1, ref int _2, ref float _3, ref int _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (float* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (float* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Cpotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Zpotrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Zpotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Xpotrs(sbyte* _0, ref int _1, ref int _2, ref double _3, ref int _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (int* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (double* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            fixed (double* ___55 = &_5)
                            {
                                var __arg5 = ___55;
                                fixed (int* ___66 = &_6)
                                {
                                    var __arg6 = ___66;
                                    fixed (int* ___77 = &_7)
                                    {
                                        var __arg7 = ___77;
                                        var __ret = __Internal.Xpotrs(_0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        return __ret;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static int Slauu2(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Slauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dlauu2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Dlauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qlauu2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Qlauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Clauu2(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Clauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Zlauu2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Zlauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xlauu2(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Xlauu2(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Slauum(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Slauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dlauum(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Dlauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qlauum(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Qlauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Clauum(sbyte* _0, ref int _1, ref float _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (float* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Clauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Zlauum(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Zlauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xlauum(sbyte* _0, ref int _1, ref double _2, ref int _3, ref int _4)
        {
            fixed (int* ___11 = &_1)
            {
                var __arg1 = ___11;
                fixed (double* ___22 = &_2)
                {
                    var __arg2 = ___22;
                    fixed (int* ___33 = &_3)
                    {
                        var __arg3 = ___33;
                        fixed (int* ___44 = &_4)
                        {
                            var __arg4 = ___44;
                            var __ret = __Internal.Xlauum(_0, __arg1, __arg2, __arg3, __arg4);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Strti2(sbyte* _0, sbyte* _1, ref int _2, ref float _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (float* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Strti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dtrti2(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Dtrti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qtrti2(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Qtrti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Ctrti2(sbyte* _0, sbyte* _1, ref int _2, ref float _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (float* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Ctrti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Ztrti2(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Ztrti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xtrti2(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Xtrti2(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Strtri(sbyte* _0, sbyte* _1, ref int _2, ref float _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (float* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Strtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Dtrtri(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Dtrtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Qtrtri(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Qtrtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Ctrtri(sbyte* _0, sbyte* _1, ref int _2, ref float _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (float* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Ctrtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Ztrtri(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Ztrtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static int Xtrtri(sbyte* _0, sbyte* _1, ref int _2, ref double _3, ref int _4, ref int _5)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (double* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (int* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (int* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            var __ret = __Internal.Xtrtri(_0, _1, __arg2, __arg3, __arg4, __arg5);
                            return __ret;
                        }
                    }
                }
            }
        }

        public static float Slamch(sbyte* _0)
        {
            var __ret = __Internal.Slamch(_0);
            return __ret;
        }

        public static double Dlamch(sbyte* _0)
        {
            var __ret = __Internal.Dlamch(_0);
            return __ret;
        }

        public static double Qlamch(sbyte* _0)
        {
            var __ret = __Internal.Qlamch(_0);
            return __ret;
        }

        public static float Slamc3(ref float _0, ref float _1)
        {
            fixed (float* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    var __ret = __Internal.Slamc3(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        public static double Dlamc3(ref double _0, ref double _1)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    var __ret = __Internal.Dlamc3(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        public static double Qlamc3(ref double _0, ref double _1)
        {
            fixed (double* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    var __ret = __Internal.Qlamc3(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        public static void Saxpby(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Saxpby(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Daxpby(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Daxpby(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Caxpby(ref int _0, ref float _1, ref float _2, ref int _3, ref float _4, ref float _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (float* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (float* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Caxpby(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zaxpby(ref int _0, ref double _1, ref double _2, ref int _3, ref double _4, ref double _5, ref int _6)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (double* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (int* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (double* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (int* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        __Internal.Zaxpby(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Somatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        __Internal.Somatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Domatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        __Internal.Domatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Comatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref float _7, ref int _8)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (float* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        __Internal.Comatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zomatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref double _7, ref int _8)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (double* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    fixed (int* ___88 = &_8)
                                    {
                                        var __arg8 = ___88;
                                        __Internal.Zomatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7, __arg8);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Simatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    __Internal.Simatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dimatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    __Internal.Dimatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cimatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref float _4, ref float _5, ref int _6, ref int _7)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (float* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (float* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    __Internal.Cimatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zimatcopy(sbyte* _0, sbyte* _1, ref int _2, ref int _3, ref double _4, ref double _5, ref int _6, ref int _7)
        {
            fixed (int* ___22 = &_2)
            {
                var __arg2 = ___22;
                fixed (int* ___33 = &_3)
                {
                    var __arg3 = ___33;
                    fixed (double* ___44 = &_4)
                    {
                        var __arg4 = ___44;
                        fixed (double* ___55 = &_5)
                        {
                            var __arg5 = ___55;
                            fixed (int* ___66 = &_6)
                            {
                                var __arg6 = ___66;
                                fixed (int* ___77 = &_7)
                                {
                                    var __arg7 = ___77;
                                    __Internal.Zimatcopy(_0, _1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Sgeadd(ref int _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref float _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (float* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            __Internal.Sgeadd(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Dgeadd(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref double _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            __Internal.Dgeadd(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Cgeadd(ref int _0, ref int _1, ref float _2, ref float _3, ref int _4, ref float _5, ref float _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (float* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (float* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (float* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (float* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            __Internal.Cgeadd(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void Zgeadd(ref int _0, ref int _1, ref double _2, ref double _3, ref int _4, ref double _5, ref double _6, ref int _7)
        {
            fixed (int* ___00 = &_0)
            {
                var __arg0 = ___00;
                fixed (int* ___11 = &_1)
                {
                    var __arg1 = ___11;
                    fixed (double* ___22 = &_2)
                    {
                        var __arg2 = ___22;
                        fixed (double* ___33 = &_3)
                        {
                            var __arg3 = ___33;
                            fixed (int* ___44 = &_4)
                            {
                                var __arg4 = ___44;
                                fixed (double* ___55 = &_5)
                                {
                                    var __arg5 = ___55;
                                    fixed (double* ___66 = &_6)
                                    {
                                        var __arg6 = ___66;
                                        fixed (int* ___77 = &_7)
                                        {
                                            var __arg7 = ___77;
                                            __Internal.Zgeadd(__arg0, __arg1, __arg2, __arg3, __arg4, __arg5, __arg6, __arg7);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
