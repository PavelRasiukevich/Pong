using UnityEngine;

namespace Utils.Extensions
{
    public static class XString
    {
        public static string PaintString(this string str, Color color)
        {
            return $"<color=#{color.ToHexStringWithoutAlpha()}>{str}</color>";
        }
    }
}