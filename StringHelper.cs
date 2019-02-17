using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            str.ToLower;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (str.Contains("a") || str.Contains("e") || str.Contains("i") || str.Contains("o") || str.Contains("u"))
                {
                    count++;
                }
            return count;
        }
    }
}
