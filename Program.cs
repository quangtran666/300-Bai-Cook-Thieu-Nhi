var s = "kkdsFuqUfSDKK";

Console.WriteLine(MakeGood(s));

string MakeGood(string s)
{
    var goodStringStack = new Stack<char>();

    foreach (var character in s)
    {
        if (goodStringStack.Any() && goodStringStack.Peek() != character && (char.ToUpper(goodStringStack.Peek()) == character || goodStringStack.Peek() == char.ToUpper(character)))
        {
            goodStringStack.Pop();
        }
        else
        {
            goodStringStack.Push(character);
        }
    }

    return string.Concat(goodStringStack.Select(x => x)).Reverse().ToString();
}