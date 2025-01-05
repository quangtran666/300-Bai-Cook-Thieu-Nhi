var s = "3[a2[c]]";

var result = DecodeString(s);
Console.WriteLine(result);

string DecodeString(string c)
{
    var stack = new Stack<string>();
    var number_repeated = 0;
    var encoded_string = "";

    foreach (var character in c)
    {
        if (char.IsNumber(character))
            number_repeated = number_repeated * 10 + int.Parse(character.ToString());
        else if (char.IsLetter(character)) 
            encoded_string += character;
        else if (character == '[')
        {
            stack.Push(encoded_string);
            stack.Push(number_repeated.ToString());
            number_repeated = 0;
            encoded_string = "";
        } else if (character == ']')
        {
            var num = int.Parse(stack.Pop());
            var previous_string = stack.Pop();
            encoded_string = previous_string + string.Concat(Enumerable.Repeat(encoded_string, num));
        }
    }

    return encoded_string;
}