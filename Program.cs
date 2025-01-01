var s = "AABABBA";
var k = 1;

var result = CharacterReplacement(s, k);
Console.WriteLine(result);

int CharacterReplacement(string s, int k)
{
    var characterCount = new Dictionary<char, int>();
    var start = 0;
    var end = 0;
    var max = 0;

    for (end = 0; end < s.Length; end++)
    {
        characterCount[s[end]] = characterCount.GetValueOrDefault(s[end], 0) + 1;

        var characterMostFrequent = characterCount.Values.Max();

        if (end - start + 1 - characterMostFrequent <= k)
        {
            max = Math.Max(max, end - start + 1);
        }
        else
        {
            while (end - start + 1 - characterMostFrequent > k)
            {
                characterCount[s[start]]--;
                start++;
            }
        }
    }

    return max;
}