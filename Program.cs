var target = 12;
int[] position = [10, 8, 0, 5, 3];
int[] speed = [2, 4, 1, 1, 3];

var result = CarFleet(target, position, speed);
Console.WriteLine(result);

int CarFleet(int target, int[] position, int[] speed) {
    int[][] pair = new int[position.Length][];
    for (int i = 0; i < position.Length; i++) {
        pair[i] = [position[i], speed[i]];
    }
    Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
    Stack<double> stack = new Stack<double>();
    foreach (var p in pair) {
        stack.Push((double)(target - p[0]) / p[1]);
        if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
            stack.Pop();
        }
    }
    return stack.Count;
}