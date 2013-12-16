using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SpreedlyCoreSharp.Extensions
{
    public static class EnumExtensions
    {
        public static List<Enum> AsEnumList(this Type enumType)
        {
            return Enum.GetValues(enumType).Cast<Enum>().ToList();
        }

        public static Dictionary<Enum, string> AsEnumDictionary(this Type enumType)
        {
            return enumType.AsEnumList().ToDictionary(k => k, v => v.DescriptionOrValue());
        }

        public static string Description(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static string DescriptionOrValue(this Enum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : val.ToString();
        }
    }
}
