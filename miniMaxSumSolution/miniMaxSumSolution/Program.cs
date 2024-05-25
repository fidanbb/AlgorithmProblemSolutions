
//Given five positive integers, find the minimum and maximum values that can be calculated 
//    by summing exactly four of the five integers. Then print the respective minimum and 
//    maximum values as a single line of two space-separated long integers.



#region Solution1
static void miniMaxSum(List<int> arr)
{
    //find min and max value of arr, then by subtracting min from
    //sumOfArr get maxValue of four elements, vice verse by subtracting
    //max from sumOfArray get minValue of four elements

    long maxValue = arr[0];  //when it is int it fails in some cases in HackerRank

    long minValue = arr[0];

    long sum = 0;

    foreach (var item in arr)
    {
        if (item < minValue)
        {
            minValue = item;
        }

        if (item > maxValue)
        {
            maxValue = item;
        }

        sum += item;

    }

    Console.WriteLine($"{sum - maxValue} {sum - minValue}");
}

#endregion

#region Solution2

// Here first bubble sort the array from minimum to maximum then find sum of first 4 elems and sum of last 4 elems

//Note that it is not efficient way of solving this


//static void miniMaxSum(List<int> arr)
//{
//long sumMin = 0, sumMax = 0;
//for (int i = 0; i < arr.Count - 1; i++)
//{
//    for (int j = 0; j < arr.Count - 1 - i; j++)
//    {
//        if (arr[j] > arr[j + 1])
//        {
//            int temp = arr[j];
//            arr[j] = arr[j + 1];
//            arr[j + 1] = temp;
//        }
//    }

//}

//for (int i = 1; i < arr.Count; i++)
//{
//    sumMin += arr[i - 1];
//    sumMax += arr[i];
//}

//Console.WriteLine($"{sumMin} {sumMax}");
//}
#endregion


miniMaxSum(new List<int> { 1, 3, 5, 7, 9 });