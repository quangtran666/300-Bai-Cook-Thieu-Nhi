var s = "ADOBECODEBANC";
var t = "ABC";

var result = MinWindow(s, t);
Console.WriteLine(result);


string MinWindow(string s, string t)
{
    var tDict =t
        .GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.ToList().Count);

    int[] res = [-1, -1];
    var maxValue = int.MaxValue;
    
    for (var i = 0; i < s.Length; i++)
    {
        var sDict = new Dictionary<char, int>();
        for (var j = i; j < s.Length; j++)
        {
            sDict[s[j]] = sDict.GetValueOrDefault(s[j], 0) + 1;

            var flag = true;

            foreach (var key in tDict.Keys)
            {
                if (!sDict.ContainsKey(key) || sDict[key] < tDict[key])
                {
                    flag = false;
                    break;
                }
            }

            if (flag && (j - i + 1) < maxValue)
            {
                maxValue = j - i + 1;
                res[0] = i;
                res[1] = j;
            }
        }
    }

    return maxValue == int.MaxValue ? "" : s.Substring(res[0], maxValue);
}

