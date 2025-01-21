var points = new int[][] { [3,3],[5,-1],[-2,4] };

var k = 2;

var result = KClosest(points, k);

int[][] KClosest(int[][] points, int k)
{
    var maxHeap = new PriorityQueue<int[], double>();

    for (var i = 0; i < k; i++)
    {
        maxHeap.Enqueue(points[i], -Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]));
    }
    
    for (var i = k; i < points.Length; i++)
    {
        var distanceCurrent = Math.Sqrt(points[i][0] * points[i][0] + points[i][1] * points[i][1]);
        var distancePeek = Math.Sqrt(maxHeap.Peek()[0] * maxHeap.Peek()[0] + maxHeap.Peek()[1] * maxHeap.Peek()[1]);

        if (distanceCurrent < distancePeek)
        {
            maxHeap.Dequeue();
            maxHeap.Enqueue(points[i], -distanceCurrent);
        }
    }

    var result = new int[k][];
    for (var i = 0; i < k; i++)
    {
        result[i] = maxHeap.Dequeue();
    }
    
    return result;
}