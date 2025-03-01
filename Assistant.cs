using System.Text.Json;
using KSS.Common.Utility.Enum.Base;
using KSS.Common.Utility.Model;

namespace KSS.Common.Utility
{
    public class Assistant
    {
        public const int MaxPageSize = 50;
        public const int DefaultPageSize = 10;
        public const string EmptyMessage = "فاقد اطلاعات";
        public const string ErrorMessage = "خطای سیستمی";

        public static string NumberToLetter(short value)
        {
            return value switch
            {
                1 => "اول",
                2 => "دوم",
                3 => "سوم",
                4 => "چهارم",
                5 => "پنجم",
                6 => "ششم",
                7 => "هفتم",
                8 => "هشتم",
                9 => "نهم",
                10 => "دهم",
                _ => "",
            };
        }

        public static object FilterGetValue(Filter filter)
        {
            if (filter.Value is JsonElement jsonElement)
            {
                switch (filter.DataType)
                {
                    case DataType.Byte:
                        return jsonElement.GetByte();
                    case DataType.Short:
                        return jsonElement.GetInt16();
                    case DataType.Integer:
                        return jsonElement.GetInt32();
                    case DataType.Long:
                        return jsonElement.GetInt64();
                    case DataType.Double:
                        return jsonElement.GetDouble();
                    case DataType.String:
                        return jsonElement.GetString();
                    case DataType.DateTime:
                        return jsonElement.GetDateTime();
                    case DataType.Boolean:
                        return jsonElement.GetBoolean();
                }
            }
            else
                return filter.Value;

            return null;
        }

        public static string PMonthName(byte pMonth)
        {
            return pMonth switch
            {
                1 => "فروردین",
                2 => "اردیبهشت",
                3 => "خرداد",
                4 => "تیر",
                5 => "مرداد",
                6 => "شهریور",
                7 => "مهر",
                8 => "آبان",
                9 => "آذر",
                10 => "دی",
                11 => "بهمن",
                12 => "اسفند",
                _ => string.Empty,
            };
        }
    }
}
