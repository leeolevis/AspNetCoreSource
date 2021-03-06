// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.Primitives
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

        /// <summary>Offset and length are out of bounds for the string or length is greater than the number of characters from index to the end of the string.</summary>
        internal static string Argument_InvalidOffsetLength => GetResourceString("Argument_InvalidOffsetLength");
        /// <summary>Offset and length are out of bounds for this StringSegment or length is greater than the number of characters to the end of this StringSegment.</summary>
        internal static string Argument_InvalidOffsetLengthStringSegment => GetResourceString("Argument_InvalidOffsetLengthStringSegment");
        /// <summary>Cannot change capacity after write started.</summary>
        internal static string Capacity_CannotChangeAfterWriteStarted => GetResourceString("Capacity_CannotChangeAfterWriteStarted");
        /// <summary>Not enough capacity to write '{0}' characters, only '{1}' left.</summary>
        internal static string Capacity_NotEnough => GetResourceString("Capacity_NotEnough");
        /// <summary>Not enough capacity to write '{0}' characters, only '{1}' left.</summary>
        internal static string FormatCapacity_NotEnough(object p0, object p1)
           => string.Format(Culture, GetResourceString("Capacity_NotEnough"), p0, p1);

        /// <summary>Entire reserved capacity was not used. Capacity: '{0}', written '{1}'.</summary>
        internal static string Capacity_NotUsedEntirely => GetResourceString("Capacity_NotUsedEntirely");
        /// <summary>Entire reserved capacity was not used. Capacity: '{0}', written '{1}'.</summary>
        internal static string FormatCapacity_NotUsedEntirely(object p0, object p1)
           => string.Format(Culture, GetResourceString("Capacity_NotUsedEntirely"), p0, p1);


    }
}
