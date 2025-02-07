var words = new string[] { "Hello", "Alaska", "Dad", "Peace" };

Console.WriteLine(string.Join(", ", FindWords(words)));

string[] FindWords(string[] words)
{
    var hashset1 = new HashSet<char>("qwertyuiop");
    var hashset2 = new HashSet<char>("asdfghjkl");
    var hashset3 = new HashSet<char>("zxcvbnm");
    var result = new List<string>();

    for (int i = 0; i < words.Length; i++)
    {
        var init = 0;
        var check = 0;
        var indicator = true;
        
        if (hashset1.Contains(words[i].ToLower()[0])) init = 1;
        else if (hashset2.Contains(words[i].ToLower()[0])) init = 2;
        else if (hashset3.Contains(words[i].ToLower()[0])) init = 3;

        for (var j = 1; j < words[i].Length; j++)
        {
            if (hashset1.Contains(words[i].ToLower()[j])) check = 1;
            else if (hashset2.Contains(words[i].ToLower()[j])) check = 2;
            else if (hashset3.Contains(words[i].ToLower()[j])) check = 3;
            
            if (init != check)
            {
                indicator = false;
                break;
            }

            indicator = true;
        }
        
        if (indicator) result.Add(words[i]);
    }
    
    return result.ToArray();
}