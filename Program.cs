var haystack = "sadbutsad";
var needle = "sad";

var result = StrStr(haystack, needle);

Console.WriteLine(result);

int StrStr(string haystack, string needle) {
    var pointer = 0;
    var result = -1;

    for (var i = 0; i < haystack.Length; i++)
    {
        var pointer2 = i;

        while (pointer2 < haystack.Length && pointer < needle.Length && haystack[pointer2] == needle[pointer])
        {
            pointer++;
            pointer2++;
        }

        if (pointer == needle.Length)
        {
            result = i;
            break;
        }
        
        pointer = 0;
    }
    
    return result;
}