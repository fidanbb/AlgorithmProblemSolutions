#region 1-divisibleSumPairs

int divisibleSumPairs(int n, int k, List<int> ar)
{
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            int sum = ar[i] + ar[j];

            if (sum % k == 0) count++;
        }
    }

    return count;
}



//Console.WriteLine(divisibleSumPairs(6,3, new List<int>() { 1, 3, 2, 6, 1, 2 }));

#endregion

#region 2-getMoneySpent
static int getMoneySpent(int[] keyboards, int[] drives, int b)
{
    if (keyboards.Min() + drives.Min() > b)
    {
        return -1;
    }

    int maxSum = 0;

    foreach (var keyboard in keyboards)
    {
        foreach (var drive in drives)
        {
            if ((maxSum < (keyboard + drive)) && ((keyboard + drive) <= b))
            {
                maxSum = keyboard + drive;
            }
        }
    }

    return maxSum;

}
//Console.WriteLine(getMoneySpent(new int[]{ 40,50,60},new int[]{5,8,2},60));
#endregion

#region 3-formingMagicSquare
int formingMagicSquare(List<List<int>> s)
{
    List<List<int>> magicSquares = new List<List<int>>
    {
        new List<int>{8,1,6,3,5,7,4,9,2},
        new List<int>{6,1,8,7,5,3,2,9,4},
        new List<int>{4,9,2,3,5,7,8,1,6},
        new List<int>{2,9,4,7,5,3,6,1,8},
        new List<int>{8,3,4,1,5,9,6,7,2},
        new List<int>{4,3,8,9,5,1,2,7,6},
        new List<int>{6,7,2,1,5,9,8,3,4},
        new List<int>{2,7,6,9,5,1,4,3,8 }
    };

    int minCost = int.MaxValue;


    foreach (var item in magicSquares)
    {
        int cost = 0;

        for (int i = 0; i < 9; i++)
        {

            int row = i / 3;
            int col = i % 3;

            cost += Math.Abs(s[row][col] - item[i]);

        }

        minCost = Math.Min(minCost, cost);
    }


    return minCost;
}

#endregion

#region 4-Migratory-Birds

int migratoryBirds(List<int> arr)
{
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < arr.Count; i++)
    {
        int count = 1;

        if (dict.ContainsKey(arr[i]))
        {
            count = dict[arr[i]];
            count++;
            dict[arr[i]] = count;

            continue;
        }

        dict.Add(arr[i], count);

    }

    int maxValue = dict.Values.Max();

    int minKey = dict.Where(kvp => kvp.Value == maxValue)
                     .OrderBy(kvp => kvp.Key)
                     .First().Key;

    return minKey;
}

//Console.WriteLine(migratoryBirds(new List<int> { 1, 1, 2, 2,3 }));
//Console.WriteLine(migratoryBirds(new List<int> { 1, 4, 4, 4,5, 3 }));
//Console.WriteLine(migratoryBirds(new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }));

#endregion

#region 5-BonAppetit
void bonAppetit(List<int> bill, int k, int b)
{
    int totalAmount = 0;

    for (int i = 0; i < bill.Count; i++)
    {
        if (i != k)
        {
            totalAmount += bill[i];
        }
    }

    var annaMustPay = totalAmount / 2;

    if (annaMustPay == b)
        Console.WriteLine("Bon Appetit");
    else
        Console.WriteLine(b - annaMustPay);
}

//bonAppetit(new List<int> { 3, 10, 2,9}, 1, 12);
//bonAppetit(new List<int> { 3, 10, 2, 9 }, 1, 7);

#endregion

#region 6-PageCount
int pageCount(int n, int p)
{
    int frontTurns = p / 2;
    int backTurns = (n / 2) - (p / 2);

    return Math.Min(frontTurns, backTurns);
}

//Console.WriteLine(pageCount(6, 2));
//Console.WriteLine(pageCount(5, 4));

#endregion

#region 7-CountingValleys

int countingValleys(int steps, string path)
{
    int hiking = 0;
    int valleyCount = 0;

    char[] pathArr = path.ToCharArray();

    foreach (char step in pathArr)
    {
        if (step == 'U')
        {
            hiking++;

            if (hiking == 0)
            {
                valleyCount++;
            }
        }
        else
        {
            hiking--;
        }
    }

    return valleyCount;
}

//Console.WriteLine(countingValleys(8, "UDDDUDUU"));
//Console.WriteLine(countingValleys(12, "DDUUDDUDUUUD"));

#endregion

#region 8-CatAndMouse

string catAndMouse(int x, int y, int z)
{
    int catAStep = Math.Abs(z - x);
    int catBStep = Math.Abs(z - y);

    if (catAStep < catBStep)
        return "Cat A";
    if (catAStep > catBStep)
        return "Cat B";

    return "Mouse C";
}

