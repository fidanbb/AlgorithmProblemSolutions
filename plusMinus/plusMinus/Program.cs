

 static void plusMinus(List<int> arr)
{
    int countOfNegative = 0;
    int countOfPositive = 0;
    int countOfZero = 0;

    foreach (var item in arr)
    {
        if (item < 0)
        {
            countOfNegative += 1;
        }
        if (item > 0)
        {
            countOfPositive += 1;
        }
        if (item == 0)
        {
            countOfZero += 1;
        }
    }

    Console.WriteLine(((double)countOfPositive / (double)arr.Count).ToString("0.000000"));
    Console.WriteLine(((double)countOfNegative/ (double)arr.Count).ToString("0.000000"));
  
    Console.WriteLine(((double)countOfZero/ (double)arr.Count).ToString("0.000000"));
}


plusMinus(new List<int>{ -4 ,3 ,- 9, 0, 4, 1});