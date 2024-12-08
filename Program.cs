var s = "aacc";
var t = "ccac";
var result = IsAnagram(s, t);
Console.WriteLine(result);

bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;

    var sHashtable = new Dictionary<char, int>();
    var tHashtable = new Dictionary<char, int>();

    foreach (var character in s)  {
        if (sHashtable.TryGetValue(character, out var actualValue)) {
            sHashtable[character] = actualValue + 1;
            continue;
        }
        sHashtable.Add(character, 1);
    }

    foreach (var character in t)  {
        if (tHashtable.TryGetValue(character, out var actualValue)) {
            tHashtable[character] = actualValue + 1;
            continue;
        }
        tHashtable.Add(character, 1);
    }

    Console.WriteLine(sHashtable['a']);
    Console.WriteLine(tHashtable['a']);

    foreach (var key in sHashtable.Keys) {
        if (sHashtable.TryGetValue(key, out var _) && tHashtable.TryGetValue(key, out var _) && sHashtable[key] == tHashtable[key])
            continue;
        return false;    
    }

    return true;
}