var s1 = "adc";
var s2 = "dcda";

var result = CheckInclusion(s1, s2);
Console.WriteLine(result);

bool CheckInclusion(string s1, string s2)
{
    var s1Dict = s1
        .GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.ToList().Count);

    var count = s1Dict.Keys.Count;
    
    for (var i = 0; i < s2.Length - s1.Length + 1; i++)
    {
        var s2SubDict = new Dictionary<char, int>();

        var compare = 0;

        for (var j = i; j < i + s1.Length; j++)
        {
            s2SubDict[s2[j]] = s2SubDict.GetValueOrDefault(s2[j], 0) + 1;

            if (s1Dict.ContainsKey(s2[j]) && s2SubDict[s2[j]] == s1Dict[s2[j]])
                compare++;
        }

        if (count == compare)
            return true;
    }

    return false;
}