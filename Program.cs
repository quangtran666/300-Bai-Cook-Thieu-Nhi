string[] strs = ["eat","tea","tan","ate","nat","bat"];

var result = GroupAnagrams(strs);

result.ToList().ForEach(x => {
    Console.WriteLine(x);
});

IList<IList<string>> GroupAnagrams(string[] strs) {
    var dict = new Dictionary<string, IList<int>>();
    var result = new List<IList<string>>();

    for (int i = 0; i < strs.Length; i++) {
        var characters = strs[i].ToCharArray();
        Array.Sort(characters);
        if (dict.TryGetValue(new string(characters), out var actualValue)) {
            actualValue.Add(i);
            continue;
        }
        dict[new string(characters)] = [i];
    }

    foreach (var key in dict.Keys) {
        var anagramTogether = dict[key].Select(x => strs[x]).ToList();
        result.Add(anagramTogether);
    }

    return result;
}