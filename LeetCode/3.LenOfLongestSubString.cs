namespace LeetCode;

public class MaxSubString
{
    public static int LenOfLongestSubString(string InStr)
    {
        if (string.IsNullOrEmpty(InStr)) return 0;
        int len = InStr.Length;
        if (len == 1) return 1;

        int max = 0, left = 0;
        Dictionary<char, int> dict = new Dictionary<char, int>(128);
        
        for (int right = 0; right < len; right++)
        {
            char ch = InStr[right];
            left = dict.TryGetValue(ch, out var l) ? l > left ? l : left : left;
            dict[ch] = right + 1;
            int m = right - left + 1;
            if (m > max) max = m;
        }

        return max;
    }
}