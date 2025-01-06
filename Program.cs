string[] tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"];

var result = EvalRPN(tokens);
Console.WriteLine(result);

int EvalRPN(string[] tokens)
{
    var stack = new Stack<int>();

    foreach (var token in tokens)
    {
        switch (token)
        {
            case "+":
                var pop1Plus = stack.Pop();
                var pop2Plus = stack.Pop();
                stack.Push(pop2Plus+pop1Plus);
                break;
            case "-":
                var pop1Minus = stack.Pop();
                var pop2Minus = stack.Pop();
                stack.Push(pop2Minus-pop1Minus);
                break;
            case "*":
                var pop1Mul = stack.Pop();
                var pop2Mul = stack.Pop();
                stack.Push(pop2Mul*pop1Mul);
                break;
            case "/":
                var pop1 = stack.Pop();
                var pop2 = stack.Pop();
                stack.Push(pop2 / pop1);
                break;
            default:
                stack.Push(int.Parse(token));
                break;
        }
    }

    return stack.Pop();
}