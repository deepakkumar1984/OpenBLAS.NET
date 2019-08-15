using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenBLAS
{
    public unsafe partial class ComplexDouble : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double real;

            [FieldOffset(8)]
            internal double imag;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0openblas_complex_double@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::OpenBLAS.ComplexDouble> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::OpenBLAS.ComplexDouble>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::OpenBLAS.ComplexDouble __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::OpenBLAS.ComplexDouble(native.ToPointer(), skipVTables);
        }

        internal static global::OpenBLAS.ComplexDouble __CreateInstance(global::OpenBLAS.ComplexDouble.__Internal native, bool skipVTables = false)
        {
            return new global::OpenBLAS.ComplexDouble(native, skipVTables);
        }

        private static void* __CopyValue(global::OpenBLAS.ComplexDouble.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexDouble.__Internal));
            *(global::OpenBLAS.ComplexDouble.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ComplexDouble(global::OpenBLAS.ComplexDouble.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ComplexDouble(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ComplexDouble()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexDouble.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ComplexDouble(global::OpenBLAS.ComplexDouble _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexDouble.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::OpenBLAS.ComplexDouble.__Internal*)__Instance) = *((global::OpenBLAS.ComplexDouble.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::OpenBLAS.ComplexDouble __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double Real
        {
            get
            {
                return ((global::OpenBLAS.ComplexDouble.__Internal*)__Instance)->real;
            }

            set
            {
                ((global::OpenBLAS.ComplexDouble.__Internal*)__Instance)->real = value;
            }
        }

        public double Imag
        {
            get
            {
                return ((global::OpenBLAS.ComplexDouble.__Internal*)__Instance)->imag;
            }

            set
            {
                ((global::OpenBLAS.ComplexDouble.__Internal*)__Instance)->imag = value;
            }
        }
    }
}
