using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenBLAS
{
    public unsafe partial class ComplexFloat : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float real;

            [FieldOffset(4)]
            internal float imag;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("OpenBLAS", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0openblas_complex_float@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::OpenBLAS.ComplexFloat> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::OpenBLAS.ComplexFloat>();
        protected internal void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::OpenBLAS.ComplexFloat __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::OpenBLAS.ComplexFloat(native.ToPointer(), skipVTables);
        }

        internal static global::OpenBLAS.ComplexFloat __CreateInstance(global::OpenBLAS.ComplexFloat.__Internal native, bool skipVTables = false)
        {
            return new global::OpenBLAS.ComplexFloat(native, skipVTables);
        }

        private static void* __CopyValue(global::OpenBLAS.ComplexFloat.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexFloat.__Internal));
            *(global::OpenBLAS.ComplexFloat.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ComplexFloat(global::OpenBLAS.ComplexFloat.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ComplexFloat(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ComplexFloat()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexFloat.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ComplexFloat(global::OpenBLAS.ComplexFloat _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::OpenBLAS.ComplexFloat.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::OpenBLAS.ComplexFloat.__Internal*)__Instance) = *((global::OpenBLAS.ComplexFloat.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::OpenBLAS.ComplexFloat __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float Real
        {
            get
            {
                return ((global::OpenBLAS.ComplexFloat.__Internal*)__Instance)->real;
            }

            set
            {
                ((global::OpenBLAS.ComplexFloat.__Internal*)__Instance)->real = value;
            }
        }

        public float Imag
        {
            get
            {
                return ((global::OpenBLAS.ComplexFloat.__Internal*)__Instance)->imag;
            }

            set
            {
                ((global::OpenBLAS.ComplexFloat.__Internal*)__Instance)->imag = value;
            }
        }
    }
}
