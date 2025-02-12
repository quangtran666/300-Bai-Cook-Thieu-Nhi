var s = "xyzzaz";

var result = CountGoodSubstrings(s);

Console.WriteLine(result);

int CountGoodSubstrings(string s)
{
    var result = 0;

    for (var i = 0; i < s.Length - 2; i++)
    {
        var hashset = new HashSet<int>([s[i], s[i + 1], s[i + 2]]);
        if (hashset.Count == 3)
        {
            result++;
        }
    }
    
    return result;
}