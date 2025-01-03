var s = "ADOBECODEBANC";
var t = "ABC";

var result = MinWindow(s, t);
Console.WriteLine(result);


string MinWindow(string s, string t)
{
    var tDict = t
        .GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.ToList().Count);

    List<LeftRightResult> res = [];
    
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

            if (flag)
            {
                res.Add(new LeftRightResult {left = i, right = j});
            }
        }
    }

    if (res.Count == 0) return "";
    
    var leftRight = res
        .OrderBy(x => x.right - x.left)
        .First();

    var result = "";

    for (var i = leftRight.left; i <= leftRight.right; i++)
    {
        result += s[i];
    }

    return result;
}


struct LeftRightResult
{
    public int left;
    public int right;
}
