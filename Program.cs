using System.Text.RegularExpressions;

var s = "race a car";

var result = IsPalindrome(s);
Console.WriteLine(result);

bool IsPalindrome(string s)
{
    var newString = "";
    foreach (var @char in s)
    {
        if (char.IsLetterOrDigit(@char))
        {
            newString += char.ToLower(@char);
        }
    }
    
    return newString == new string(newString.Reverse().ToArray());
}