//Console.WriteLine(catAndMouse(2, 5, 4));
//Console.WriteLine(catAndMouse(1, 2, 3));
//Console.WriteLine(catAndMouse(1, 3, 2));

#endregion

#region 9-PickingNumbers

int pickingNumbers(List<int> a)
{
    int[] count = new int[101];

    foreach (var item in a)
    {
        count[item]++;
    }

    int maxSubSetSize = 0;

    for (int i = 0; i < 100; i++)
    {
        maxSubSetSize = Math.Max(maxSubSetSize, count[i] + count[i + 1]);
    }

    return maxSubSetSize;
}

//Console.WriteLine(pickingNumbers(new List<int> { 1, 2, 2, 3, 1, 2 }));
//Console.WriteLine(pickingNumbers(new List<int> { 1, 1, 2, 2, 4, 4, 5, 5, 5 }));
//Console.WriteLine(pickingNumbers(new List<int> { 4, 6, 5, 3, 3, 1 }));

#endregion

#region 10-ClimbingLeaderBoard

List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    var uniqieRanks = ranked.Distinct().ToList(); //remove dublicates from rankedList
    var result = new List<int>();

    int index = uniqieRanks.Count - 1;

    foreach (int score in player)
    {
        while (index >= 0 && score >= uniqieRanks[index])
        {
            index--;
        }
        result.Add(index + 2);
    }

    return result;
}

var result = climbingLeaderboard(new List<int> { 100, 90, 90, 80, 75, 60 }, new List<int> { 50, 65, 77, 90, 102 });

foreach (var item in result)
{
    //Console.WriteLine(item);
}

#endregion

#region 11-HurdleRace
int hurdleRace(int k, List<int> height)
{
    int maxHeight = height[0];

    foreach (var item in height)
    {
        if (item > maxHeight)
        {
            maxHeight = item;
        }

    }

    if (maxHeight > k)
        return maxHeight - k;

    return 0;
}

//Console.WriteLine(hurdleRace(4, new List<int> { 1, 6, 3, 5, 2 }));
//Console.WriteLine(hurdleRace(7, new List<int> { 2, 5, 4, 5, 2 }));

#endregion

#region 12-designerPdfViewer

int DesignerPdfViewer(List<int> h, string word)
{
    int maxHeight = 0;

    foreach (char letter in word)
    {
        int index = letter - 'a';
        maxHeight = Math.Max(maxHeight, h[index]);
    }

    int area = maxHeight * word.Length;

    return area;
}

var heights = new List<int> { 1, 3, 1, 3, 1, 4, 1, 1, 1, 1, 2, 1, 1, 2, 2, 3, 1, 2, 1, 3, 1, 3, 1, 1, 3, 2 };

string word = "zaba";

//Console.WriteLine(DesignerPdfViewer(heights, word));

#endregion

#region 13-find if a positive integer is prime or not

static bool FindPrime(int num)
{
    if (num <= 1) return false;

    if (num == 2) return true;
    if (num % 2 == 0) return false;

    int limit = (int)Math.Sqrt(num);

    for (int i = 3; i <= limit; i += 2)
    {
        if (num % i == 0)
            return false;

    }

    return true;
}

bool isPrime = FindPrime(17);

//if (isPrime)
//    Console.WriteLine("Prime");
//else
//    Console.WriteLine("Not Prime");

#endregion

#region RomanToInt LEETCODE
static int RomanToInt(string s)
{
    var roman = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    int total = 0;
    int prev = 0;

    for (int i = s.Length - 1; i >= 0; i--)
    {
        int current = roman[s[i]];

        if (current < prev)
            total -= current;
        else
            total += current;

        prev = current;
    }

    return total;
}
//Console.WriteLine(RomanToInt("III"));

#endregion

#region Longest Common Prefix LEETCODE
string LongestCommonPrefix(string[] strs)
{

    // first way

    //string startPrefix = strs[0];

    //for (int i = 1; i < strs.Length; i++)
    // {
    //     while (!strs[i].StartsWith(startPrefix))
    //     {
    //         startPrefix = startPrefix.Substring(0, startPrefix.Length - 1);

    //         if (startPrefix == "") return string.Empty;
    //     }
    // }

    // return startPrefix;


    string prefix = string.Empty;

    for (int i = 0; i < strs[0].Length; i++)
    {
        char c = strs[0][i];

        for (int j = 1; j < strs.Length; j++)
        {
            if (i >= strs[j].Length || strs[j][i] != c)
                return prefix;
        }

        prefix += c;
    }


    return prefix;
}


Console.WriteLine(LongestCommonPrefix(new string[] { "flower", "flow", "flight" })); // output fl
Console.WriteLine(LongestCommonPrefix(new string[] { "dog", "racecar", "car" })); // output empty string ""
#endregion