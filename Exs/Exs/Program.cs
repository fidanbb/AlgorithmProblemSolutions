


#region Find the first non-repeating character in a string.

using System.Collections.Generic;
using System.Text;

char FirstNonRepeatingChar(string str)
{
    Dictionary<char, int> charCount = new Dictionary<char, int>();

    foreach (char c in str)
    {
        if (charCount.ContainsKey(c))
            charCount[c]++;
        else
            charCount[c] = 1;
    }

    foreach (char c in str)
    {
        if (charCount[c] == 1)
            return c;
    }

    return '\0';
}

//Console.WriteLine(FirstNonRepeatingChar("swiss"));    // Output: 'w'
//Console.WriteLine(FirstNonRepeatingChar("racecar")); // Output: 'e'
//Console.WriteLine(FirstNonRepeatingChar("aabb"));   // Output: '\0'

#endregion


#region Find the Missing Number in an Array

int FindMissingNum(List<int> list)
{
    int n = list.Count;
    int expectedSum = (n * (n + 1) / 2);
    int actualSum = list.Sum();

    return expectedSum - actualSum;
}


//Console.WriteLine(FindMissingNum(new List<int> { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
//Console.WriteLine(FindMissingNum(new List<int> { 3, 0, 1 }));


#endregion

#region Find sum of 2 positive absolute value. Values must be string

string Sum(string val1, string val2)
{
    if (val1.Length > val2.Length)
        val2 = val2.PadLeft(val1.Length, '0');
    else
        val1 = val1.PadLeft(val2.Length, '0');

    var sb = new StringBuilder();
    int leapVal = 0;

    for (int i = val1.Length - 1; i >= 0; i--)
    {
        var firstVal = int.Parse(val1[i].ToString());
        var lastVal = int.Parse(val2[i].ToString());

        var total = firstVal + lastVal + leapVal;

        leapVal = total > 9 ? 1 : 0;
        total %= 10;

        sb.Insert(0,total);
    }

    if (leapVal > 0)
        sb.Insert(0, 1);

    return sb.ToString();
}

Console.WriteLine(Sum("99", "101"));
Console.WriteLine(Sum("5467", "2"));
Console.WriteLine(Sum("34558695065967237428", "10000000000000000000000000000"));
Console.WriteLine(Sum("999999999888877555", "1111133333444999998888b"));

#endregion

#region LRU cache question


var cache = new LRUCache(2);

cache.Put(1, 1);                        // Adds the key 1 with value 1 to the cache
cache.Put(2, 2);                        // Adds the key 2 with value 2 to the cache
//Console.WriteLine(cache.Get(1));        // returns 1
cache.Put(3, 3);                        // evicts key 2
//Console.WriteLine(cache.Get(2));        // returns -1 (not found)
cache.Put(4, 4);                        // evicts key 1
//Console.WriteLine(cache.Get(1));        // returns -1 (not found)
//Console.WriteLine(cache.Get(3));        // returns 3
//Console.WriteLine(cache.Get(4));        // returns 4

class LRUCache
{
    private readonly int capacity;
    private readonly Dictionary<int, int> cache;
    private readonly List<int> usageOrder;
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        cache = new Dictionary<int, int>();
        usageOrder = new List<int>();
    }
    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            cache[key] = value;        // update the value of the key
            usageOrder.Remove(key);    // remove the key from the usage order
            usageOrder.Add(key);       // add the key to the end of the usage order
        }
        else
        {
           if (cache.Count() == capacity) // reached capacity
            {
                int lruKey = usageOrder[0];  // get the least recently used key
                usageOrder.RemoveAt(0); // remove the least recently used key
                cache.Remove(lruKey);  // remove the least recently used key from the cache
            }

            cache[key] = value;     // add the new key to the cache
            usageOrder.Add(key);     // add the new key to the usage order

        }
           
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key))
            return -1;

        usageOrder.Remove(key);  // remove the key from the usage order
        usageOrder.Add(key);     // add the key to the end of the usage order


        return cache[key];
    }
}

#endregion



