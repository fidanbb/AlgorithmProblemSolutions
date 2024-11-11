
//Task description in hackerrank
//There is a large pile of socks that must be paired by color. Given an array of 
//    integers representing the color of each sock, determine how many pairs of socks with 
//    matching colors there are.




//method 1 with Dictionary

// int sockMerchant(int n, List<int> ar)
//{
//    var dict = ar.GroupBy(item => item).ToDictionary(g => g.Key, g => g.Count());

//    int pairs = 0;

//    foreach (var item in dict)
//    {  
//        pairs += item.Value / 2;
//    }

//    return pairs;
//}



//Method 2 with HashSet
int sockMerchant(int n, List<int> ar)
{
    var unmatched = new HashSet<int>();

    int pairs = 0;

    foreach (var item in ar)
    {
        if (unmatched.Contains(item))
        {
            pairs++;
            unmatched.Remove(item);
        }
        else
        {
            unmatched.Add(item);
        }
    }

    return pairs;
}

Console.WriteLine(sockMerchant(7,new List<int>{1,2,1,2,1,3,2 }));