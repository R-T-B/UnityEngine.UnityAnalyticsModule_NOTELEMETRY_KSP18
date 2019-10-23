using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
    [RequiredByNativeCode]
    [NativeHeader("UnityAnalyticsScriptingClasses.h")]
    [NativeHeader("Modules/UnityAnalytics/CoreStats/AnalyticsCoreStats.h")]
    public static class AnalyticsSessionInfo
    {
        public static event AnalyticsSessionInfo.SessionStateChanged sessionStateChanged;

        [RequiredByNativeCode]
        internal static void CallSessionStateChanged(
          AnalyticsSessionState sessionState,
          long sessionId,
          long sessionElapsedTime,
          bool sessionChanged)
        {
            return;
        }

        public static extern AnalyticsSessionState sessionState { [NativeMethod("GetPlayerSessionState"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public static extern long sessionId { [NativeMethod("GetPlayerSessionId"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public static extern long sessionCount { [NativeMethod("GetPlayerSessionCount"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public static extern long sessionElapsedTime { [NativeMethod("GetPlayerSessionElapsedTime"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public static extern bool sessionFirstRun { [NativeMethod("GetPlayerSessionFirstRun", false, true), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public static extern string userId { [NativeMethod("GetUserId"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        public delegate void SessionStateChanged(
          AnalyticsSessionState sessionState,
          long sessionId,
          long sessionElapsedTime,
          bool sessionChanged);
    }
}
