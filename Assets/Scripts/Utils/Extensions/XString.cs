using UnityEngine;

namespace Utils.Extensions
{
    public static class XString
    {
        public static string ColorString(this string str, Color color)
        {
            return $"<color=#{color.ToHexStringWithoutAlpha()}>{str}</color>";
        }
    }
}