

//Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it.

//Lily decides to share a contiguous segment of the bar selected such that:

//The length of the segment matches Ron's birth month, and,
//The sum of the integers on the squares is equal to his birth day.
//Determine how many ways she can divide the chocolate.

int birthday(List<int> s, int d, int m)
{
    
    int count = 0;

    

    for (int i = 0; i <= s.Count-m; i++)
    {
        int sm = 0;

        for (int j = 0; j < m; j++)
        {
            sm += s[i + j]; 
        }

        if (sm == d)
        {
            count++;
        }
      
    }

    return count;
}

Console.WriteLine(birthday(new List<int> { 2, 2, 1, 3, 2 }, 4, 2));
Console.WriteLine(birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2));
Console.WriteLine(birthday(new List<int> { 1, 1, 1, 1, 1,1 }, 3, 2));
Console.WriteLine(birthday(new List<int> { 2 ,5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 }, 18, 7));
Console.WriteLine(birthday(new List<int> { 4 }, 4, 1));