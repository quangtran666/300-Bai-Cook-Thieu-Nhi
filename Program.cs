var word1 = "ab";
var word2 = "pqrs";

Console.WriteLine(MergeAlternately(word1, word2));

string MergeAlternately(string word1, string word2)
{
    var result = "";
    var i = 0;
    var j = 0;

    while (i < word1.Length || j < word2.Length)
    {
        result += i < word1.Length ? word1[i] : "";
        result += j < word2.Length ? word2[j] : "";
        i++;
        j++;
    }
    
    return result;
}