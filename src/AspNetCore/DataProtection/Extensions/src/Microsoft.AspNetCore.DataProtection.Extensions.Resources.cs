// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.DataProtection.Extensions
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>An error occurred during a cryptographic operation.</summary>
        internal static string CryptCommon_GenericError => GetResourceString("CryptCommon_GenericError");
        /// <summary>The payload expired at {0}.</summary>
        internal static string TimeLimitedDataProtector_PayloadExpired => GetResourceString("TimeLimitedDataProtector_PayloadExpired");
        /// <summary>The payload expired at {0}.</summary>
        internal static string FormatTimeLimitedDataProtector_PayloadExpired(object p0)
           => string.Format(Culture, GetResourceString("TimeLimitedDataProtector_PayloadExpired"), p0);

        /// <summary>The payload is invalid.</summary>
        internal static string TimeLimitedDataProtector_PayloadInvalid => GetResourceString("TimeLimitedDataProtector_PayloadInvalid");

    }
}
