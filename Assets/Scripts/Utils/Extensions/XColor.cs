using UnityEngine;

namespace Utils.Extensions
{
    public static class XColor
    {
        public static string ToHexStringWithoutAlpha(this Color color)
        {
            return
                $"{(byte)(color.r * 255):X2}{(byte)(color.g * 255):X2}{(byte)(color.b * 255):X2}";
        }
    }
}