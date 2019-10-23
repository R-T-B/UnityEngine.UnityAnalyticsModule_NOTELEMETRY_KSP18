using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
    internal static class RemoteConfigSettingsHelper
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr GetSafeMap(IntPtr m, string key);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string[] GetSafeMapKeys(IntPtr m);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RemoteConfigSettingsHelper.Tag[] GetSafeMapTypes(
          IntPtr m);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long GetSafeNumber(IntPtr m, string key, long defaultValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float GetSafeFloat(IntPtr m, string key, float defaultValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool GetSafeBool(IntPtr m, string key, bool defaultValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string GetSafeStringValue(IntPtr m, string key, string defaultValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr GetSafeArray(IntPtr m, string key);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long GetSafeArraySize(IntPtr a);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr GetSafeArrayArray(IntPtr a, long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern IntPtr GetSafeArrayMap(IntPtr a, long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern RemoteConfigSettingsHelper.Tag GetSafeArrayType(
          IntPtr a,
          long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern long GetSafeNumberArray(IntPtr a, long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern float GetSafeArrayFloat(IntPtr a, long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool GetSafeArrayBool(IntPtr a, long i);

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern string GetSafeArrayStringValue(IntPtr a, long i);

        public static IDictionary<string, object> GetDictionary(IntPtr m, string key)
        {
            return (IDictionary<string, object>)null;
        }

        internal static IDictionary<string, object> GetDictionary(IntPtr m)
        {
            return (IDictionary<string, object>)null;
        }

        internal static object GetArrayArrayEntries(IntPtr a, long i)
        {
            return null;
        }

        internal static IDictionary<string, object> GetArrayMapEntries(IntPtr a, long i)
        {
            return (IDictionary<string, object>)null;
        }

        internal static T[] GetArrayEntriesType<T>(IntPtr a, long size, Func<IntPtr, long, T> f)
        {
            T[] objArray = new T[size];
            return objArray;
        }

        internal static object GetArrayEntries(IntPtr a)
        {
            return (object)null;
        }

        internal static object GetMixedArrayEntries(IntPtr a)
        {
            long safeArraySize = RemoteConfigSettingsHelper.GetSafeArraySize(a);
            object[] objArray = new object[safeArraySize];
            return (object)objArray;
        }

        internal static void SetDictKeyType(
          IntPtr m,
          IDictionary<string, object> dict,
          string key,
          RemoteConfigSettingsHelper.Tag tag)
        {
            return;
        }

        [RequiredByNativeCode]
        internal enum Tag
        {
            kUnknown,
            kIntVal,
            kInt64Val,
            kUInt64Val,
            kDoubleVal,
            kBoolVal,
            kStringVal,
            kArrayVal,
            kMixedArrayVal,
            kMapVal,
            kMaxTags,
        }
    }
}
