using System.Text.RegularExpressions;

var s = "race a car";

var result = IsPalindrome(s);
Console.WriteLine(result);

bool IsPalindrome(string s)
{
    var cleanString = CleanString(s);

    for (var i = 0; i < cleanString.Length; i++)
    {
        if (cleanString[i] == cleanString[cleanString.Length - 1 - i])
            continue;
        return false;
    }

    return true;
}

string CleanString(string s)
{
    return Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");
}