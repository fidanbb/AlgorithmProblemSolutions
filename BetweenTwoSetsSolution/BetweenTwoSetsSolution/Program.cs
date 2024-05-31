static int GetTotalX(List<int> a, List<int> b)
{
    int maxA = a.Max();
    int minB = b.Min();
    int count = 0;

    for (int x = maxA; x <= minB; x++)
    {
        
        bool isMultipleOfAllA = a.All(elementA => x % elementA == 0);

        
        bool isFactorOfAllB = b.All(elementB => elementB % x == 0);

        if (isMultipleOfAllA && isFactorOfAllB)
        {
            count++;
        }
    }

    return count;
}


List<int> a = new List<int> { 2, 4 };
List<int> b = new List<int> { 16, 32, 96 };

int total = GetTotalX(a, b);
Console.WriteLine(total); 