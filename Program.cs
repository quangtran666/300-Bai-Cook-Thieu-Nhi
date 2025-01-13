var timeMap = new TimeMap();
timeMap.Set("foo", "bar", 1);
timeMap.Get("foo", 1);
timeMap.Get("foo", 3);
timeMap.Set("foo", "bar2", 4);
timeMap.Get("foo", 4);
timeMap.Get("foo", 5);

public class TimeMap
{
    private readonly Dictionary<string, List<Tuple<int, string>>> _dictionary;
    
    public TimeMap()
    {
        _dictionary = new Dictionary<string, List<Tuple<int, string>>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!_dictionary.ContainsKey(key))
            _dictionary.Add(key, new List<Tuple<int, string>>());
        
        _dictionary[key].Add(Tuple.Create(timestamp, value));
    }
    
    public string Get(string key, int timestamp)
    {
        var result = "";
        
        if (!_dictionary.ContainsKey(key))
            return result;
        
        var list = _dictionary[key];
        var left = 0;
        var right = list.Count - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (list[mid].Item1 <= timestamp) {
                result = list[mid].Item2;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }
}