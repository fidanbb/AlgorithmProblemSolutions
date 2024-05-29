

#region solution1
static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    int countOfApples = 0;
    int countOfOranges = 0;


    foreach (int apple in apples)
    {
        if (apple + a >= s && apple + a <= t)
        {
            countOfApples++;
        }
    }


    foreach(var orange in oranges)
    {
        if (orange + b >= s && orange + b <= t)
        {
            countOfOranges++;
        }
    }
  
    Console.WriteLine(countOfApples);
    Console.WriteLine(countOfOranges);
}
#endregion

#region solution2
//static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
//{
//    int countOfApples = apples.Count(apple => apple + a >= s && apple + a <= t);
//    int countOfOranges = oranges.Count(orange=> orange + b >=s&&orange + b <= t);




//    Console.WriteLine(countOfApples);
//    Console.WriteLine(countOfOranges);
//}

#endregion

countApplesAndOranges(7,10,4,12,new List<int> { 2,3,-4},new List<int> { 3,-2,-4});