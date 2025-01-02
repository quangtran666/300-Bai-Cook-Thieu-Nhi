var s1 = "adc";
var s2 = "dcda";

var result = CheckInclusion(s1, s2);
Console.WriteLine(result);

bool CheckInclusion(string s1, string s2)
{
    var s1Dict = s1
        .GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.ToList().Count);

    for (var i = 0; i < s2.Length - s1.Length; i++)
    {
        var s2SubDict = new Dictionary<char, int>();

        for (var j = i; j < i + s1.Length; j++)
        {
            s2SubDict[s2[j]] = s2SubDict.GetValueOrDefault(s2[j], 0) + 1;
        }

        if (s1Dict.OrderBy(x => x.Key).SequenceEqual(s2SubDict.OrderBy(x => x.Key)))
            return true;
    }

    return false;
}