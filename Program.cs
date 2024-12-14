using System.Text;

string[] input = ["neet","code","love","you"];

var encode = Encode(input);

Console.WriteLine("encode value: " + encode);

var decode = Decode(encode);

foreach (var result in decode) {
    Console.WriteLine("Decode value: " + result);
}

string Encode(IList<string> strs)
{
    var result = "";

    foreach (var str in strs) {
        result += str.Length + "#" + str;
    }

    return result;
}

List<string> Decode(string s)
{
    var result = new List<string>();
    var encodeKey = "";

    for  (var i = 0; i < s.Length;) {
        if (Char.IsNumber(s[i])) {
            encodeKey += $"{s[i]}";
            i++;
        } else if (s[i] == '#') {
            var characterLength = int.Parse(encodeKey); 
            var textDecode = "";
            for (var j = i + 1; j <= i + characterLength; j++) {
                textDecode += $"{s[j]}";
            }
            result.Add(textDecode);
            i += characterLength + 1;
            encodeKey = "";
        }
    }

    return result;
}   