var s = "dvdf";

var result = LengthOfLongestSubstring(s);

Console.WriteLine(result);

int LengthOfLongestSubstring(string s)
{
    var hashset = new HashSet<char>();
    var start = 0;
    var end = 0;
    var max = 0;

    for (end = 0; end < s.Length; end++)
    {
        while (hashset.Contains(s[end]) && start < end)
        {
            hashset.Remove(s[start]);
            start++;
        }

        hashset.Add(s[end]);

        max = Math.Max(max, end - start + 1);
    }

    return max;
}