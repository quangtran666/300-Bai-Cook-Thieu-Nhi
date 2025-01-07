int[] temperatures = [30, 40, 50, 60];

foreach (var temperature in DailyTemperatures(temperatures))
{
    Console.WriteLine(temperature);
}

int[] DailyTemperatures(int[] temperatures)
{
    var result = new int[temperatures.Length];
    var monotonicStack = new Stack<int>();

    for (var x = 0; x < temperatures.Length; x++)
    {
        while (monotonicStack.Any() && temperatures[x] > temperatures[monotonicStack.Peek()])
        {
            var value = monotonicStack.Pop();
            result[value] = x - value;
        }

        monotonicStack.Push(x);
    }

    return result;
}