var s = "AABABBA";
var k = 1;

var result = CharacterReplacement(s, k);
Console.WriteLine(result);

int CharacterReplacement(string s, int k)
{
    var characterCount = new Dictionary<char, int>();
    var start = 0;
    var max = 0;
    var maxFreq = 0;

    for (var end = 0; end < s.Length; end++)
    {
        characterCount[s[end]] = characterCount.GetValueOrDefault(s[end], 0) + 1;

        maxFreq = Math.Max(maxFreq, characterCount[s[end]]);

        while (end - start + 1 - maxFreq > k)
        {
            characterCount[s[start]]--;
            start++;

        }

        max = Math.Max(max, end - start + 1);
    }

    return max;
}