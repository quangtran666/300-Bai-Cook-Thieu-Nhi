var operations = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };

var result = CalPoints(operations);

Console.WriteLine(result);

int CalPoints(string[] operations)
{
    var stack = new Stack<int>();

    foreach (var operation in operations)
    {
        switch (operation)
        {
            case "C":
                stack.Pop();
                break;
            case "D":
                stack.Push(stack.Peek() * 2);
                break;
            case "+":
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                var sum = pop1 + pop2;
                stack.Push(pop2);
                stack.Push(pop1);
                stack.Push(sum);
                break;
            default:
                stack.Push(int.Parse(operation));
                break;
        }
    }
    
    return stack.Sum();
}