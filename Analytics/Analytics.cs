using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
    [NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
    [NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
    [StructLayout(LayoutKind.Sequential)]
    public static class Analytics
    {
        public static bool initializeOnStartup
        {
            get
            {
                return true;
            }
            set
            {
            }
        }

        public static AnalyticsResult ResumeInitialization()
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        [NativeMethod("ResumeInitialization")]
        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern AnalyticsResult ResumeInitializationInternal();

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        private static extern bool initializeOnStartupInternal { [NativeMethod("GetInitializeOnStartup"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetInitializeOnStartup"), MethodImpl(MethodImplOptions.InternalCall)] set; }

        [ThreadSafe]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern bool IsInitialized();

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        private static extern bool enabledInternal { [NativeMethod("GetEnabled"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetEnabled"), MethodImpl(MethodImplOptions.InternalCall)] set; }

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        private static extern bool playerOptedOutInternal { [NativeMethod("GetPlayerOptedOut"), MethodImpl(MethodImplOptions.InternalCall)] get; }

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        private static extern bool limitUserTrackingInternal { [NativeMethod("GetLimitUserTracking"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetLimitUserTracking"), MethodImpl(MethodImplOptions.InternalCall)] set; }

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        private static extern bool deviceStatsEnabledInternal { [NativeMethod("GetDeviceStatsEnabled"), MethodImpl(MethodImplOptions.InternalCall)] get; [NativeMethod("SetDeviceStatsEnabled"), MethodImpl(MethodImplOptions.InternalCall)] set; }

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [NativeMethod("FlushEvents")]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern bool FlushArchivedEvents();

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern AnalyticsResult Transaction(
          string productId,
          double amount,
          string currency,
          string receiptPurchaseData,
          string signature,
          bool usingIAPService);

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern AnalyticsResult SendCustomEventName(string customEventName);

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static extern AnalyticsResult SendCustomEvent(CustomEventData eventData);

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnalyticsResult RegisterEventWithLimit(
          string eventName,
          int maxEventPerHour,
          int maxItems,
          string vendorKey,
          int ver,
          string prefix,
          string assemblyInfo,
          bool notifyServer);

        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnalyticsResult RegisterEventsWithLimit(
          string[] eventName,
          int maxEventPerHour,
          int maxItems,
          string vendorKey,
          int ver,
          string prefix,
          string assemblyInfo,
          bool notifyServer);

        [ThreadSafe]
        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern AnalyticsResult SendEventWithLimit(
          string eventName,
          object parameters,
          int ver,
          string prefix);

        [ThreadSafe]
        [StaticAccessor("GetUnityAnalytics()", StaticAccessorType.Dot)]
        [MethodImpl(MethodImplOptions.InternalCall)]
        internal static extern bool QueueEvent(
          string eventName,
          object parameters,
          int ver,
          string prefix);

        public static bool playerOptedOut
        {
            get
            {
                return true;
            }
        }

        public static bool limitUserTracking
        {
            get
            {
                UnityEngine.Analytics.Analytics.limitUserTrackingInternal = true;
                return true;
            }
            set
            {
                UnityEngine.Analytics.Analytics.limitUserTrackingInternal = true;
                return;
            }
        }

        public static bool deviceStatsEnabled
        {
            get
            {
                UnityEngine.Analytics.Analytics.deviceStatsEnabledInternal = false;
                return false;
            }
            set
            {
                UnityEngine.Analytics.Analytics.deviceStatsEnabledInternal = false;
                return;
            }
        }

        public static bool enabled
        {
            get
            {
                UnityEngine.Analytics.Analytics.enabledInternal = false;
                return false;
            }
            set
            {
                UnityEngine.Analytics.Analytics.enabledInternal = false;
                return;
            }
        }

        public static AnalyticsResult FlushEvents()
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult SetUserId(string userId)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult SetUserGender(Gender gender)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult SetUserBirthYear(int birthYear)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        private static AnalyticsResult SendUserInfoEvent(object param)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult Transaction(
          string productId,
          Decimal amount,
          string currency)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult Transaction(
          string productId,
          Decimal amount,
          string currency,
          string receiptPurchaseData,
          string signature)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult Transaction(
          string productId,
          Decimal amount,
          string currency,
          string receiptPurchaseData,
          string signature,
          bool usingIAPService)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult CustomEvent(string customEventName)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult CustomEvent(
          string customEventName,
          Vector3 position)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult CustomEvent(
          string customEventName,
          IDictionary<string, object> eventData)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static AnalyticsResult RegisterEvent(
          string eventName,
          int maxEventPerHour,
          int maxItems,
          string vendorKey = "",
          string prefix = "")
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static AnalyticsResult RegisterEvent(
          string eventName,
          int maxEventPerHour,
          int maxItems,
          string vendorKey,
          int ver,
          string prefix = "")
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        private static AnalyticsResult RegisterEvent(
          string eventName,
          int maxEventPerHour,
          int maxItems,
          string vendorKey,
          int ver,
          string prefix,
          string assemblyInfo)
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        public static AnalyticsResult SendEvent(
          string eventName,
          object parameters,
          int ver = 1,
          string prefix = "")
        {
            return AnalyticsResult.AnalyticsDisabled;
        }

        [Serializable]
        private struct UserInfo
        {
            public string custom_userid;
            public string sex;
        }

        [Serializable]
        private struct UserInfoBirthYear
        {
            public int birth_year;
        }
    }
}
