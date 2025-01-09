var piles = new[] {30,11,23,4,20};
var h = 6;

var result = MinEatingSpeed(piles, h);
Console.WriteLine(result);

int MinEatingSpeed(int[] piles, int h) {
    var speed = 1;
    while (TimeTake(speed) > h)
    {
        speed++;
    }

    return speed;

    int TimeTake(int speed)
    {
        var time = piles.Sum(pile => (pile + speed - 1) / speed);
        return time;
    }
}