var piles = new[] {312884470};
var h = 968709470;

var result = MinEatingSpeed(piles, h);
Console.WriteLine(result);

int MinEatingSpeed(int[] piles, int h) {
    int TimeTaken(int speed)
    {
        var time = piles.Sum(x => (x + speed - 1) / speed);
        return time;
    }

    var left = 1;
    var right = piles.Max();

    while (left < right)
    {
        var mid = (left + right) / 2;
        if (TimeTaken(mid) > h)
            left = mid + 1;
        else
            right = mid;
    }

    return left;
}