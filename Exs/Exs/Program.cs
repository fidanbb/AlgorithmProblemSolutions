


#region Find the first non-repeating character in a string.

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

Console.WriteLine(FirstNonRepeatingChar("swiss"));    // Output: 'w'
Console.WriteLine(FirstNonRepeatingChar("racecar")); // Output: 'e'
Console.WriteLine(FirstNonRepeatingChar("aabb"));   // Output: '\0'

#endregion


#region Find the Missing Number in an Array

int FindMissingNum(List<int> list)
{
    int n = list.Count;
    int expectedSum = (n * (n + 1) / 2);
    int actualSum = list.Sum();

    return expectedSum - actualSum;
}


Console.WriteLine(FindMissingNum(new List<int> { 9, 6, 4, 2, 3, 5, 7, 0, 1 }));
Console.WriteLine(FindMissingNum(new List<int> { 3, 0, 1 }));


#endregion