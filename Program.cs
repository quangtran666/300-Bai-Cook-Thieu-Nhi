var words = new string[] { "Hello", "Alaska", "Dad", "Peace" };

Console.WriteLine(string.Join(", ", FindWords(words)));

string[] FindWords(string[] words)
{
    var hashset1 = new HashSet<char>("qwertyuiop");
    var hashset2 = new HashSet<char>("asdfghjkl");
    var hashset3 = new HashSet<char>("zxcvbnm");
    var result = new List<string>();

    foreach (var word in words)
    {
        var subhashset = new HashSet<char>(word.ToLower());
        
        if (subhashset.IsSubsetOf(hashset1) || subhashset.IsSubsetOf(hashset2) || subhashset.IsSubsetOf(hashset3))
        {
            result.Add(word);
        }
    }
    
    return result.ToArray();
}