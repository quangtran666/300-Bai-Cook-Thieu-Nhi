var s = "()[]{}";

var result = IsValid(s);
Console.WriteLine(result);

bool IsValid(string s) {
    var stack = new Stack<char>();
    var dictMap = new Dictionary<char, char>()
    {
        ['('] = ')',
        ['{'] = '}',
        ['['] = ']'
    };
    
    foreach (var @char in s)
    {
        if (dictMap.ContainsKey(@char))
            stack.Push(@char);
        else if (stack.Count > 0 && dictMap[stack.Peek()] == @char)
            stack.Pop();
        else
            return false;
    }
    
    return stack.Count == 0;
}