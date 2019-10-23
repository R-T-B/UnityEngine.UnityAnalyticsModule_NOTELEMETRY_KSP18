using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
    [ExcludeFromDocs]
    [NativeHeader("UnityAnalyticsScriptingClasses.h")]
    [NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
    [StructLayout(LayoutKind.Sequential)]
    public class RemoteConfigSettings : IDisposable
    {
        [NonSerialized]
        internal IntPtr m_Ptr;

        private RemoteConfigSettings()
        {
        }

        public RemoteConfigSettings(string configKey)
        {
        }

        public event Action<bool> Updated;

        ~RemoteConfigSettings()
        {
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
        internal static extern IntPtr Internal_Create(RemoteConfigSettings rcs, string configKey);

        [ThreadSafe]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern void Internal_Destroy(IntPtr ptr);

        [RequiredByNativeCode]
        internal static void RemoteConfigSettingsUpdated(
          RemoteConfigSettings rcs,
          bool wasLastUpdatedFromServer)
        {
            return;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern bool QueueConfig(string name, object param, int ver = 1, string prefix = "");

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern bool SendDeviceInfoInConfigRequest();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public static extern void AddSessionTag(string tag);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern void ForceUpdate();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool WasLastUpdatedFromServer();

        [ExcludeFromDocs]
        public int GetInt(string key)
        {
            return 0;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern int GetInt(string key, [Internal.DefaultValue("0")] int defaultValue);

        [ExcludeFromDocs]
        public long GetLong(string key)
        {
            return 0L;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern long GetLong(string key, [Internal.DefaultValue("0")] long defaultValue);

        [ExcludeFromDocs]
        public float GetFloat(string key)
        {
            return 0.0f;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern float GetFloat(string key, [Internal.DefaultValue("0.0F")] float defaultValue);

        [ExcludeFromDocs]
        public string GetString(string key)
        {
            return "";
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern string GetString(string key, [Internal.DefaultValue("\"\"")] string defaultValue);

        [ExcludeFromDocs]
        public bool GetBool(string key)
        {
            return false;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool GetBool(string key, [Internal.DefaultValue("false")] bool defaultValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern bool HasKey(string key);

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern int GetCount();

        [MethodImpl(MethodImplOptions.InternalCall)]
        public extern string[] GetKeys();

        public T GetObject<T>(string key = "")
        {
            return (T)this.GetObject(typeof(T), "");
        }

        public object GetObject(Type type, string key = "")
        {
            return null;
        }

        public object GetObject(string key, object defaultValue)
        {
            return null;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern object GetAsScriptingObject(Type t, object defaultValue, string key);

        public IDictionary<string, object> GetDictionary(string key = "")
        {
            return (IDictionary<string, object>)null;
        }

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern void UseSafeLock();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern void ReleaseSafeLock();

        [MethodImpl(MethodImplOptions.InternalCall)]
        internal extern IntPtr GetSafeTopMap();
    }
}
