using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
    [NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
    [StructLayout(LayoutKind.Sequential)]
    internal class CustomEventData : IDisposable
    {
        [NonSerialized]
        internal IntPtr m_Ptr;

        private CustomEventData()
        {
        }

        public CustomEventData(string name)
        {
            return;
        }

        ~CustomEventData()
        {
            return;
        }

        private void Destroy()
        {
            return;
        }

        public void Dispose()
        {
            return;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr Internal_Create(CustomEventData ced, string name);

        [ThreadSafe]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Destroy(IntPtr ptr);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddString(string key, string value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddInt32(string key, int value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddUInt32(string key, uint value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddInt64(string key, long value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddUInt64(string key, ulong value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddBool(string key, bool value);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool AddDouble(string key, double value);

        public bool AddDictionary(IDictionary<string, object> eventData)
        {
            return true;
        }
    }
}
